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
    public class Provider
    {
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Observation { get; set; }
        public ProviderData _providerData;
        public Provider()
        {
            _providerData = new ProviderData();
        }



        public bool NewProvider(Provider P)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "NewProvider";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BusinessName", P.BusinessName);
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

        public bool UpdateProvider(Provider P)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "UpdateProvider";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", P.Id);
                command.Parameters.AddWithValue("@BusinessName", P.BusinessName);
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

        public bool DeleteProvider(int P)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "DeleteProvider";
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
        public List<Provider> Listar(string businessName)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            var Lista = new List<Provider>();


            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "ListProvider";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BusinessName", businessName);
                var rdr = command.ExecuteReader();

                while (rdr != null && rdr.Read())
                {
                    var reg = new Provider();
                    reg.Id = (int)rdr["Id"];
                    reg.BusinessName = (string)rdr["BusinessName"];
                    reg.Telephone = Convert.ToString(rdr["Telephone"] is DBNull ? "" : rdr["Telephone"]);
                    reg.Address = Convert.ToString(rdr["Address"] is DBNull ? "" : rdr["Address"]);
                    reg.Mail = Convert.ToString(rdr["Mail"] is DBNull ? "" : rdr["Mail"]);
                    reg.Observation = (string)rdr["Observation"];
                    reg._providerData.IdTel = (int)rdr["IdTel"];
                    reg._providerData.IdAddress = (int)rdr["IdAddress"];
                    reg._providerData.IdMail = (int)rdr["IdMail"];
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
                command.CommandText = "SELECT MAX(Id) Id FROM Provider";
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

    }
}
