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
            sqlConnectionString = "Data Source=sacrumdb.mssql.somee.com;Initial Catalog=sacrumdb;User Id=PCCC_SQLLogin_1; Password=fxvv2un2ut";
            var conn = new SqlConnection(sqlConnectionString);
            conn.Open();
            return conn;
        }
    }
}