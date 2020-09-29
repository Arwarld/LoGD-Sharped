#region

using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Armor : DatabaseRow<uint, Armor>
    {
        public Armor(DatabaseTable<uint, Armor> parent)
            : base(parent)
        {
        }

        public Armor(DatabaseTable<uint, Armor> parent, MySqlDataReader reader)
            : base(parent, reader)
        {
        }

        public uint ArmorId
        {
            get => (uint) Values["armorid"];
            set => ChangeValue("armorid", value);
        }

        public string ArmorName
        {
            get => (string) Values["armorname"];
            set => ChangeValue("armorname", value);
        }

        public int Value
        {
            get => (int) Values["value"];
            set => ChangeValue("value", value);
        }

        public int Defense
        {
            get => (int) Values["defense"];
            set => ChangeValue("defense", value);
        }

        public int Level
        {
            get => (int) Values["level"];
            set => ChangeValue("level", value);
        }
    }
}
