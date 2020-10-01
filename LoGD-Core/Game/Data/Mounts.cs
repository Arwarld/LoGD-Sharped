#region

using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Mounts : DatabaseRow<uint, Mounts>
    {
        public Mounts(DatabaseTable<uint, Mounts> parent) : base(parent)
        {
        }

        public Mounts(DatabaseTable<uint, Mounts> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public uint MountId
        {
            get => (uint) Values["mountid"];
            set => ChangeValue("mountid", value);
        }

        public string MountName
        {
            get => (string) Values["mountname"];
            set => ChangeValue("mountname", value);
        }

        public string MountDesc
        {
            get => (string) Values["mountdesc"];
            set => ChangeValue("mountdesc", value);
        }

        public string MountCategory
        {
            get => (string) Values["mountcategory"];
            set => ChangeValue("mountcategory", value);
        }

        public string MountBuff
        {
            get => (string) Values["mountbuff"];
            set => ChangeValue("mountbuff", value);
        }

        public uint MountCostGems
        {
            get => (uint) Values["mountcostgems"];
            set => ChangeValue("mountcostgems", value);
        }

        public uint MountCostGold
        {
            get => (uint) Values["mountcostgold"];
            set => ChangeValue("mountcostgold", value);
        }

        public uint MountActive
        {
            get => (uint) Values["mountactive"];
            set => ChangeValue("mountactive", value);
        }

        public int MountForestFights
        {
            get => (int) Values["mountforestfights"];
            set => ChangeValue("mountforestfights", value);
        }

        public string NewDay
        {
            get => (string) Values["newday"];
            set => ChangeValue("newday", value);
        }

        public string ReCharge
        {
            get => (string) Values["recharge"];
            set => ChangeValue("recharge", value);
        }

        public string PartReCharge
        {
            get => (string) Values["partrecharge"];
            set => ChangeValue("partrecharge", value);
        }

        public uint MountFeedCost
        {
            get => (uint) Values["mountfeedcost"];
            set => ChangeValue("mountfeedcost", value);
        }

        public string MountLocation
        {
            get => (string) Values["mountlocation"];
            set => ChangeValue("mountlocation", value);
        }

        public uint MountDkCost
        {
            get => (uint) Values["mountdkcost"];
            set => ChangeValue("mountdkcost", value);
        }
    }
}
