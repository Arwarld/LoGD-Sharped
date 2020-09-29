#region

using LoGD.Core.Game.Data;
using LoGD.Core.Game.Data.Lib;

#endregion

namespace LoGD.Core.Game
{
    public sealed class Database
    {
        private readonly string _connectionString;
        private readonly string _prefix;
        public readonly DatabaseTable<uint, Armor> ArmorTable;

        public Database(string host, string port, string user, string password, string database, string prefix)
        {
            _prefix = prefix;
            _connectionString = "Server=" + host + ";Port=" + port + ";Database=" + database + ";Uid=" +
                                user + ";Pwd=" + password + ";Convert Zero Datetime=True";
            ArmorTable = new DatabaseTable<uint, Armor>(_connectionString, _prefix + "armor", true, new[] {"armorid"},
                new string[0][],
                new DatabaseColumn("armorid", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("armorname", typeof(string), "128", false, "NULL"),
                new DatabaseColumn("value", typeof(int), "11", true, "0"),
                new DatabaseColumn("defense", typeof(int), "11", true, "1"),
                new DatabaseColumn("level", typeof(int), "11", true, "0"));
        }
    }
}
