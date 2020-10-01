#region

using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Weapons : DatabaseRow<uint, Weapons>
    {
        public Weapons(DatabaseTable<uint, Weapons> parent) : base(parent)
        {
        }

        public Weapons(DatabaseTable<uint, Weapons> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public uint WeaponId
        {
            get => (uint) Values["weaponid"];
            set => ChangeValue("weaponid", value);
        }

        public string WeaponName
        {
            get => (string) Values["weaponname"];
            set => ChangeValue("weaponname", value);
        }

        public int Value
        {
            get => (int) Values["value"];
            set => ChangeValue("value", value);
        }

        public int Damage
        {
            get => (int) Values["damage"];
            set => ChangeValue("damage", value);
        }

        public int Level
        {
            get => (int) Values["level"];
            set => ChangeValue("level", value);
        }
    }
}
