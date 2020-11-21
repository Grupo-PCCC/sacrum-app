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
    public class ParishionerData
    {

        public int? IdTel;
        public int? IdAddress;
        public int? IdMail;
        public string Telephone;
        public string Address;
        public string Mail;
        public string DataType;
        public string Data;
        public int IsPrincipal;
        public int Id;
        public bool NewParishionerData(string dataType,int parishId,string data, int isPrincipal)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "NewParishionerData";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DataType", dataType);
                command.Parameters.AddWithValue("@ParishionerId", parishId);
                command.Parameters.AddWithValue("@Data", data);
                command.Parameters.AddWithValue("@IsPrincipal", isPrincipal);
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

        public bool UpdateParishionerData(int id, string data)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "UpdateParishionerData";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Data", data);
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

        public bool FindData(string data)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "FindDataParishioner";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Data", data);
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

        public int GetDataId(string D)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            int id = 0;
            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "SELECT Id FROM ParishionerData WHERE Name=" + "'" + D + "'";
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

        public List<ParishionerData> Listar(string dataType, int parishId)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            var Lista = new List<ParishionerData>();


            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "ListParishionerData";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DataType", dataType);
                command.Parameters.AddWithValue("@ParishionerId", parishId);
                var rdr = command.ExecuteReader();

                while (rdr != null && rdr.Read())
                {
                    var reg = new ParishionerData();
                    reg.Data = (string)rdr["Data"];
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
        }


    }

}
