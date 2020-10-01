#region

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data.Lib
{
    public abstract class DatabaseRow<TKey, TValue> where TValue : DatabaseRow<TKey, TValue>
    {
        private readonly List<string> _changedValues;
        private readonly Dictionary<string, object> _newValues;
        private readonly TKey _overridePrimaryKey;
        private readonly DatabaseTable<TKey, TValue> _parent;
        internal readonly ReadOnlyDictionary<string, object> NewValues;
        protected readonly Dictionary<string, object> Values;

        protected DatabaseRow(DatabaseTable<TKey, TValue> parent)
        {
            Values = new Dictionary<string, object>();
            _changedValues = new List<string>();
            _newValues = new Dictionary<string, object>();
            NewValues = new ReadOnlyDictionary<string, object>(_newValues);
            _parent = parent;
        }

        protected DatabaseRow(DatabaseTable<TKey, TValue> parent, TKey overridePrimaryKey)
            : this(parent)
        {
            _overridePrimaryKey = overridePrimaryKey;
        }

        protected DatabaseRow(DatabaseTable<TKey, TValue> parent, MySqlDataReader reader)
            : this(parent)
        {
            ReadData(reader);
        }

        protected DatabaseRow(DatabaseTable<TKey, TValue> parent, MySqlDataReader reader, TKey overridePrimaryKey)
            : this(parent, reader)
        {
            _overridePrimaryKey = overridePrimaryKey;
        }

        public object this[string name] => Values[name];

        public string[] ChangedValues => _changedValues.ToArray();

        private void ReadData(DbDataReader reader)
        {
            foreach (DatabaseColumn col in _parent.TableDef)
                if (Values.ContainsKey(col.Name))
                    Values[col.Name] = reader.GetValue(col.Name);
                else
                    Values.Add(col.Name, reader.GetValue(col.Name));
        }

        internal object PrimaryKey(int col)
        {
            return Values[_parent.PrimaryKeyColums[col]];
        }

        internal TKey PrimaryKey()
        {
            switch (_parent.PrimaryKeyColums.Length)
            {
                case 0:
                    return _overridePrimaryKey;
                case 1:
                    return (TKey) PrimaryKey(0);
            }

            object[] primarykey = new object[_parent.PrimaryKeyColums.Length];
            for (int i = 0; i < primarykey.Length; i++)
                primarykey[i] = PrimaryKey(i);
            return (TKey) (object) primarykey;
        }

        internal void ChangeValue(string name, object value)
        {
            if (!_newValues.ContainsKey(name))
                _newValues.Add(name, value);
            else
                _newValues[name] = value;
            if (!_changedValues.Contains(name))
                _changedValues.Add(name);
        }

        public bool Update()
        {
            if (!_parent.UpdateData((TValue) this))
                return false;

            UpdateLocal();
            return true;
        }

        public bool Insert()
        {
            if (!_parent.InsertData((TValue) this))
                return false;

            UpdateLocal();
            return true;
        }

        private void UpdateLocal()
        {
            foreach (string value in _changedValues)
                if (Values.ContainsKey(value))
                    Values[value] = _newValues[value];
                else
                    Values.Add(value, _newValues[value]);
            _newValues.Clear();
            _changedValues.Clear();
        }
    }
}
