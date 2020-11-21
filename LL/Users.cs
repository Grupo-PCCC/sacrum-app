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
    public class Users
    {
        public int Id { get; set; }
        public string Nick { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int UserType { get; set; }

        public UserType _userType;
        public Users()
        {
            _userType = new UserType();
        }

        public bool NewUser(Users U)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            var encriptar = new Crypt();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "NewUser";
                command.CommandType = CommandType.StoredProcedure;
                U.Password = encriptar.GetMD5(U.Password);
                command.Parameters.AddWithValue("@Nick", U.Nick);
                command.Parameters.AddWithValue("@Password", U.Password);
                command.Parameters.AddWithValue("@Name", U.Name);
                command.Parameters.AddWithValue("@Surname", U.Surname);
                command.Parameters.AddWithValue("@UserTypeId", U._userType.Id);
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

        public bool UpdateUser(Users U)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "UpdateUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", U.Id);
                command.Parameters.AddWithValue("@Nick", U.Nick);
                command.Parameters.AddWithValue("@Name", U.Name);
                command.Parameters.AddWithValue("@Surname", U.Surname);
                command.Parameters.AddWithValue("@UserTypeId", U._userType.Id);
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
        public bool DeleteUser(int U)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "DeleteUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", U);
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

        public bool login(String Nick, String Password)
        {

            var conn = new SqlConnection();
            var command = new SqlCommand();
            var baseDatos = new DBConnect();
            var encriptar = new Crypt();
            bool rta = false;
            try
            {
                conn = baseDatos.Open();
                command.Connection = conn;
                command.CommandText = "SelectUser";
                command.CommandType = CommandType.StoredProcedure;
                string CadenaEncriptada = encriptar.GetMD5(Password);
                command.Parameters.AddWithValue("@Nick", Nick);
                command.Parameters.AddWithValue("@Password", CadenaEncriptada);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Users.CacheUser.Id = reader.GetInt32(0);
                        Users.CacheUser.Nick = reader.GetString(1);
                        Users.CacheUser.Name = reader.GetString(3);
                        Users.CacheUser.Surname = reader.GetString(4);
                        Users.UserTypeId.TypeId = reader.GetInt32(5);

                    }
                    return true;
                }
                else
                {
                    return false;
                }


            }//TRY

            catch (Exception e)
            {
                MessageBox.Show(string.Concat(e.Message, e.StackTrace), "");
                rta = false;
            }//Fin Catch
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Dispose();

            }// Finally	

            return rta;
        }

        public int GetUserId(string U)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            int id = 0;
            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "SELECT Id FROM Users WHERE Nick=" + "'" + U + "'";
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

        public bool CheckUser(string U)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();


            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "CheckUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Nick", U);
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count == 0)
                    return false;
                else
                    return true;

            }
            catch (Exception e)
            {
                MessageBox.Show(String.Concat(e.Message, e.StackTrace), "");
                return false;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();

                }

            }

        }

        public bool UpdatePass(Users U)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            var encriptar = new Crypt();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "UpdatePass";
                command.CommandType = CommandType.StoredProcedure;
                U.Password = encriptar.GetMD5(U.Password);
                command.Parameters.AddWithValue("@Nick", U.Nick);
                command.Parameters.AddWithValue("@Password", U.Password);
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

        public List<Users> Listar(string Nick, int userId)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            var Lista = new List<Users>();


            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "ListUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Nick", Nick);
                command.Parameters.AddWithValue("@UserId", userId);
                var rdr = command.ExecuteReader();

                while (rdr != null && rdr.Read())
                {
                    var reg = new Users();
                    reg.Id = (int)rdr["Id"];
                    reg.Nick = (string)rdr["Nick"];
                    reg.Name = (string)rdr["Name"];
                    reg.Surname = (string)rdr["Surname"];
                    reg._userType.Name = (string)rdr["TipoPerfil"];


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


        public bool NewPassUser(Users U)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            var encriptar = new Crypt();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "NewPassUser";
                command.CommandType = CommandType.StoredProcedure;
                U.Password = encriptar.GetMD5(U.Password);
                command.Parameters.AddWithValue("@Nick", U.Nick);
                command.Parameters.AddWithValue("@Password", U.Password);
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

        public static class CacheUser
        {

            public static string Nick { get; set; }
            public static int Id { get; set; }
            public static string Name { get; set; }
            public static string Surname { get; set; }

        }

        public static class UserTypeId
        {
            public static int TypeId { get; set; }
        }
























































    }
}