#region

using System;
using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Accounts : DatabaseRow<uint, Accounts>
    {
        public Accounts(DatabaseTable<uint, Accounts> parent) : base(parent)
        {
        }

        public Accounts(DatabaseTable<uint, Accounts> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public uint AcctId
        {
            get => (uint) Values["acctid"];
            set => ChangeValue("acctid", value);
        }

        public string Name
        {
            get => (string) Values["name"];
            set => ChangeValue("name", value);
        }

        public byte Sex
        {
            get => (byte) Values["sex"];
            set => ChangeValue("sex", value);
        }

        public string Specialty
        {
            get => (string) Values["specialty"];
            set => ChangeValue("specialty", value);
        }

        public uint Experience
        {
            get => (uint) Values["experience"];
            set => ChangeValue("experience", value);
        }

        public uint Gold
        {
            get => (uint) Values["gold"];
            set => ChangeValue("gold", value);
        }

        public string Weapon
        {
            get => (string) Values["weapon"];
            set => ChangeValue("weapon", value);
        }

        public string Armor
        {
            get => (string) Values["armor"];
            set => ChangeValue("armor", value);
        }

        public uint SeenMaster
        {
            get => (uint) Values["seenmaster"];
            set => ChangeValue("seenmaster", value);
        }

        public uint Level
        {
            get => (uint) Values["level"];
            set => ChangeValue("level", value);
        }

        public uint Defense
        {
            get => (uint) Values["defense"];
            set => ChangeValue("defense", value);
        }

        public uint Attack
        {
            get => (uint) Values["attack"];
            set => ChangeValue("attack", value);
        }

        public uint Alive
        {
            get => (uint) Values["alive"];
            set => ChangeValue("alive", value);
        }

        public int GoldInBank
        {
            get => (int) Values["goldinbank"];
            set => ChangeValue("goldinbank", value);
        }

        public uint MarriedTo
        {
            get => (uint) Values["marriedto"];
            set => ChangeValue("marriedto", value);
        }

        public int Spirits
        {
            get => (int) Values["spirits"];
            set => ChangeValue("spirits", value);
        }

        public DateTime LastOn
        {
            get => (DateTime) Values["laston"];
            set => ChangeValue("laston", value);
        }

        public int HitPoints
        {
            get => (int) Values["hitpoints"];
            set => ChangeValue("hitpoints", value);
        }

        public uint MaxHitPoints
        {
            get => (uint) Values["maxhitpoints"];
            set => ChangeValue("maxhitpoints", value);
        }

        public uint Gems
        {
            get => (uint) Values["gems"];
            set => ChangeValue("gems", value);
        }

        public uint WeaponValue
        {
            get => (uint) Values["weaponvalue"];
            set => ChangeValue("weaponvalue", value);
        }

        public uint ArmorValue
        {
            get => (uint) Values["armorvalue"];
            set => ChangeValue("armorvalue", value);
        }

        public string Location
        {
            get => (string) Values["location"];
            set => ChangeValue("location", value);
        }

        public uint Turns
        {
            get => (uint) Values["turns"];
            set => ChangeValue("turns", value);
        }

        public string Title
        {
            get => (string) Values["title"];
            set => ChangeValue("title", value);
        }

        public string Password
        {
            get => (string) Values["password"];
            set => ChangeValue("password", value);
        }

        public string Badguy
        {
            get => (string) Values["badguy"];
            set => ChangeValue("badguy", value);
        }

        public string Companions
        {
            get => (string) Values["companions"];
            set => ChangeValue("companions", value);
        }

        public string AllowedNavs
        {
            get => (string) Values["allowednavs"];
            set => ChangeValue("allowednavs", value);
        }

        public byte LoggedIn
        {
            get => (byte) Values["loggedin"];
            set => ChangeValue("loggedin", value);
        }

        public uint Resurrections
        {
            get => (uint) Values["resurrections"];
            set => ChangeValue("resurrections", value);
        }

        public uint SuperUser
        {
            get => (uint) Values["superuser"];
            set => ChangeValue("superuser", value);
        }

        public int WeaponDmg
        {
            get => (int) Values["weapondmg"];
            set => ChangeValue("weapondmg", value);
        }

        public int ArmorDef
        {
            get => (int) Values["armordef"];
            set => ChangeValue("armordef", value);
        }

        public uint Age
        {
            get => (uint) Values["age"];
            set => ChangeValue("age", value);
        }

        public uint Charm
        {
            get => (uint) Values["charm"];
            set => ChangeValue("charm", value);
        }

        public string SpecialInc
        {
            get => (string) Values["specialinc"];
            set => ChangeValue("specialinc", value);
        }

        public string SpecialMisc
        {
            get => (string) Values["specialmisc"];
            set => ChangeValue("specialmisc", value);
        }

        public string Login
        {
            get => (string) Values["login"];
            set => ChangeValue("login", value);
        }

        public DateTime LastMoTD
        {
            get => (DateTime) Values["lastmotd"];
            set => ChangeValue("lastmotd", value);
        }

        public uint PlayerFights
        {
            get => (uint) Values["playerfights"];
            set => ChangeValue("playerfights", value);
        }

        public DateTime LastHit
        {
            get => (DateTime) Values["lasthit"];
            set => ChangeValue("lasthit", value);
        }

        public byte SeenDragon
        {
            get => (byte) Values["seendragon"];
            set => ChangeValue("seendragon", value);
        }

        public uint DragonKills
        {
            get => (uint) Values["dragonkills"];
            set => ChangeValue("dragonkills", value);
        }

        public byte Locked
        {
            get => (byte) Values["locked"];
            set => ChangeValue("locked", value);
        }

        public string RestorePage
        {
            get => (string) Values["restorepage"];
            set => ChangeValue("restorepage", value);
        }

        public byte HasHorse
        {
            get => (byte) Values["hashorse"];
            set => ChangeValue("hashorse", value);
        }

        public string BuffList
        {
            get => (string) Values["bufflist"];
            set => ChangeValue("bufflist", value);
        }

        public double GenTime
        {
            get => (double) Values["gentime"];
            set => ChangeValue("gentime", value);
        }

        public uint GenTimeCount
        {
            get => (uint) Values["gentimecount"];
            set => ChangeValue("gentimecount", value);
        }

        public string LastIP
        {
            get => (string) Values["lastip"];
            set => ChangeValue("lastip", value);
        }

        public string UniqueId
        {
            get => (string) Values["uniqueid"];
            set => ChangeValue("uniqueid", value);
        }

        public string DragonPoints
        {
            get => (string) Values["dragonpoints"];
            set => ChangeValue("dragonpoints", value);
        }

        public byte BoughtRoomToday
        {
            get => (byte) Values["boughtroomtoday"];
            set => ChangeValue("boughtroomtoday", value);
        }

        public string EmailAddress
        {
            get => (string) Values["emailaddress"];
            set => ChangeValue("emailaddress", value);
        }

        public string EmailValidation
        {
            get => (string) Values["emailvalidation"];
            set => ChangeValue("emailvalidation", value);
        }

        public int SentNotice
        {
            get => (int) Values["sentnotice"];
            set => ChangeValue("sentnotice", value);
        }

        public string Prefs
        {
            get => (string) Values["prefs"];
            set => ChangeValue("prefs", value);
        }

        public DateTime PVPFlag
        {
            get => (DateTime) Values["pvpflag"];
            set => ChangeValue("pvpflag", value);
        }

        public uint TransferredToday
        {
            get => (uint) Values["transferredtoday"];
            set => ChangeValue("transferredtoday", value);
        }

        public uint SoulPoints
        {
            get => (uint) Values["soulpoints"];
            set => ChangeValue("soulpoints", value);
        }

        public uint GraveFights
        {
            get => (uint) Values["gravefights"];
            set => ChangeValue("gravefights", value);
        }

        public string HauntedBy
        {
            get => (string) Values["hauntedby"];
            set => ChangeValue("hauntedby", value);
        }

        public uint DeathPower
        {
            get => (uint) Values["deathpower"];
            set => ChangeValue("deathpower", value);
        }

        public uint GenSize
        {
            get => (uint) Values["gensize"];
            set => ChangeValue("gensize", value);
        }

        public DateTime RecentComments
        {
            get => (DateTime) Values["recentcomments"];
            set => ChangeValue("recentcomments", value);
        }

        public uint Donation
        {
            get => (uint) Values["donation"];
            set => ChangeValue("donation", value);
        }

        public uint DonationSpent
        {
            get => (uint) Values["donationspent"];
            set => ChangeValue("donationspent", value);
        }

        public string DonationConfig
        {
            get => (string) Values["donationconfig"];
            set => ChangeValue("donationconfig", value);
        }

        public uint Referer
        {
            get => (uint) Values["referer"];
            set => ChangeValue("referer", value);
        }

        public byte RefererAwarded
        {
            get => (byte) Values["refererawarded"];
            set => ChangeValue("refererawarded", value);
        }

        public string Bio
        {
            get => (string) Values["bio"];
            set => ChangeValue("bio", value);
        }

        public string Race
        {
            get => (string) Values["race"];
            set => ChangeValue("race", value);
        }

        public DateTime BioTime
        {
            get => (DateTime) Values["biotime"];
            set => ChangeValue("biotime", value);
        }

        public byte BanOverride
        {
            get => (byte) Values["banoverride"];
            set => ChangeValue("banoverride", value);
        }

        public string BuffBackup
        {
            get => (string) Values["buffbackup"];
            set => ChangeValue("buffbackup", value);
        }

        public uint AmountOutToday
        {
            get => (uint) Values["amountouttoday"];
            set => ChangeValue("amountouttoday", value);
        }

        public byte PK
        {
            get => (byte) Values["pk"];
            set => ChangeValue("pk", value);
        }

        public uint DragonAge
        {
            get => (uint) Values["dragonage"];
            set => ChangeValue("dragonage", value);
        }

        public uint BestDragonAge
        {
            get => (uint) Values["bestdragonage"];
            set => ChangeValue("bestdragonage", value);
        }

        public string CTitle
        {
            get => (string) Values["ctitle"];
            set => ChangeValue("ctitle", value);
        }

        public byte Beta
        {
            get => (byte) Values["beta"];
            set => ChangeValue("beta", value);
        }

        public byte SlayDragon
        {
            get => (byte) Values["slaydragon"];
            set => ChangeValue("slaydragon", value);
        }

        public byte FedMount
        {
            get => (byte) Values["fedmount"];
            set => ChangeValue("fedmount", value);
        }

        public DateTime RegDate
        {
            get => (DateTime) Values["regdate"];
            set => ChangeValue("regdate", value);
        }

        public uint ClanId
        {
            get => (uint) Values["clanid"];
            set => ChangeValue("clanid", value);
        }

        public byte ClanRank
        {
            get => (byte) Values["clanrank"];
            set => ChangeValue("clanrank", value);
        }

        public DateTime ClanJoinDate
        {
            get => (DateTime) Values["clanjoindate"];
            set => ChangeValue("clanjoindate", value);
        }
    }
}
