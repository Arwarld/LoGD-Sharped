#region

using System;
using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Moderatedcomments : DatabaseRow<uint, Moderatedcomments>
    {
        public Moderatedcomments(DatabaseTable<uint, Moderatedcomments> parent) : base(parent)
        {
        }

        public Moderatedcomments(DatabaseTable<uint, Moderatedcomments> parent, MySqlDataReader reader) : base(parent,
            reader)
        {
        }

        public uint ModId
        {
            get => (uint) Values["modid"];
            set => ChangeValue("modid", value);
        }

        public string Comment
        {
            get => (string) Values["comment"];
            set => ChangeValue("comment", value);
        }

        public uint Moderator
        {
            get => (uint) Values["moderator"];
            set => ChangeValue("moderator", value);
        }

        public DateTime ModDate
        {
            get => (DateTime) Values["moddate"];
            set => ChangeValue("moddate", value);
        }
    }
}
