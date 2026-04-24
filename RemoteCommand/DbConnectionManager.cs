using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RemoteCommand
{
    class DbConnectionManager
    {
        private static string _connectionString = "";

        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
