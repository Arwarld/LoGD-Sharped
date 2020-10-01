#region

using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Nastywords : DatabaseRow<int, Nastywords>
    {
        public Nastywords(DatabaseTable<int, Nastywords> parent, int overridePrimaryKey) : base(parent,
            overridePrimaryKey)
        {
        }

        public Nastywords(DatabaseTable<int, Nastywords> parent, MySqlDataReader reader, int overridePrimaryKey)
            : base(parent, reader, overridePrimaryKey)
        {
        }

        public string Words
        {
            get => (string) Values["words"];
            set => ChangeValue("words", value);
        }

        public string Type
        {
            get => (string) Values["type"];
            set => ChangeValue("type", value);
        }
    }
}
