#region

using System;
using LoGD.Core.Game.Data;
using LoGD.Core.Game.Data.Lib;

#endregion

namespace LoGD.Core.Game
{
    public sealed class Database
    {
        private readonly string _connectionString;
        private readonly string _prefix;
        public readonly DatabaseTable<uint, Accounts> AccountsTable;
        public readonly DatabaseTable<uint, Armor> ArmorTable;

        public Database(string host, string port, string user, string password, string database, string prefix)
        {
            _prefix = prefix;
            _connectionString = "Server=" + host + ";Port=" + port + ";Database=" + database + ";Uid=" +
                                user + ";Pwd=" + password + ";Convert Zero Datetime=True";
            AccountsTable = new DatabaseTable<uint, Accounts>(_connectionString, _prefix + "accounts", true,
                new[] {"acctid"},
                new[]
                {
                    new[] {"name", "name"},
                    new[] {"level", "level"},
                    new[] {"login", "login"},
                    new[] {"alive", "alive"},
                    new[] {"laston", "laston"},
                    new[] {"lasthit", "lasthit"},
                    new[] {"emailaddress", "emailaddress"},
                    new[] {"clanid", "clanid"},
                    new[] {"locked", "locked", "loggedin", "laston"},
                    new[] {"referer", "referer"},
                    new[] {"uniqueid", "uniqueid"},
                    new[] {"emailvalidation", "emailvalidation"}
                }, new DatabaseColumn("acctid", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("name", typeof(string), "60", true, "NULL"),
                new DatabaseColumn("sex", typeof(byte), "4", true, "0"),
                new DatabaseColumn("specialty", typeof(string), "20", true, "NULL"),
                new DatabaseColumn("experience", typeof(uint), "11", true, "0"),
                new DatabaseColumn("gold", typeof(uint), "11", true, "0"),
                new DatabaseColumn("weapon", typeof(string), "50", true, "Fists"),
                new DatabaseColumn("armor", typeof(string), "50", true, "T-Shirt"),
                new DatabaseColumn("seenmaster", typeof(uint), "4", true, "0"),
                new DatabaseColumn("level", typeof(uint), "11", true, "1"),
                new DatabaseColumn("defense", typeof(uint), "11", true, "1"),
                new DatabaseColumn("attack", typeof(uint), "11", true, "1"),
                new DatabaseColumn("alive", typeof(uint), "11", true, "1"),
                new DatabaseColumn("goldinbank", typeof(int), "11", true, "0"),
                new DatabaseColumn("marriedto", typeof(uint), "11", true, "0"),
                new DatabaseColumn("spirits", typeof(int), "4", true, "0"),
                new DatabaseColumn("laston", typeof(DateTime), "", true, "0000-00-00 00:00:00"),
                new DatabaseColumn("hitpoints", typeof(int), "11", true, "10"),
                new DatabaseColumn("maxhitpoints", typeof(uint), "11", true, "10"),
                new DatabaseColumn("gems", typeof(uint), "11", true, "0"),
                new DatabaseColumn("weaponvalue", typeof(uint), "11", true, "0"),
                new DatabaseColumn("armorvalue", typeof(uint), "11", true, "0"),
                new DatabaseColumn("location", typeof(string), "25", true, "Degolburg"),
                new DatabaseColumn("turns", typeof(uint), "11", true, "10"),
                new DatabaseColumn("title", typeof(string), "25", true, "NULL"),
                new DatabaseColumn("password", typeof(string), "32", true, "NULL"),
                new DatabaseColumn("badguy", typeof(string), "65535", true, "NULL"),
                new DatabaseColumn("companions", typeof(string), "65535", true, "NULL"),
                new DatabaseColumn("allowednavs", typeof(string), "16777215", true, "NULL"),
                new DatabaseColumn("loggedin", typeof(byte), "4", true, "0"),
                new DatabaseColumn("resurrections", typeof(uint), "11", true, "0"),
                new DatabaseColumn("superuser", typeof(uint), "11", true, "1"),
                new DatabaseColumn("weapondmg", typeof(int), "11", true, "0"),
                new DatabaseColumn("armordef", typeof(int), "11", true, "0"),
                new DatabaseColumn("age", typeof(uint), "11", true, "0"),
                new DatabaseColumn("charm", typeof(uint), "11", true, "0"),
                new DatabaseColumn("specialinc", typeof(string), "50", true, "NULL"),
                new DatabaseColumn("specialmisc", typeof(string), "65535", true, "NULL"),
                new DatabaseColumn("login", typeof(string), "50", true, "NULL"),
                new DatabaseColumn("lastmotd", typeof(DateTime), "", true, "0000-00-00 00:00:00"),
                new DatabaseColumn("playerfights", typeof(uint), "11", true, "3"),
                new DatabaseColumn("lasthit", typeof(DateTime), "", true, "0000-00-00 00:00:00"),
                new DatabaseColumn("seendragon", typeof(byte), "4", true, "0"),
                new DatabaseColumn("dragonkills", typeof(uint), "11", true, "0"),
                new DatabaseColumn("locked", typeof(byte), "4", true, "0"),
                new DatabaseColumn("restorepage", typeof(string), "128", false, "NULL"),
                new DatabaseColumn("hashorse", typeof(byte), "4", true, "0"),
                new DatabaseColumn("bufflist", typeof(string), "65535", true, "NULL"),
                new DatabaseColumn("gentime", typeof(double), "22,0", true, "0"),
                new DatabaseColumn("gentimecount", typeof(uint), "11", true, "0"),
                new DatabaseColumn("lastip", typeof(string), "40", true, "NULL"),
                new DatabaseColumn("uniqueid", typeof(string), "32", false, "NULL"),
                new DatabaseColumn("dragonpoints", typeof(string), "65535", true, "NULL"),
                new DatabaseColumn("boughtroomtoday", typeof(sbyte), "4", true, "0"),
                new DatabaseColumn("emailaddress", typeof(string), "128", true, "NULL"),
                new DatabaseColumn("emailvalidation", typeof(string), "32", true, "NULL"),
                new DatabaseColumn("sentnotice", typeof(int), "11", true, "0"),
                new DatabaseColumn("prefs", typeof(string), "65535", true, "NULL"),
                new DatabaseColumn("pvpflag", typeof(DateTime), "", true, "0000-00-00 00:00:00"),
                new DatabaseColumn("transferredtoday", typeof(uint), "11", true, "0"),
                new DatabaseColumn("soulpoints", typeof(uint), "11", true, "0"),
                new DatabaseColumn("gravefights", typeof(uint), "11", true, "0"),
                new DatabaseColumn("hauntedby", typeof(string), "50", true, "NULL"),
                new DatabaseColumn("deathpower", typeof(uint), "11", true, "0"),
                new DatabaseColumn("gensize", typeof(uint), "11", true, "0"),
                new DatabaseColumn("recentcomments", typeof(DateTime), "", true, "0000-00-00 00:00:00"),
                new DatabaseColumn("donation", typeof(uint), "11", true, "0"),
                new DatabaseColumn("donationspent", typeof(uint), "11", true, "0"),
                new DatabaseColumn("donationconfig", typeof(string), "65535", true, "NULL"),
                new DatabaseColumn("referer", typeof(uint), "11", true, "0"),
                new DatabaseColumn("refererawarded", typeof(sbyte), "1", true, "0"),
                new DatabaseColumn("bio", typeof(string), "255", true, "NULL"),
                new DatabaseColumn("race", typeof(string), "25", true, "0"),
                new DatabaseColumn("biotime", typeof(DateTime), "", true, "0000-00-00 00:00:00"),
                new DatabaseColumn("banoverride", typeof(sbyte), "4", false, "0"),
                new DatabaseColumn("buffbackup", typeof(string), "65535", false, "NULL"),
                new DatabaseColumn("amountouttoday", typeof(uint), "11", true, "0"),
                new DatabaseColumn("pk", typeof(byte), "3", true, "0"),
                new DatabaseColumn("dragonage", typeof(uint), "11", true, "0"),
                new DatabaseColumn("bestdragonage", typeof(uint), "11", true, "0"),
                new DatabaseColumn("ctitle", typeof(string), "25", true, "NULL"),
                new DatabaseColumn("beta", typeof(byte), "3", true, "0"),
                new DatabaseColumn("slaydragon", typeof(byte), "4", true, "0"),
                new DatabaseColumn("fedmount", typeof(byte), "4", true, "0"),
                new DatabaseColumn("regdate", typeof(DateTime), "", true, "0000-00-00 00:00:00"),
                new DatabaseColumn("clanid", typeof(uint), "11", true, "0"),
                new DatabaseColumn("clanrank", typeof(byte), "4", true, "0"),
                new DatabaseColumn("clanjoindate", typeof(DateTime), "", true, "0000-00-00 00:00:00")
            );
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
