#region

using System;
using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class News : DatabaseRow<object[], News>
    {
        public News(DatabaseTable<object[], News> parent) : base(parent)
        {
        }

        public News(DatabaseTable<object[], News> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public uint NewsId
        {
            get => (uint) Values["newsid"];
            set => ChangeValue("newsid", value);
        }

        public string NewsText
        {
            get => (string) Values["newstext"];
            set => ChangeValue("newstext", value);
        }

        public DateTime NewsDate
        {
            get => (DateTime) Values["newsdate"];
            set => ChangeValue("newsdate", value);
        }

        public uint AccountId
        {
            get => (uint) Values["accountid"];
            set => ChangeValue("accountid", value);
        }

        public string Arguments
        {
            get => (string) Values["arguments"];
            set => ChangeValue("arguments", value);
        }

        public string Tlschema
        {
            get => (string) Values["tlschema"];
            set => ChangeValue("tlschema", value);
        }
    }
}
