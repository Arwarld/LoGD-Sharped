#region

using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Pollresults : DatabaseRow<uint, Pollresults>
    {
        public Pollresults(DatabaseTable<uint, Pollresults> parent) : base(parent)
        {
        }

        public Pollresults(DatabaseTable<uint, Pollresults> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public uint ResultId
        {
            get => (uint) Values["resultid"];
            set => ChangeValue("resultid", value);
        }

        public uint Choice
        {
            get => (uint) Values["choice"];
            set => ChangeValue("choice", value);
        }

        public uint Account
        {
            get => (uint) Values["account"];
            set => ChangeValue("account", value);
        }

        public uint MotdItem
        {
            get => (uint) Values["motditem"];
            set => ChangeValue("motditem", value);
        }
    }
}
