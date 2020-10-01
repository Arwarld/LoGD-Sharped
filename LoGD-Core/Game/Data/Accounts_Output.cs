#region

using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Accounts_Output : DatabaseRow<uint, Accounts_Output>
    {
        public Accounts_Output(DatabaseTable<uint, Accounts_Output> parent) : base(parent)
        {
        }

        public Accounts_Output(DatabaseTable<uint, Accounts_Output> parent, MySqlDataReader reader) : base(parent,
            reader)
        {
        }

        public uint AcctId
        {
            get => (uint) Values["acctid"];
            set => ChangeValue("acctid", value);
        }

        public string Output
        {
            get => (string) Values["output"];
            set => ChangeValue("output", value);
        }
    }
}
