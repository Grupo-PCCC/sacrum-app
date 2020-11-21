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
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Observation { get; set; }

        public bool NewActivity(Activity A)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "NewActivity";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", A.Name);
                command.Parameters.AddWithValue("@Observation", A.Observation);
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

        public bool UpdateActivity(Activity A)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "UpdateActivity";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", A.Id);
                command.Parameters.AddWithValue("@Name", A.Name);
                command.Parameters.AddWithValue("@Observation", A.Observation);
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

        public bool DeleteActivity(int activityId)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "DeleteActivity";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", activityId);
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

        public int GetLastId()
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            int id = 0;
            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "SELECT MAX(Id) Id FROM Activity";
                var scl = command.ExecuteScalar();
                id = Convert.ToInt32(scl);
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
            return id;
        }
        public bool FindActivityInParishionerByActivity(int A)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "FindActivityInParishionerByActivity";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ParishionerId", A);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
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

        public string GetActivityObservation(int activityId)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            string observation = "";
            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "GetActivityObservation";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ActivityId", activityId);
                var scl = command.ExecuteScalar();
                observation = Convert.ToString(scl);
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
            return observation;
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

        public string GetActivityName(int A)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            string activityName = "";
            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "SELECT Name FROM Activity WHERE Id=" + A;
                var scl = command.ExecuteScalar();
                activityName = Convert.ToString(scl);
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
            return activityName;
        }
        public bool FindActivity(string A)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "FindActivity";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", A);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
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
