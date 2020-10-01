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
        public readonly DatabaseTable<uint, Accounts> Accounts;
        public readonly DatabaseTable<uint, Accounts_Output> Accounts_Output;
        public readonly DatabaseTable<uint, Armor> Armor;
        public readonly DatabaseTable<int, Bans> Bans;
        public readonly DatabaseTable<uint, Clans> Clans;
        public readonly DatabaseTable<uint, Commentary> Commentary;
        public readonly DatabaseTable<uint, Companions> Companions;
        public readonly DatabaseTable<int, Creatures> Creatures;
        public readonly DatabaseTable<uint, Debuglog> Debuglog;
        public readonly DatabaseTable<uint, Faillog> Faillog;
        public readonly DatabaseTable<uint, Gamelog> Gamelog;
        public readonly DatabaseTable<uint, Logdnet> Logdnet;
        public readonly DatabaseTable<uint, Logdnetbans> Logdnetbans;
        public readonly DatabaseTable<uint, Mail> Mail;
        public readonly DatabaseTable<uint, Masters> Masters;
        public readonly DatabaseTable<uint, Moderatedcomments> Moderatedcomments;
        public readonly DatabaseTable<uint, Motd> Motd;
        public readonly DatabaseTable<uint, Mounts> Mounts;
        public readonly DatabaseTable<int, Nastywords> Nastywords;
        public readonly DatabaseTable<object[], News> News;
        public readonly DatabaseTable<int, Paylog> Paylog;
        public readonly DatabaseTable<uint, Petitions> Petitions;
        public readonly DatabaseTable<uint, Pollresults> Pollresults;
        public readonly DatabaseTable<uint, Referers> Referers;
        public readonly DatabaseTable<string, Settings> Settings;
        public readonly DatabaseTable<uint, Taunts> Taunts;
        public readonly DatabaseTable<uint, Titles> Titles;
        public readonly DatabaseTable<uint, Weapons> Weapons;

        public Database(string host, string port, string user, string password, string database, string prefix)
        {
            _prefix = prefix;
            _connectionString = "Server=" + host + ";Port=" + port + ";Database=" + database + ";Uid=" +
                                user + ";Pwd=" + password + ";Convert Zero Datetime=True";
            Accounts = new DatabaseTable<uint, Accounts>(_connectionString, _prefix + "accounts", true,
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
            Accounts_Output = new DatabaseTable<uint, Accounts_Output>(_connectionString, _prefix + "accounts_output",
                false, new[] {"acctid"},
                new DatabaseColumn("acctid", typeof(uint), "11", true, "NULL"),
                new DatabaseColumn("output", typeof(string), "16777215", true, "NULL")
            );
            Armor = new DatabaseTable<uint, Armor>(_connectionString, _prefix + "armor", true, new[] {"armorid"},
                new DatabaseColumn("armorid", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("armorname", typeof(string), "128", false, "NULL"),
                new DatabaseColumn("value", typeof(int), "11", true, "0"),
                new DatabaseColumn("defense", typeof(int), "11", true, "1"),
                new DatabaseColumn("level", typeof(int), "11", true, "0"));

            Bans = new DatabaseTable<int, Bans>(_connectionString, _prefix + "bans",
                false, new string[0],
                new[]
                {
                    new[] {"banexpire", "banexpire"}, new[] {"uniqueid", "uniqueid"}, new[] {"ipfilter", "ipfilter"}
                },
                new DatabaseColumn("ipfilter", typeof(string), "15", true, "NULL"),
                new DatabaseColumn("uniqueid", typeof(string), "32", true, "NULL"),
                new DatabaseColumn("banexpire", typeof(DateTime), "", false, "NULL"),
                new DatabaseColumn("banreason", typeof(string), "65535", true, "NULL"),
                new DatabaseColumn("banner", typeof(string), "50", true, "NULL"),
                new DatabaseColumn("lasthit", typeof(DateTime), "", true, "0000-00-00 00:00:00")
            );
            Clans = new DatabaseTable<uint, Clans>(_connectionString, _prefix + "clans",
                false, new[] {"clanid"}, new[] {new[] {"clanname", "clanname"}, new[] {"clanshort", "clanshort"}},
                new DatabaseColumn("clanid", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("clanname", typeof(string), "255", true, "NULL"),
                new DatabaseColumn("clanshort", typeof(string), "5", true, "NULL"),
                new DatabaseColumn("clanmotd", typeof(string), "65535", false, "NULL"),
                new DatabaseColumn("clandesc", typeof(string), "65535", false, "NULL"),
                new DatabaseColumn("motdauthor", typeof(uint), "11", true, "0"),
                new DatabaseColumn("descauthor", typeof(uint), "11", true, "0"),
                new DatabaseColumn("customsay", typeof(string), "15", true, "NULL")
            );
            Commentary = new DatabaseTable<uint, Commentary>(_connectionString, _prefix + "commentary",
                false, new[] {"commentid"}, new[] {new[] {"section", "section"}, new[] {"postdate", "postdate"}},
                new DatabaseColumn("commentid", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("section", typeof(string), "20", false, "NULL"),
                new DatabaseColumn("author", typeof(uint), "11", true, "0"),
                new DatabaseColumn("comment", typeof(string), "200", true, "NULL"),
                new DatabaseColumn("postdate", typeof(DateTime), "", true, "0000-00-00 00:00:00")
            );
            Companions = new DatabaseTable<uint, Companions>(_connectionString, _prefix + "companions",
                false, new[] {"companionid"},
                new DatabaseColumn("companionid", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("name", typeof(string), "255", true, "NULL"),
                new DatabaseColumn("category", typeof(string), "255", true, "NULL"),
                new DatabaseColumn("description", typeof(string), "65535", true, "NULL"),
                new DatabaseColumn("attack", typeof(uint), "6", true, "1"),
                new DatabaseColumn("attackperlevel", typeof(uint), "6", true, "0"),
                new DatabaseColumn("defense", typeof(uint), "6", true, "1"),
                new DatabaseColumn("defenseperlevel", typeof(uint), "6", true, "0"),
                new DatabaseColumn("maxhitpoints", typeof(uint), "6", true, "10"),
                new DatabaseColumn("maxhitpointsperlevel", typeof(uint), "6", true, "10"),
                new DatabaseColumn("abilities", typeof(string), "65535", true, "NULL"),
                new DatabaseColumn("cannotdie", typeof(sbyte), "4", true, "0"),
                new DatabaseColumn("cannotbehealed", typeof(sbyte), "4", true, "1"),
                new DatabaseColumn("companionlocation", typeof(string), "25", true, "all"),
                new DatabaseColumn("companionactive", typeof(sbyte), "25", true, "1"),
                new DatabaseColumn("companioncostdks", typeof(sbyte), "4", true, "0"),
                new DatabaseColumn("companioncostgems", typeof(int), "6", true, "0"),
                new DatabaseColumn("companioncostgold", typeof(int), "10", true, "0"),
                new DatabaseColumn("jointext", typeof(string), "65535", true, "NULL"),
                new DatabaseColumn("dyingtext", typeof(string), "255", true, "NULL"),
                new DatabaseColumn("allowinshades", typeof(sbyte), "4", true, "0"),
                new DatabaseColumn("allowinpvp", typeof(sbyte), "4", true, "0"),
                new DatabaseColumn("allowintrain", typeof(sbyte), "4", true, "0")
            );
            Creatures = new DatabaseTable<int, Creatures>(_connectionString, _prefix + "creatures",
                false, new[] {"creatureid"}, new[] {new[] {"creaturelevel", "creaturelevel"}},
                new DatabaseColumn("creatureid", typeof(int), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("creaturename", typeof(string), "50", false, "NULL"),
                new DatabaseColumn("creaturelevel", typeof(int), "11", false, "NULL"),
                new DatabaseColumn("creatureweapon", typeof(string), "50", false, "NULL"),
                new DatabaseColumn("creaturelose", typeof(string), "120", false, "NULL"),
                new DatabaseColumn("creaturewin", typeof(string), "120", false, "NULL"),
                new DatabaseColumn("creaturegold", typeof(int), "11", false, "NULL"),
                new DatabaseColumn("creatureexp", typeof(int), "11", false, "NULL"),
                new DatabaseColumn("creaturehealth", typeof(int), "11", false, "NULL"),
                new DatabaseColumn("creatureattack", typeof(int), "11", false, "NULL"),
                new DatabaseColumn("creaturedefense", typeof(int), "11", false, "NULL"),
                new DatabaseColumn("creatureaiscript", typeof(string), "65535", false, "NULL"),
                new DatabaseColumn("createdby", typeof(string), "50", false, "NULL"),
                new DatabaseColumn("forest", typeof(sbyte), "4", true, "0"),
                new DatabaseColumn("graveyard", typeof(sbyte), "4", true, "0"),
                new DatabaseColumn("oldcreatureexp", typeof(int), "11", false, "NULL")
            );


            Debuglog = new DatabaseTable<uint, Debuglog>(_connectionString, _prefix + "debuglog",
                false, new[] {"id"}, new[] {new[] {"date", "date"}, new[] {"field", "actor", "field"}},
                new DatabaseColumn("id", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("date", typeof(DateTime), "", true, "0000-00-00 00:00:00"),
                new DatabaseColumn("actor", typeof(uint), "11", false, "NULL"),
                new DatabaseColumn("target", typeof(uint), "11", false, "NULL"),
                new DatabaseColumn("message", typeof(string), "65535", true, "NULL"),
                new DatabaseColumn("field", typeof(string), "20", true, "NULL"),
                new DatabaseColumn("value", typeof(float), "9,2", true, "0.00")
            );
            Faillog = new DatabaseTable<uint, Faillog>(_connectionString, _prefix + "faillog",
                false, new[] {"eventid"},
                new[] {new[] {"date", "date"}, new[] {"acctid", "acctid"}, new[] {"ip", "ip"}},
                new DatabaseColumn("eventid", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("date", typeof(DateTime), "", true, "0000-00-00 00:00:00"),
                new DatabaseColumn("post", typeof(string), "255", true, "NULL"),
                new DatabaseColumn("ip", typeof(string), "40", true, "NULL"),
                new DatabaseColumn("acctid", typeof(uint), "11", false, "NULL"),
                new DatabaseColumn("id", typeof(string), "32", true, "NULL")
            );
            Gamelog = new DatabaseTable<uint, Gamelog>(_connectionString, _prefix + "gamelog",
                false, new[] {"logid"}, new[] {new[] {"date", "category", "date"}},
                new DatabaseColumn("logid", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("message", typeof(string), "65535", true, "NULL"),
                new DatabaseColumn("category", typeof(string), "50", true, "NULL"),
                new DatabaseColumn("filed", typeof(sbyte), "4", true, "0"),
                new DatabaseColumn("date", typeof(DateTime), "", true, "0000-00-00 00:00:00"),
                new DatabaseColumn("who", typeof(uint), "11", true, "0")
            );
            Logdnet = new DatabaseTable<uint, Logdnet>(_connectionString, _prefix + "logdnet",
                false, new[] {"serverid"},
                new DatabaseColumn("serverid", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("address", typeof(string), "255", true, "NULL"),
                new DatabaseColumn("description", typeof(string), "255", true, "NULL"),
                new DatabaseColumn("priority", typeof(double), "22", true, "100"),
                new DatabaseColumn("lastupdate", typeof(DateTime), "", true, "0000-00-00 00:00:00"),
                new DatabaseColumn("version", typeof(string), "255", true, "Unknown"),
                new DatabaseColumn("admin", typeof(string), "255", true, "unknown"),
                new DatabaseColumn("lastping", typeof(DateTime), "", true, "0000-00-00 00:00:00"),
                new DatabaseColumn("recentips", typeof(string), "255", true, "NULL"),
                new DatabaseColumn("count", typeof(uint), "11", true, "0"),
                new DatabaseColumn("lang", typeof(string), "20", true, "NULL")
            );
            Logdnetbans = new DatabaseTable<uint, Logdnetbans>(_connectionString, _prefix + "logdnetbans",
                false, new[] {"banid"},
                new DatabaseColumn("banid", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("bantype", typeof(string), "20", true, "NULL"),
                new DatabaseColumn("banvalue", typeof(string), "255", true, "NULL")
            );
            Mail = new DatabaseTable<uint, Mail>(_connectionString, _prefix + "mail",
                false, new[] {"messageid"}, new[] {new[] {"msgto", "msgto"}, new[] {"seen", "seen"}},
                new DatabaseColumn("messageid", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("msgfrom", typeof(string), "255", true, "0"),
                new DatabaseColumn("msgto", typeof(uint), "11", true, "0"),
                new DatabaseColumn("subject", typeof(string), "255", true, "NULL"),
                new DatabaseColumn("body", typeof(string), "65535", true, "NULL"),
                new DatabaseColumn("sent", typeof(DateTime), "", true, "0000-00-00 00:00:00"),
                new DatabaseColumn("seen", typeof(sbyte), "1", true, "0"),
                new DatabaseColumn("originator", typeof(uint), "11", true, "0")
            );
            Masters = new DatabaseTable<uint, Masters>(_connectionString, _prefix + "masters",
                false, new[] {"creatureid"},
                new DatabaseColumn("creatureid", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("creaturename", typeof(string), "50", false, "NULL"),
                new DatabaseColumn("creaturelevel", typeof(int), "11", false, "NULL"),
                new DatabaseColumn("creatureweapon", typeof(string), "50", false, "NULL"),
                new DatabaseColumn("creaturelose", typeof(string), "120", false, "NULL"),
                new DatabaseColumn("creaturewin", typeof(string), "120", false, "NULL"),
                new DatabaseColumn("creaturegold", typeof(int), "11", false, "NULL"),
                new DatabaseColumn("creatureexp", typeof(int), "11", false, "NULL"),
                new DatabaseColumn("creaturehealth", typeof(int), "11", false, "NULL"),
                new DatabaseColumn("creatureattack", typeof(int), "11", false, "NULL"),
                new DatabaseColumn("creaturedefense", typeof(int), "11", false, "NULL")
            );
            Moderatedcomments = new DatabaseTable<uint, Moderatedcomments>(_connectionString,
                _prefix + "moderatedcomments",
                false, new[] {"modid"},
                new DatabaseColumn("modid", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("comment", typeof(string), "65535", false, "NULL"),
                new DatabaseColumn("moderator", typeof(uint), "11", true, "0"),
                new DatabaseColumn("moddate", typeof(DateTime), "", true, "0000-00-00 00:00:00")
            );
            Motd = new DatabaseTable<uint, Motd>(_connectionString, _prefix + "motd",
                false, new[] {"motditem"},
                new DatabaseColumn("motditem", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("motdtitle", typeof(string), "200", false, "NULL"),
                new DatabaseColumn("motdbody", typeof(string), "65535", false, "NULL"),
                new DatabaseColumn("motddate", typeof(DateTime), "", false, "NULL"),
                new DatabaseColumn("motdtype", typeof(byte), "4", true, "0"),
                new DatabaseColumn("motdauthor", typeof(uint), "11", true, "0")
            );
            Mounts = new DatabaseTable<uint, Mounts>(_connectionString, _prefix + "mounts",
                false, new[] {"mountid"}, new[] {new[] {"mountid", "mountid"}},
                new DatabaseColumn("mountid", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("mountname", typeof(string), "50", true, "NULL"),
                new DatabaseColumn("mountdesc", typeof(string), "65535", false, "NULL"),
                new DatabaseColumn("mountcategory", typeof(string), "50", true, "NULL"),
                new DatabaseColumn("mountbuff", typeof(string), "65535", false, "NULL"),
                new DatabaseColumn("mountcostgems", typeof(uint), "11", true, "0"),
                new DatabaseColumn("mountcostgold", typeof(uint), "11", true, "0"),
                new DatabaseColumn("mountactive", typeof(uint), "11", true, "1"),
                new DatabaseColumn("mountforestfights", typeof(int), "11", true, "0"),
                new DatabaseColumn("newday", typeof(string), "65535", true, "NULL"),
                new DatabaseColumn("recharge", typeof(string), "65535", true, "NULL"),
                new DatabaseColumn("partrecharge", typeof(string), "65535", true, "NULL"),
                new DatabaseColumn("mountfeedcost", typeof(uint), "11", true, "20"),
                new DatabaseColumn("mountlocation", typeof(string), "25", true, "all"),
                new DatabaseColumn("mountdkcost", typeof(uint), "11", true, "0")
            );
            Nastywords = new DatabaseTable<int, Nastywords>(_connectionString, _prefix + "nastywords",
                false, new string[0],
                new DatabaseColumn("words", typeof(string), "65535", false, "NULL"),
                new DatabaseColumn("type", typeof(string), "10", false, "NULL")
            );
            News = new DatabaseTable<object[], News>(_connectionString, _prefix + "news",
                false, new[] {"newsid", "newsdate"},
                new[] {new[] {"accountid", "accountid"}, new[] {"newsdate", "newsdate"}},
                new DatabaseColumn("newsid", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("newstext", typeof(string), "65535", true, "NULL"),
                new DatabaseColumn("newsdate", typeof(DateTime), "", true, "0000-00-00"),
                new DatabaseColumn("accountid", typeof(uint), "11", true, "0"),
                new DatabaseColumn("arguments", typeof(string), "65535", true, "NULL"),
                new DatabaseColumn("tlschema", typeof(string), "255", true, "news")
            );
            Paylog = new DatabaseTable<int, Paylog>(_connectionString, _prefix + "paylog",
                false, new[] {"payid"}, new[] {new[] {"txnid", "txnid"}},
                new DatabaseColumn("payid", typeof(int), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("info", typeof(string), "65535", true, "NULL"),
                new DatabaseColumn("response", typeof(string), "65535", true, "NULL"),
                new DatabaseColumn("txnid", typeof(string), "32", true, "NULL"),
                new DatabaseColumn("amount", typeof(float), "9,2", true, "0.00"),
                new DatabaseColumn("name", typeof(string), "50", true, "NULL"),
                new DatabaseColumn("acctid", typeof(uint), "11", true, "0"),
                new DatabaseColumn("processed", typeof(byte), "4", true, "0"),
                new DatabaseColumn("filed", typeof(byte), "4", true, "0"),
                new DatabaseColumn("txfee", typeof(float), "9,2", true, "0.00"),
                new DatabaseColumn("processdate", typeof(DateTime), "", true, "0000-00-00 00:00:00")
            );
            Petitions = new DatabaseTable<uint, Petitions>(_connectionString, _prefix + "petitions",
                false, new[] {"petitionid"},
                new DatabaseColumn("petitionid", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("author", typeof(uint), "11", true, "0"),
                new DatabaseColumn("date", typeof(DateTime), "", true, "0000-00-00 00:00:00"),
                new DatabaseColumn("status", typeof(uint), "11", true, "0"),
                new DatabaseColumn("body", typeof(string), "65535", false, "NULL"),
                new DatabaseColumn("pageinfo", typeof(string), "65535", false, "NULL"),
                new DatabaseColumn("closedate", typeof(DateTime), "", true, "0000-00-00 00:00:00"),
                new DatabaseColumn("closeuserid", typeof(uint), "11", true, "0"),
                new DatabaseColumn("ip", typeof(string), "40", true, "NULL"),
                new DatabaseColumn("id", typeof(string), "32", true, "NULL")
            );
            Pollresults = new DatabaseTable<uint, Pollresults>(_connectionString, _prefix + "pollresults",
                false, new[] {"resultid"},
                new DatabaseColumn("resultid", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("choice", typeof(uint), "11", true, "0"),
                new DatabaseColumn("account", typeof(uint), "11", true, "0"),
                new DatabaseColumn("motditem", typeof(uint), "11", true, "0")
            );
            Referers = new DatabaseTable<uint, Referers>(_connectionString, _prefix + "referers",
                false, new[] {"refererid"}, new[] {new[] {"uri", "uri"}, new[] {"site", "site"}},
                new DatabaseColumn("refererid", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("uri", typeof(string), "65535", false, "NULL"),
                new DatabaseColumn("count", typeof(int), "11", false, "NULL"),
                new DatabaseColumn("last", typeof(DateTime), "", false, "NULL"),
                new DatabaseColumn("site", typeof(string), "50", true, "NULL"),
                new DatabaseColumn("dest", typeof(string), "255", false, "NULL"),
                new DatabaseColumn("ip", typeof(string), "40", false, "NULL")
            );
            Settings = new DatabaseTable<string, Settings>(_connectionString, _prefix + "settings",
                false, new[] {"setting"},
                new DatabaseColumn("setting", typeof(string), "20", true, "NULL"),
                new DatabaseColumn("value", typeof(string), "255", true, "NULL")
            );
            Taunts = new DatabaseTable<uint, Taunts>(_connectionString, _prefix + "taunts",
                false, new[] {"tauntid"},
                new DatabaseColumn("tauntid", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("taunt", typeof(string), "65535", false, "NULL"),
                new DatabaseColumn("editor", typeof(string), "50", false, "NULL")
            );
            Titles = new DatabaseTable<uint, Titles>(_connectionString, _prefix + "titles",
                false, new[] {"titleid"}, new[] {new[] {"dk", "dk"}},
                new DatabaseColumn("titleid", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("dk", typeof(int), "11", true, "0"),
                new DatabaseColumn("ref", typeof(string), "100", true, "NULL"),
                new DatabaseColumn("male", typeof(string), "25", true, "NULL"),
                new DatabaseColumn("female", typeof(string), "25", true, "NULL")
            );
            Weapons = new DatabaseTable<uint, Weapons>(_connectionString, _prefix + "weapons",
                false, new[] {"weaponid"},
                new DatabaseColumn("weaponid", typeof(uint), "11", true, "NULL", "auto_increment"),
                new DatabaseColumn("weaponname", typeof(string), "128", false, "NULL"),
                new DatabaseColumn("value", typeof(int), "11", true, "0"),
                new DatabaseColumn("damage", typeof(int), "11", true, "1"),
                new DatabaseColumn("level", typeof(int), "11", true, "0")
            );
        }
    }
}
