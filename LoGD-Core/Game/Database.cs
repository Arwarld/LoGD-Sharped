using System.Data.SqlClient;
using System.Data;

namespace LoGD.Core.Game
{
    public class Database
    {
        private SqlConnection connection;
        public Database()
        {
            SqlConnection connection = new SqlConnection();
        }
    }
}
