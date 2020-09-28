using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using MySql.Data.MySqlClient;

namespace LoGD.Core.Game.Data.Lib
{
    public sealed class DatabaseTable<TKey, TValue> where TValue : DatabaseRow<TKey, TValue>
    {
        private readonly bool _autoIncrement;
        internal readonly DatabaseColumn[] TableDef;
        private readonly MySqlConnection _connection;
        private string _primaryKey;
        private readonly Dictionary<TKey, TValue> _rows;
        internal readonly ReadOnlyDictionary<TKey, TValue> Data;
        private readonly string _tableName;

        internal DatabaseTable(MySqlConnection connection, string tableName, bool autoIncrement,
            params DatabaseColumn[] tableDef)
        {
            _rows = new Dictionary<TKey, TValue>();
            Data = new ReadOnlyDictionary<TKey, TValue>(_rows);
            this._connection = connection;
            this._tableName = tableName;
            this._autoIncrement = autoIncrement;
            this.TableDef = tableDef;
        }

        public DatabaseRow<TKey, TValue> this[TKey key] => _rows[key];

        internal void CheckTable(MySqlCommand command)
        {
            //todo check structure + get primarykeydata;
            _primaryKey = "armorid";
        }

        internal TValue NewElement()
        {
            return (TValue) Activator.CreateInstance(typeof(TValue), this);
        }

        internal void LoadData(MySqlCommand command)
        {
            command.CommandText = "SELECT * FROM " + _tableName + ";";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                {
                    TValue data = (TValue) Activator.CreateInstance(typeof(TValue), this, reader);
                    if (data != null) _rows.Add(data.GetPrimaryKey(), data);
                }

            reader.Close();
        }

        internal bool UpdateData(TKey primaryKey, ReadOnlyDictionary<string, object> values)
        {
            MySqlCommand update = _connection.CreateCommand();
            update.CommandText = "UPDATE " + _tableName + " SET ";
            foreach (KeyValuePair<string, object> value in values) update.CommandText += value.Key + "='" + value.Value + "',";
            update.CommandText = update.CommandText.TrimEnd(',');
            update.CommandText += " WHERE " + this._primaryKey + " = " + primaryKey + ";";
            return update.ExecuteNonQuery() == 1;
        }

        internal bool InsertData(TValue value)
        {
            if (!_autoIncrement && _rows.ContainsKey(value.GetPrimaryKey()))
                return false;

            MySqlCommand insert = _connection.CreateCommand();
            insert.CommandText = "INSERT INTO " + _tableName + " ";
            string names = "";
            string values = "";
            foreach (KeyValuePair<string, object> data in value.NewValues)
            {
                names += data.Key + ",";
                values += "'" + data.Value + "',";
            }

            insert.CommandText += "(" + names.Trim(',') + ") VALUES (" + values.Trim(',') + ");";
            if (insert.ExecuteNonQuery() != 1)
                return false;

            MySqlCommand read = _connection.CreateCommand();
            read.CommandText = "SELECT * FROM " + _tableName + " WHERE " + _primaryKey + " = " +
                               insert.LastInsertedId + ";";
            MySqlDataReader reader = read.ExecuteReader();
            if (!reader.HasRows)
                return false;
            if (!reader.Read())
                return false;

            foreach (DatabaseColumn col in TableDef) value.ChangeValue(col.Name, reader.GetValue(col.Name));
            _rows.Add(value.GetPrimaryKey(), value);
            reader.Close();
            return true;
        }
    }
}