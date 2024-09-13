using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QL_VatLieuXayDung.Utils
{
    public class Database
    {
        private static string serverName = "LAPTOP-5BL858OA\\PHUONGNAM";
        private static string databaseName = "QL_VLXD";
        private string connectionString { get; set; }

        public Database()
        {
            this.connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
        }

        public Database(string serverName, string databaseName)
        {
            this.connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
        }

        public DataTable ExecuteQuery(string query)
        {
            try
            {
                DataTable dataTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(dataTable);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                return command.ExecuteNonQuery();
            }
        }

        public object ExecuteScalar(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                return command.ExecuteScalar();
            }
        }

    }
}
