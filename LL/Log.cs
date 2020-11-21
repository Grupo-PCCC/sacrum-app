using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace LL
{
    public class Log
    {
        public int Id { get; set; }
        public Users _users;
        public DateTime ActionDate { get; set; }
        public string Action { get; set; }
        public Log()
        {
            _users = new Users();
        }

        public bool WriteLog(Log L)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "WriteLog";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserId", L._users.Id);
                command.Parameters.AddWithValue("@ActionDate", L.ActionDate);
                command.Parameters.AddWithValue("@Action", L.Action);
                command.ExecuteNonQuery();
                answ = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Concat(e.Message, e.StackTrace), "");
                answ = false;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();

                }

            }
            return answ;
        }


        public List<Log> ListLogByDate(DateTime CMD1, DateTime CMD2)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            var List = new List<Log>();
            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "ListLogByDate";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Date1", CMD1);
                command.Parameters.AddWithValue("@Date2", CMD2);
                var rdr = command.ExecuteReader();
                while (rdr != null && rdr.Read())
                {
                    var reg = new Log();
                    reg.ActionDate= (DateTime)rdr["ActionDate"];
                    reg._users.Nick = (string)rdr["Usuario"];
                    reg.Action = (string)rdr["Action"];
                    List.Add(reg);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Concat(e.Message, e.StackTrace), "");

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();

                }

            }
            return List;
        }

        public List<Log> ListLogByDateAndUser(DateTime CMD1, DateTime CMD2,int userId)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            var List = new List<Log>();
            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "ListLogByDateAndUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Date1", CMD1);
                command.Parameters.AddWithValue("@Date2", CMD2);
                command.Parameters.AddWithValue("@UserId", userId);
                var rdr = command.ExecuteReader();
                while (rdr != null && rdr.Read())
                {
                    var reg = new Log();
                    reg.ActionDate = (DateTime)rdr["ActionDate"];
                    reg._users.Nick = (string)rdr["Usuario"];
                    reg.Action = (string)rdr["Action"];
                    List.Add(reg);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Concat(e.Message, e.StackTrace), "");

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();

                }

            }
            return List;
        }

        public List<Log> ListLogByDateUserAndChain(DateTime CMD1, DateTime CMD2, int userId, string chain)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            var List = new List<Log>();
            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "ListLogByDateUserAndChain";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Date1", CMD1);
                command.Parameters.AddWithValue("@Date2", CMD2);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@Chain", chain);
                var rdr = command.ExecuteReader();
                while (rdr != null && rdr.Read())
                {
                    var reg = new Log();
                    reg.ActionDate = (DateTime)rdr["ActionDate"];
                    reg._users.Nick = (string)rdr["Usuario"];
                    reg.Action = (string)rdr["Action"];
                    List.Add(reg);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Concat(e.Message, e.StackTrace), "");

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();

                }

            }
            return List;
        }

        public List<Log> ListLogByDateAndChain(DateTime CMD1, DateTime CMD2, string chain)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            var List = new List<Log>();
            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "ListLogByDateAndChain";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Date1", CMD1);
                command.Parameters.AddWithValue("@Date2", CMD2);
                command.Parameters.AddWithValue("@Chain", chain);
                var rdr = command.ExecuteReader();
                while (rdr != null && rdr.Read())
                {
                    var reg = new Log();
                    reg.ActionDate = (DateTime)rdr["ActionDate"];
                    reg._users.Nick = (string)rdr["Usuario"];
                    reg.Action = (string)rdr["Action"];
                    List.Add(reg);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Concat(e.Message, e.StackTrace), "");

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();

                }

            }
            return List;
        }
    }
}
