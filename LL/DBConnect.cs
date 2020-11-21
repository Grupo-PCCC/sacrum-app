using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LL
{
    public class DBConnect
    {
        public string _server;
        public string _database;
        public static string sqlConnectionString;

        public DBConnect()
        {
            try
            {
                _server = System.Net.Dns.GetHostName();
                _database = "SacrumDb";
            }
        
            catch (Exception e)
            {
                MessageBox.Show(string.Concat(e.Message, e.StackTrace), "");
            }

        }

        public SqlConnection Open() 
        {
            sqlConnectionString = ("Server=" + _server + ";Database=" + _database + ";Trusted_Connection=Yes");
            var conn = new SqlConnection(sqlConnectionString); 
            conn.Open();
            return conn;
        }
    }
}