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
        private string connectionString;

        public dbMain() 
        {
            connectionString = "Data Source = (local); Initial Catalog = TrungTamAnhNgu; User ID = Khach; Password = 1@34a";
        }

        public dbMain(string userName, string password)
        {
            connectionString = "Data Source = (local); Initial Catalog = TrungTamAnhNgu; User ID = " + userName + "; Password = " + password;
        }

        public DataTable ExcuteQuery(string query, ref string error)
        {
            try
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
            catch (SqlException e)
            {
                error = e.Message;
                return null;
            }
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
                try
                {
                    data = command.ExecuteScalar();
                }
                catch (SqlException e)
                {
                    string s = e.Message;
                }
                finally
                {
                    connection.Close();
                }
            }
            return data;
        }

        public SqlDataReader ExcuteReader(string strSql, CommandType ct)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand comm = connection.CreateCommand();
            if (connection.State == ConnectionState.Open)
                connection.Close();
            connection.Open();
            comm.CommandText = strSql;
            comm.CommandType = ct;
            return comm.ExecuteReader();
        }
    }
}
