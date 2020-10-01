#region

using System;
using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Referers : DatabaseRow<uint, Referers>
    {
        public Referers(DatabaseTable<uint, Referers> parent) : base(parent)
        {
        }

        public Referers(DatabaseTable<uint, Referers> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public uint RefererId
        {
            get => (uint) Values["refererid"];
            set => ChangeValue("refererid", value);
        }

        public string Uri
        {
            get => (string) Values["uri"];
            set => ChangeValue("uri", value);
        }

        public int Count
        {
            get => (int) Values["count"];
            set => ChangeValue("count", value);
        }

        public DateTime Last
        {
            get => (DateTime) Values["last"];
            set => ChangeValue("last", value);
        }

        public string Site
        {
            get => (string) Values["site"];
            set => ChangeValue("site", value);
        }

        public string Dest
        {
            get => (string) Values["dest"];
            set => ChangeValue("dest", value);
        }

        public string Ip
        {
            get => (string) Values["ip"];
            set => ChangeValue("ip", value);
        }
    }
}
