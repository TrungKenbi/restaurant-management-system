using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAO
{
    public class DataProvider
    {
        private SqlConnection connection;

        private static DataProvider instance;

        public static DataProvider GetInstance
        {
            get {
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            }
            private set {
                DataProvider.instance = value;
            }
        }

        private DataProvider() {
            string connectionString = ConfigurationManager
                .ConnectionStrings["DefaultConnectionString"]
                .ConnectionString;
            this.connection = new SqlConnection(connectionString);
            this.connection.Open();
        }

        ~DataProvider()
        {
            //if (this.connection != null)
            //    this.connection.Close();
        }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand(query, connection);
            this.ParseParameter(ref command, query, parameter);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            SqlCommand command = new SqlCommand(query, connection);
            this.ParseParameter(ref command, query, parameter);
            int data = command.ExecuteNonQuery();
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            SqlCommand command = new SqlCommand(query, connection);
            this.ParseParameter(ref command, query, parameter);
            object data = command.ExecuteScalar();
            return data;
        }

        private void ParseParameter(ref SqlCommand cmd, String query, object[] parameter)
        {
            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                    if (item.Contains('@'))
                    {
                        cmd.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
            }
        }
    }
}
