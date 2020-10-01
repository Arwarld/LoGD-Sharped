#region

using System;
using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Motd : DatabaseRow<uint, Motd>
    {
        public Motd(DatabaseTable<uint, Motd> parent) : base(parent)
        {
        }

        public Motd(DatabaseTable<uint, Motd> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public uint MotdItem
        {
            get => (uint) Values["motditem"];
            set => ChangeValue("motditem", value);
        }

        public string MotdTitle
        {
            get => (string) Values["motdtitle"];
            set => ChangeValue("motdtitle", value);
        }

        public string MotdBody
        {
            get => (string) Values["motdbody"];
            set => ChangeValue("motdbody", value);
        }

        public DateTime MotdDate
        {
            get => (DateTime) Values["motddate"];
            set => ChangeValue("motddate", value);
        }

        public byte MotdType
        {
            get => (byte) Values["motdtype"];
            set => ChangeValue("motdtype", value);
        }

        public uint MotdAuthor
        {
            get => (uint) Values["motdauthor"];
            set => ChangeValue("motdauthor", value);
        }
    }
}
