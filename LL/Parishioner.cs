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
    public class Parishioner    
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Documento { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Observation { get; set; }

        public ParishionerData _parishionerData;

        public Parishioner()
        {
            _parishionerData = new ParishionerData();
        }


        public bool NewParishioner(Parishioner P)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "NewParishioner";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", P.Name);
                command.Parameters.AddWithValue("@Surname", P.Surname);
                command.Parameters.AddWithValue("@Documento", P.Documento);
                if (P.BirthDate == null)
                {
                    command.Parameters.AddWithValue("@BirthDate", Convert.DBNull);
                }
                else
                {
                    command.Parameters.AddWithValue("@BirthDate", P.BirthDate);
                }
                command.Parameters.AddWithValue("@Observation", P.Observation);
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

        public bool UpdateParishioner (Parishioner P)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "UpdateParishioner";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", P.Id);
                command.Parameters.AddWithValue("@Name", P.Name);
                command.Parameters.AddWithValue("@Surname", P.Surname);
                command.Parameters.AddWithValue("@Documento", P.Documento);
                if (P.BirthDate == null)
                {
                    command.Parameters.AddWithValue("@BirthDate", Convert.DBNull);
                }
                else
                {
                    command.Parameters.AddWithValue("@BirthDate", P.BirthDate);
                }
                command.Parameters.AddWithValue("@Observation", P.Observation);
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

        public bool DeleteParishioner(int P)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "DeleteParishioner";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", P);
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
        }//Delete


        public List<Parishioner> Listar(string Name)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            var Lista = new List<Parishioner>();


            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "ListParish";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", Name);
                var rdr = command.ExecuteReader();

                while (rdr != null && rdr.Read())
                {
                    var reg = new Parishioner();
                    reg.Id = (int)rdr["Id"];
                    reg.Name = (string)rdr["Name"];
                    reg.Surname = (string)rdr["Surname"];
                    reg.Documento = (string)rdr["Documento"];
                    if (rdr["BirthDate"] is DBNull)
                    {
                        reg.BirthDate = null;
                    }
                    else
                    {
                        reg.BirthDate = Convert.ToDateTime(rdr["BirthDate"]);
                    }
                    reg.Telephone = Convert.ToString(rdr["Telephone"] is DBNull ? "" : rdr["Telephone"]);
                    reg.Address = Convert.ToString(rdr["Address"] is DBNull ? "" : rdr["Address"]);
                    reg.Mail = Convert.ToString(rdr["Mail"] is DBNull ? "" : rdr["Mail"]);
                    reg.Observation = Convert.ToString(rdr["Observation"] is DBNull ? "" : rdr["Observation"]);
                    if (rdr["IdTel"] is DBNull)
                    {
                        reg._parishionerData.IdTel = null;
                    }
                    else
                    {
                        reg._parishionerData.IdTel = (int)rdr["IdTel"];
                    }
                    if (rdr["IdAddress"] is DBNull)
                    {
                        reg._parishionerData.IdAddress = null;
                    }
                    else
                    {
                        reg._parishionerData.IdAddress = (int)rdr["IdAddress"];
                    }
                    if (rdr["IdMail"] is DBNull)
                    {
                        reg._parishionerData.IdMail = null;
                    }
                    else
                    {
                        reg._parishionerData.IdMail = (int)rdr["IdMail"];
                    }
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

        public List<Parishioner> ListParishByActivity(string Name, int activityId)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            var Lista = new List<Parishioner>();

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "ListParishByActivity";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@ActivityId", activityId);
                var rdr = command.ExecuteReader();

                while (rdr != null && rdr.Read())
                {
                    var reg = new Parishioner();
                    reg.Id = (int)rdr["Id"];
                    reg.Name = (string)rdr["Name"];
                    reg.Surname = (string)rdr["Surname"];
                    reg.Documento = (string)rdr["Documento"];
                    if (rdr["BirthDate"] is DBNull)
                    {
                        reg.BirthDate = null;
                    }
                    else
                    {
                        reg.BirthDate = Convert.ToDateTime(rdr["BirthDate"]);
                    }
                    reg.Telephone = Convert.ToString(rdr["Telephone"] is DBNull ? "" : rdr["Telephone"]);
                    reg.Address = Convert.ToString(rdr["Address"] is DBNull ? "" : rdr["Address"]);
                    reg.Mail = Convert.ToString(rdr["Mail"] is DBNull ? "" : rdr["Mail"]);
                    reg.Observation = Convert.ToString(rdr["Observation"] is DBNull ? "" : rdr["Observation"]);
                    if (rdr["IdTel"] is DBNull)
                    {
                        reg._parishionerData.IdTel = null;
                    }
                    else
                    {
                        reg._parishionerData.IdTel = (int)rdr["IdTel"];
                    }
                    if (rdr["IdAddress"] is DBNull)
                    {
                        reg._parishionerData.IdAddress = null;
                    }
                    else
                    {
                        reg._parishionerData.IdAddress = (int)rdr["IdAddress"];
                    }
                    if (rdr["IdMail"] is DBNull)
                    {
                        reg._parishionerData.IdMail = null;
                    }
                    else
                    {
                        reg._parishionerData.IdMail = (int)rdr["IdMail"];
                    }
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
                command.CommandText = "SELECT MAX(Id) Id FROM Parishioner";
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
        public bool FindParishionerInActivities(int P)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "FindParishionerInActivities";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ParishionerId", P);
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
        public bool FindParishioner(string documento)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "FindParishioner";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Documento", documento);
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
    }//Class




}