#region

using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Settings : DatabaseRow<string, Settings>
    {
        public Settings(DatabaseTable<string, Settings> parent) : base(parent)
        {
        }

        public Settings(DatabaseTable<string, Settings> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public string Setting
        {
            get => (string) Values["setting"];
            set => ChangeValue("setting", value);
        }

        public string Value
        {
            get => (string) Values["value"];
            set => ChangeValue("value", value);
        }
    }
}
