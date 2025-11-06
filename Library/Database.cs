using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Database
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public DataTable Select(string command)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            cnn.ConnectionString = @"Data Source=.;Initial Catalog=libraryDB;Integrated Security=True";
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = command;
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(dataTable);
            cnn.Close();
            return dataTable;
        }

        public bool SelectCommand(String command)
        {
            cnn.ConnectionString = @"Data Source=.;Initial Catalog=libraryDB;Integrated Security=True";
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = command;
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
