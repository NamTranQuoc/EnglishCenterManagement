using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHQTCSDL.DB_Layer
{
    public class dbMain
    {
        private static dbMain instance;
        private string connectionString = "Data Source = (local);" + "Initial Catalog = TrungTamAnhNgu;" + "Integrated Security = True";

        public static dbMain Instance
        {
            get { if (instance == null) instance = new dbMain(); return dbMain.instance; }
            private set => instance = value;
        }
        private dbMain() { }
        public DataTable ExcuteQuery(string query)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        public int ExcuteNonQuery(string query, ref string error)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    data = command.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    error = e.Message;
                }
                finally
                {
                    connection.Close();
                }
            }
            return data;
        }
        public object ExcuteScalar(string query)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
    }
}
