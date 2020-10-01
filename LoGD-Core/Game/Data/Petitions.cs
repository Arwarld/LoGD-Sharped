#region

using System;
using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Petitions : DatabaseRow<uint, Petitions>
    {
        public Petitions(DatabaseTable<uint, Petitions> parent) : base(parent)
        {
        }

        public Petitions(DatabaseTable<uint, Petitions> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public uint PetitionId
        {
            get => (uint) Values["petitionid"];
            set => ChangeValue("petitionid", value);
        }

        public uint Author
        {
            get => (uint) Values["author"];
            set => ChangeValue("author", value);
        }

        public DateTime Date
        {
            get => (DateTime) Values["date"];
            set => ChangeValue("date", value);
        }

        public uint Status
        {
            get => (uint) Values["status"];
            set => ChangeValue("status", value);
        }

        public string Body
        {
            get => (string) Values["body"];
            set => ChangeValue("body", value);
        }

        public string PageInfo
        {
            get => (string) Values["pageinfo"];
            set => ChangeValue("pageinfo", value);
        }

        public DateTime CloseDate
        {
            get => (DateTime) Values["closedate"];
            set => ChangeValue("closedate", value);
        }

        public uint CloseuserId
        {
            get => (uint) Values["closeuserid"];
            set => ChangeValue("closeuserid", value);
        }

        public string Ip
        {
            get => (string) Values["ip"];
            set => ChangeValue("ip", value);
        }

        public string Id
        {
            get => (string) Values["id"];
            set => ChangeValue("id", value);
        }
    }
}
