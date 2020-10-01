#region

using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Titles : DatabaseRow<uint, Titles>
    {
        public Titles(DatabaseTable<uint, Titles> parent) : base(parent)
        {
        }

        public Titles(DatabaseTable<uint, Titles> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public uint TitleId
        {
            get => (uint) Values["titleid"];
            set => ChangeValue("titleid", value);
        }

        public int Dk
        {
            get => (int) Values["dk"];
            set => ChangeValue("dk", value);
        }

        public string Ref
        {
            get => (string) Values["ref"];
            set => ChangeValue("ref", value);
        }

        public string Male
        {
            get => (string) Values["male"];
            set => ChangeValue("male", value);
        }

        public string Female
        {
            get => (string) Values["female"];
            set => ChangeValue("female", value);
        }
    }
}
