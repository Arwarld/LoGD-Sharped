#region

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data.Lib
{
    public sealed class DatabaseTable<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
        where TValue : DatabaseRow<TKey, TValue>
    {
        private readonly bool _autoIncrement;
        private readonly string _connectionString;
        private readonly int _keyCount;
        private readonly string[][] _keys;
        private readonly Dictionary<TKey, TValue> _rows;
        private readonly string _tableName;
        internal readonly string[] PrimaryKeyColums;
        internal readonly DatabaseColumn[] TableDef;

        internal DatabaseTable(string connectionString, string tableName, bool autoIncrement, string[] primaryKeyColums,
            string[][] keys, params DatabaseColumn[] tableDef)
        {
            _rows = new Dictionary<TKey, TValue>();
            _connectionString = connectionString;
            _tableName = tableName;
            _autoIncrement = autoIncrement;
            TableDef = tableDef;
            _keys = keys;
            PrimaryKeyColums = primaryKeyColums;
            _keyCount = primaryKeyColums.Length;
            foreach (string[] keycols in keys)
                _keyCount += keycols.Length - 1;

            if (CheckTable())
                LoadData();
            else
                throw new NotImplementedException("Table not in correct shape!");
        }

        public DatabaseRow<TKey, TValue> this[TKey key] => _rows[key];

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return _rows.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _rows.GetEnumerator();
        }

        private string TypeToSqlString(Type type, string length)
        {
            switch (type.Name)
            {
                case "String":
                    if (int.Parse(length) <= 255)
                        return "varchar(" + length + ")";

                    return int.Parse(length) <= 65535 ? "text" : "mediumtext";

                case "UInt32":
                    return "int(" + length + ") unsigned";
                case "Int32":
                    return "int(" + length + ")";
                case "Byte":
                    return "tinyint(" + length + ") unsigned";
                case "SByte":
                    return "tinyint(" + length + ")";
                case "DateTime":
                    return "datetime";
                case "Double":
                    return "double unsigned";
            }

            return "";
        }

        private bool CheckTable()
        {
            using MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            using MySqlCommand describeCommand = connection.CreateCommand();
            describeCommand.CommandText = "DESCRIBE " + _tableName + ";";
            MySqlDataReader describeReader = describeCommand.ExecuteReader();
            if (describeReader.HasRows)
                for (int pos = 0; describeReader.Read(); pos++)
                {
                    if (describeReader.GetString("Field") != TableDef[pos].Name)
                        return false;
                    Console.WriteLine(describeReader.GetString("Type"));
                    if (describeReader.GetString("Type") !=
                        TypeToSqlString(TableDef[pos].DataType, TableDef[pos].Length))
                        return false;
                    if (describeReader.GetString("Null") != (TableDef[pos].NotNull ? "NO" : "YES"))
                        return false;

                    if (describeReader.IsDBNull(describeReader.GetOrdinal("Default")))
                    {
                        if (TableDef[pos].DefaultValue != "NULL")
                            return false;
                    }
                    else if (describeReader.GetString("Default") != TableDef[pos].DefaultValue)
                    {
                        return false;
                    }

                    if (describeReader.GetString("Extra") != TableDef[pos].Extra)
                        return false;
                }

            describeReader.Close();
            using MySqlCommand indexesCommand = connection.CreateCommand();
            indexesCommand.CommandText = "SHOW INDEXES FROM " + _tableName + ";";
            MySqlDataReader indexesReader = indexesCommand.ExecuteReader();
            if (!indexesReader.HasRows && PrimaryKeyColums.Length + _keys.Length == 0) return true;

            int key = 0;
            int keypos = 1;
            int keyschecked = 0;
            for (; indexesReader.Read(); keyschecked++)
                if (keyschecked < PrimaryKeyColums.Length)
                {
                    if (indexesReader.GetString("Key_name") != "PRIMARY" ||
                        indexesReader.GetString("Column_name") != PrimaryKeyColums[keyschecked])
                        return false;
                }
                else
                {
                    if (key >= _keys.Length || keypos >= _keys[key].Length ||
                        indexesReader.GetString("Key_name") != _keys[key][0] ||
                        indexesReader.GetString("Column_name") != _keys[key][keypos++])
                        return false;

                    if (_keys[key].Length != keypos) continue;

                    key++;
                    keypos = 1;
                }

            return keyschecked == _keyCount;
        }

        public TValue NewElement()
        {
            return (TValue) Activator.CreateInstance(typeof(TValue), this);
        }

        private void LoadData()
        {
            using MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            using MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM " + _tableName + ";";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                {
                    TValue data = (TValue) Activator.CreateInstance(typeof(TValue), this, reader);
                    if (data != null) _rows.Add(data.PrimaryKey(), data);
                }

            reader.Close();
        }

        internal bool UpdateData(TValue value)
        {
            using MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            using MySqlCommand update = connection.CreateCommand();
            update.CommandText = "UPDATE " + _tableName + " SET ";
            foreach (KeyValuePair<string, object> values in value.NewValues)
                update.CommandText += values.Key + "='" + values.Value + "',";
            update.CommandText = update.CommandText.TrimEnd(',');
            update.CommandText += " WHERE ";
            if (PrimaryKeyColums.Length > 1)
            {
                for (int i = 0; i < PrimaryKeyColums.Length; i++)
                    update.CommandText += PrimaryKeyColums[i] + " = " + value.PrimaryKey(i) + ",";
                update.CommandText = update.CommandText.TrimEnd(',') + ";";
            }
            else if (PrimaryKeyColums.Length == 1)
            {
                update.CommandText += PrimaryKeyColums[0] + " = " + value.PrimaryKey() + ";";
            }
            else
            {
                throw new NotImplementedException();
            }

            return update.ExecuteNonQuery() == 1;
        }

        internal bool InsertData(TValue value)
        {
            if (!_autoIncrement && _rows.ContainsKey(value.PrimaryKey()))
                return false;

            using MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            using MySqlCommand insert = connection.CreateCommand();

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

            using MySqlCommand read = connection.CreateCommand();
            read.CommandText = "SELECT * FROM " + _tableName + " WHERE ";
            if (_autoIncrement)
            {
                read.CommandText += PrimaryKeyColums[0] + " = " + insert.LastInsertedId + ";";
            }
            else
            {
                foreach (string keyColum in PrimaryKeyColums.Aggregate(true,
                                                (current, keyname) =>
                                                    current & value.NewValues.ContainsKey(keyname)) &&
                                            PrimaryKeyColums.Length >= 1
                    ? PrimaryKeyColums
                    : value.NewValues.Keys.ToArray())
                    read.CommandText += keyColum + " = " + value.NewValues[keyColum] + ",";

                read.CommandText = read.CommandText.TrimEnd(',') + ";";
            }

            MySqlDataReader reader = read.ExecuteReader();
            if (!reader.HasRows)
                return false;
            if (!reader.Read())
                return false;

            foreach (DatabaseColumn col in TableDef) value.ChangeValue(col.Name, reader.GetValue(col.Name));
            _rows.Add(value.PrimaryKey(), value);
            reader.Close();
            return true;
        }
    }
}
