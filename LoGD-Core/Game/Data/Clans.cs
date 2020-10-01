#region

using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Clans : DatabaseRow<uint, Clans>
    {
        public Clans(DatabaseTable<uint, Clans> parent) : base(parent)
        {
        }

        public Clans(DatabaseTable<uint, Clans> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public uint ClanId
        {
            get => (uint) Values["clanid"];
            set => ChangeValue("clanid", value);
        }

        public string ClanName
        {
            get => (string) Values["clanname"];
            set => ChangeValue("clanname", value);
        }

        public string ClanShort
        {
            get => (string) Values["clanshort"];
            set => ChangeValue("clanshort", value);
        }

        public string ClanMotd
        {
            get => (string) Values["clanmotd"];
            set => ChangeValue("clanmotd", value);
        }

        public string ClanDesc
        {
            get => (string) Values["clandesc"];
            set => ChangeValue("clandesc", value);
        }

        public uint MotdAuthor
        {
            get => (uint) Values["motdauthor"];
            set => ChangeValue("motdauthor", value);
        }

        public uint DescAuthor
        {
            get => (uint) Values["descauthor"];
            set => ChangeValue("descauthor", value);
        }

        public string CustomSay
        {
            get => (string) Values["customsay"];
            set => ChangeValue("customsay", value);
        }
    }
}
