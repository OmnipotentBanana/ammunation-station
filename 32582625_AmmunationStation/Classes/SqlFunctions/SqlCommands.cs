using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _32582625_AmmunationStation.Classes.SqlFunctions
{
    class SqlCommands
    {
        private string connectionString = Properties.Settings.Default.AmmunationPOSConnectionString;
        
        public DataSet sqlSelect(string sql)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(sql, connection);
            adapter.SelectCommand = cmd;
            adapter.Fill(ds, "SourceTable");
            connection.Close();
            return ds;
        }

        public void sqlUpdate(string sql)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(sql, connection);
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.ExecuteNonQuery();
            connection.Close();
        }

        public void sqlInsert(string sql)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(sql, connection);
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.ExecuteNonQuery();
            connection.Close();
        }

        public void sqlDelete(string sql)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(sql, connection);
            adapter.DeleteCommand = cmd;
            adapter.DeleteCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
