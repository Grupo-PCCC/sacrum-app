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
    public class ParishionerByActivity
    {
        public Activity _activity;
        public Parishioner _parishioner;

        public ParishionerByActivity()
            {
            _activity = new Activity();
            _parishioner = new Parishioner();
            }

        public List<ParishionerByActivity> ListAllParishionerInActivity(int activityId)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            var Lista = new List<ParishionerByActivity>();

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "ListAllParishionerInActivity";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ActivityId", activityId);
                var rdr = command.ExecuteReader();

                while (rdr != null && rdr.Read())
                {
                    var reg = new ParishionerByActivity();
                    reg._parishioner.Id = (int)rdr["Id"];
                    reg._parishioner.Name = (string)rdr["Nombre"];
                    Lista.Add(reg);
                }//while

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

            return Lista;
        }//Listar

        public List<ParishionerByActivity> ListAllParishionerNotInActivity(int activityId)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            var Lista = new List<ParishionerByActivity>();

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "ListAllParishionerNotInActivity";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ActivityId", activityId);
                var rdr = command.ExecuteReader();

                while (rdr != null && rdr.Read())
                {
                    var reg = new ParishionerByActivity();
                    reg._parishioner.Id = (int)rdr["Id"];
                    reg._parishioner.Name = (string)rdr["Nombre"];
                    Lista.Add(reg);
                }//while

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

            return Lista;
        }//Listar

        public bool NewParishionerByActivity(int activityId, int parishId)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "NewParishionerByActivity";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ParishionerId", parishId);
                command.Parameters.AddWithValue("@ActivityId", activityId);
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

        public bool DeleteParishionerByActivity(int activityId, int parishId)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "DeleteParishionerByActivity";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ActivityId", activityId);
                command.Parameters.AddWithValue("@ParishionerId", parishId);
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

        public bool DeleteActivityInParishionerByActivity(int activityId)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "DeleteActivityInParishionerByActivity";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ActivityId", activityId);
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
    }
}
