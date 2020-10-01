#region

using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Taunts : DatabaseRow<uint, Taunts>
    {
        public Taunts(DatabaseTable<uint, Taunts> parent) : base(parent)
        {
        }

        public Taunts(DatabaseTable<uint, Taunts> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public uint TauntId
        {
            get => (uint) Values["tauntid"];
            set => ChangeValue("tauntid", value);
        }

        public string Taunt
        {
            get => (string) Values["taunt"];
            set => ChangeValue("taunt", value);
        }

        public string Editor
        {
            get => (string) Values["editor"];
            set => ChangeValue("editor", value);
        }
    }
}
