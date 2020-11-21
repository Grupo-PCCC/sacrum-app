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
    public class ProviderData
    {
        public int IdTel;
        public int IdAddress;
        public int IdMail;
        public string Telephone;
        public string Address;
        public string Mail;

        public bool NewProviderData(string dataType, int provId, string data, int isPrincipal)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "NewProviderData";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DataType", dataType);
                command.Parameters.AddWithValue("@ParishionerId", provId);
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

        public bool UpdateProviderData(int phoneId, string number)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "UpdateProviderData";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", phoneId);
                command.Parameters.AddWithValue("@Number", number);
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