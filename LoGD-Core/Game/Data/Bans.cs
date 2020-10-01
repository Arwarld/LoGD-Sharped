#region

using System;
using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Bans : DatabaseRow<int, Bans>
    {
        public Bans(DatabaseTable<int, Bans> parent, int overridePrimaryKey) : base(parent, overridePrimaryKey)
        {
        }

        public Bans(DatabaseTable<int, Bans> parent, MySqlDataReader reader, int overridePrimaryKey) : base(parent,
            reader, overridePrimaryKey)
        {
        }

        public string IpFilter
        {
            get => (string) Values["ipfilter"];
            set => ChangeValue("ipfilter", value);
        }

        public string UniqueId
        {
            get => (string) Values["uniqueid"];
            set => ChangeValue("uniqueid", value);
        }

        public DateTime BanExpire
        {
            get => (DateTime) Values["banexpire"];
            set => ChangeValue("banexpire", value);
        }

        public string BanReason
        {
            get => (string) Values["banreason"];
            set => ChangeValue("banreason", value);
        }

        public string Banner
        {
            get => (string) Values["banner"];
            set => ChangeValue("banner", value);
        }

        public DateTime LastHit
        {
            get => (DateTime) Values["lasthit"];
            set => ChangeValue("lasthit", value);
        }
    }
}
