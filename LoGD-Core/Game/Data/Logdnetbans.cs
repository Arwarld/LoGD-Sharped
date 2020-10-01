#region

using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Logdnetbans : DatabaseRow<uint, Logdnetbans>
    {
        public Logdnetbans(DatabaseTable<uint, Logdnetbans> parent) : base(parent)
        {
        }

        public Logdnetbans(DatabaseTable<uint, Logdnetbans> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public uint BanId
        {
            get => (uint) Values["banid"];
            set => ChangeValue("banid", value);
        }

        public string BanType
        {
            get => (string) Values["bantype"];
            set => ChangeValue("bantype", value);
        }

        public string BanValue
        {
            get => (string) Values["banvalue"];
            set => ChangeValue("banvalue", value);
        }
    }
}
