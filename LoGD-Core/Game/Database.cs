using System.Collections.ObjectModel;
using LoGD.Core.Game.Data;
using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

namespace LoGD.Core.Game
{
    public sealed class Database
    {
        private readonly string _prefix;
        private readonly DatabaseTable<uint, Armor> _armorTable;
        public ReadOnlyDictionary<uint, Armor> ArmorTable;
        private readonly MySqlConnection _connection;

        public Database(string host, string port, string user, string password, string database, string prefix)
        {
            _prefix = prefix;
            _connection = new MySqlConnection("Server=" + host + ";Port=" + port + ";Database=" + database + ";Uid=" +
                                              user + ";Pwd=" + password + ";Convert Zero Datetime=True");
            _connection.Open();
            _armorTable = new DatabaseTable<uint, Armor>(_connection, "armor", true,
                new DatabaseColumn("armorid", typeof(uint), "11", true, true, "0"),
                new DatabaseColumn("armorname", typeof(string), "11", true, true, "0"),
                new DatabaseColumn("value", typeof(int), "11", true, true, "0"),
                new DatabaseColumn("defense", typeof(int), "11", true, true, "0"),
                new DatabaseColumn("level", typeof(int), "11", true, true, "0"));
            ArmorTable = _armorTable.Data;
            CheckDatabases();
            LoadData();
        }

        public Armor NewArmor()
        {
            return _armorTable.NewElement();
        }

        private void CheckDatabases()
        {
            _armorTable.CheckTable(_connection.CreateCommand());
        }

        private void LoadData()
        {
            _armorTable.LoadData(_connection.CreateCommand());
        }
    }
}