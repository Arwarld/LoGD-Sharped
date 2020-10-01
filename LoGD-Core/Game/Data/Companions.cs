#region

using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Companions : DatabaseRow<uint, Companions>
    {
        public Companions(DatabaseTable<uint, Companions> parent) : base(parent)
        {
        }

        public Companions(DatabaseTable<uint, Companions> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public uint CompanionId
        {
            get => (uint) Values["companionid"];
            set => ChangeValue("companionid", value);
        }

        public string Name
        {
            get => (string) Values["name"];
            set => ChangeValue("name", value);
        }

        public string Category
        {
            get => (string) Values["category"];
            set => ChangeValue("category", value);
        }

        public string Description
        {
            get => (string) Values["description"];
            set => ChangeValue("description", value);
        }

        public uint Attack
        {
            get => (uint) Values["attack"];
            set => ChangeValue("attack", value);
        }

        public uint AttackPerLevel
        {
            get => (uint) Values["attackperlevel"];
            set => ChangeValue("attackperlevel", value);
        }

        public uint Defense
        {
            get => (uint) Values["defense"];
            set => ChangeValue("defense", value);
        }

        public uint DefensePerLevel
        {
            get => (uint) Values["defenseperlevel"];
            set => ChangeValue("defenseperlevel", value);
        }

        public uint MaxHitPoints
        {
            get => (uint) Values["maxhitpoints"];
            set => ChangeValue("maxhitpoints", value);
        }

        public uint MaxHitPointsPerLevel
        {
            get => (uint) Values["maxhitpointsperlevel"];
            set => ChangeValue("maxhitpointsperlevel", value);
        }

        public string Abilities
        {
            get => (string) Values["abilities"];
            set => ChangeValue("abilities", value);
        }

        public sbyte CanNotDie
        {
            get => (sbyte) Values["cannotdie"];
            set => ChangeValue("cannotdie", value);
        }

        public sbyte CanNotBeHealed
        {
            get => (sbyte) Values["cannotbehealed"];
            set => ChangeValue("cannotbehealed", value);
        }

        public string CompanionLocation
        {
            get => (string) Values["companionlocation"];
            set => ChangeValue("companionlocation", value);
        }

        public sbyte CompanionActive
        {
            get => (sbyte) Values["companionactive"];
            set => ChangeValue("companionactive", value);
        }

        public sbyte CompanionCostDks
        {
            get => (sbyte) Values["companioncostdks"];
            set => ChangeValue("companioncostdks", value);
        }

        public int CompanionCostGems
        {
            get => (int) Values["companioncostgems"];
            set => ChangeValue("companioncostgems", value);
        }

        public int CompanionCostGold
        {
            get => (int) Values["companioncostgold"];
            set => ChangeValue("companioncostgold", value);
        }

        public string JoinText
        {
            get => (string) Values["jointext"];
            set => ChangeValue("jointext", value);
        }

        public string DyingText
        {
            get => (string) Values["dyingtext"];
            set => ChangeValue("dyingtext", value);
        }

        public sbyte AllowInShades
        {
            get => (sbyte) Values["allowinshades"];
            set => ChangeValue("allowinshades", value);
        }

        public sbyte AllowInPvp
        {
            get => (sbyte) Values["allowinpvp"];
            set => ChangeValue("allowinpvp", value);
        }

        public sbyte AllowInTrain
        {
            get => (sbyte) Values["allowintrain"];
            set => ChangeValue("allowintrain", value);
        }
    }
}
