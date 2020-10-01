#region

using System;
using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Faillog : DatabaseRow<uint, Faillog>
    {
        public Faillog(DatabaseTable<uint, Faillog> parent) : base(parent)
        {
        }

        public Faillog(DatabaseTable<uint, Faillog> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public uint EventId
        {
            get => (uint) Values["eventid"];
            set => ChangeValue("eventid", value);
        }

        public DateTime Date
        {
            get => (DateTime) Values["date"];
            set => ChangeValue("date", value);
        }

        public string Post
        {
            get => (string) Values["post"];
            set => ChangeValue("post", value);
        }

        public string Ip
        {
            get => (string) Values["ip"];
            set => ChangeValue("ip", value);
        }

        public uint AcctId
        {
            get => (uint) Values["acctid"];
            set => ChangeValue("acctid", value);
        }

        public string Id
        {
            get => (string) Values["id"];
            set => ChangeValue("id", value);
        }
    }
}
