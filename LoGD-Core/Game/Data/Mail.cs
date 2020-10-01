#region

using System;
using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Mail : DatabaseRow<uint, Mail>
    {
        public Mail(DatabaseTable<uint, Mail> parent) : base(parent)
        {
        }

        public Mail(DatabaseTable<uint, Mail> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public uint MessageId
        {
            get => (uint) Values["messageid"];
            set => ChangeValue("messageid", value);
        }

        public string MsgFrom
        {
            get => (string) Values["msgfrom"];
            set => ChangeValue("msgfrom", value);
        }

        public uint MsgTo
        {
            get => (uint) Values["msgto"];
            set => ChangeValue("msgto", value);
        }

        public string Subject
        {
            get => (string) Values["subject"];
            set => ChangeValue("subject", value);
        }

        public string Body
        {
            get => (string) Values["body"];
            set => ChangeValue("body", value);
        }

        public DateTime Sent
        {
            get => (DateTime) Values["sent"];
            set => ChangeValue("sent", value);
        }

        public sbyte Seen
        {
            get => (sbyte) Values["seen"];
            set => ChangeValue("seen", value);
        }

        public uint Originator
        {
            get => (uint) Values["originator"];
            set => ChangeValue("originator", value);
        }
    }
}
