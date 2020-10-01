#region

using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Creatures : DatabaseRow<int, Creatures>
    {
        public Creatures(DatabaseTable<int, Creatures> parent) : base(parent)
        {
        }

        public Creatures(DatabaseTable<int, Creatures> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public int CreatureId
        {
            get => (int) Values["creatureid"];
            set => ChangeValue("creatureid", value);
        }

        public string CreatureName
        {
            get => (string) Values["creaturename"];
            set => ChangeValue("creaturename", value);
        }

        public int CreatureLevel
        {
            get => (int) Values["creaturelevel"];
            set => ChangeValue("creaturelevel", value);
        }

        public string CreatureWeapon
        {
            get => (string) Values["creatureweapon"];
            set => ChangeValue("creatureweapon", value);
        }

        public string CreatureLose
        {
            get => (string) Values["creaturelose"];
            set => ChangeValue("creaturelose", value);
        }

        public string CreatureWin
        {
            get => (string) Values["creaturewin"];
            set => ChangeValue("creaturewin", value);
        }

        public int CreatureGold
        {
            get => (int) Values["creaturegold"];
            set => ChangeValue("creaturegold", value);
        }

        public int CreatureExp
        {
            get => (int) Values["creatureexp"];
            set => ChangeValue("creatureexp", value);
        }

        public int CreatureHealth
        {
            get => (int) Values["creaturehealth"];
            set => ChangeValue("creaturehealth", value);
        }

        public int CreatureAttack
        {
            get => (int) Values["creatureattack"];
            set => ChangeValue("creatureattack", value);
        }

        public int CreatureDefense
        {
            get => (int) Values["creaturedefense"];
            set => ChangeValue("creaturedefense", value);
        }

        public string CreatureAiScript
        {
            get => (string) Values["creatureaiscript"];
            set => ChangeValue("creatureaiscript", value);
        }

        public string CreatedBy
        {
            get => (string) Values["createdby"];
            set => ChangeValue("createdby", value);
        }

        public sbyte Forest
        {
            get => (sbyte) Values["forest"];
            set => ChangeValue("forest", value);
        }

        public sbyte Graveyard
        {
            get => (sbyte) Values["graveyard"];
            set => ChangeValue("graveyard", value);
        }

        public int OldCreatureExp
        {
            get => (int) Values["oldcreatureexp"];
            set => ChangeValue("oldcreatureexp", value);
        }
    }
}
