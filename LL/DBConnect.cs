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
                _server = "thrn.ddns.net,1600";
                _database = "SacrumDb";
            }
        
            catch (Exception e)
            {
                MessageBox.Show(string.Concat(e.Message, e.StackTrace), "");
            }

        }

        public SqlConnection Open() 
        {
            sqlConnectionString = "Data Source=thrn.ddns.net,1600;Initial Catalog=SacrumDb;User Id=sa; Password=D13g0";
            var conn = new SqlConnection(sqlConnectionString); 
            conn.Open();
            return conn;
        }
    }
}