#region

using System;
using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Gamelog : DatabaseRow<uint, Gamelog>
    {
        public Gamelog(DatabaseTable<uint, Gamelog> parent) : base(parent)
        {
        }

        public Gamelog(DatabaseTable<uint, Gamelog> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public uint LogId
        {
            get => (uint) Values["logid"];
            set => ChangeValue("logid", value);
        }

        public string Message
        {
            get => (string) Values["message"];
            set => ChangeValue("message", value);
        }

        public string Category
        {
            get => (string) Values["category"];
            set => ChangeValue("category", value);
        }

        public sbyte Filed
        {
            get => (sbyte) Values["filed"];
            set => ChangeValue("filed", value);
        }

        public DateTime Date
        {
            get => (DateTime) Values["date"];
            set => ChangeValue("date", value);
        }

        public uint Who
        {
            get => (uint) Values["who"];
            set => ChangeValue("who", value);
        }
    }
}
