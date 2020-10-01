#region

using System;
using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Logdnet : DatabaseRow<uint, Logdnet>
    {
        public Logdnet(DatabaseTable<uint, Logdnet> parent) : base(parent)
        {
        }

        public Logdnet(DatabaseTable<uint, Logdnet> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public uint ServerId
        {
            get => (uint) Values["serverid"];
            set => ChangeValue("serverid", value);
        }

        public string Address
        {
            get => (string) Values["address"];
            set => ChangeValue("address", value);
        }

        public string Description
        {
            get => (string) Values["description"];
            set => ChangeValue("description", value);
        }

        public double Priority
        {
            get => (double) Values["priority"];
            set => ChangeValue("priority", value);
        }

        public DateTime LastUpdate
        {
            get => (DateTime) Values["lastupdate"];
            set => ChangeValue("lastupdate", value);
        }

        public string Version
        {
            get => (string) Values["version"];
            set => ChangeValue("version", value);
        }

        public string Admin
        {
            get => (string) Values["admin"];
            set => ChangeValue("admin", value);
        }

        public DateTime LastPing
        {
            get => (DateTime) Values["lastping"];
            set => ChangeValue("lastping", value);
        }

        public string RecentIps
        {
            get => (string) Values["recentips"];
            set => ChangeValue("recentips", value);
        }

        public uint Count
        {
            get => (uint) Values["count"];
            set => ChangeValue("count", value);
        }

        public string Lang
        {
            get => (string) Values["lang"];
            set => ChangeValue("lang", value);
        }
    }
}
