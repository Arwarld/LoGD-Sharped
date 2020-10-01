#region

using System;
using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Commentary : DatabaseRow<uint, Commentary>
    {
        public Commentary(DatabaseTable<uint, Commentary> parent) : base(parent)
        {
        }

        public Commentary(DatabaseTable<uint, Commentary> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public uint CommentId
        {
            get => (uint) Values["commentid"];
            set => ChangeValue("commentid", value);
        }

        public string Section
        {
            get => (string) Values["section"];
            set => ChangeValue("section", value);
        }

        public uint Author
        {
            get => (uint) Values["author"];
            set => ChangeValue("author", value);
        }

        public string Comment
        {
            get => (string) Values["comment"];
            set => ChangeValue("comment", value);
        }

        public DateTime PostDate
        {
            get => (DateTime) Values["postdate"];
            set => ChangeValue("postdate", value);
        }
    }
}
