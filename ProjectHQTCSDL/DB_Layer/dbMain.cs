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
        private static dbMain instance;
        public static dbMain Instance
        {
            get { if (instance == null) instance = new dbMain("Data Source=(local);Initial Catalog=TrungTamAnhNgu;Integrated Security=True"); return dbMain.instance; }
            private set => instance = value;
        }

        public dbMain(string connect)
        {
            connectionString = connect;
        }

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
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(data);
                }
                catch (SqlException e)
                {
                    error = e.Message;
                    data = null;
                }
                finally
                {
                    connection.Close();
                }       
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
            connection.Close();
            return comm.ExecuteReader();
        }
    }
}
