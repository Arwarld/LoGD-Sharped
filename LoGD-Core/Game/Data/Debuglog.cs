#region

using System;
using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Debuglog : DatabaseRow<uint, Debuglog>
    {
        public Debuglog(DatabaseTable<uint, Debuglog> parent) : base(parent)
        {
        }

        public Debuglog(DatabaseTable<uint, Debuglog> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public uint Id
        {
            get => (uint) Values["id"];
            set => ChangeValue("id", value);
        }

        public DateTime Date
        {
            get => (DateTime) Values["date"];
            set => ChangeValue("date", value);
        }

        public uint Actor
        {
            get => (uint) Values["actor"];
            set => ChangeValue("actor", value);
        }

        public uint Target
        {
            get => (uint) Values["target"];
            set => ChangeValue("target", value);
        }

        public string Message
        {
            get => (string) Values["message"];
            set => ChangeValue("message", value);
        }

        public string Field
        {
            get => (string) Values["field"];
            set => ChangeValue("field", value);
        }

        public float Value
        {
            get => (float) Values["value"];
            set => ChangeValue("value", value);
        }
    }
}
