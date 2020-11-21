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
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CategoryType _categoryType;

        public Category()
        {
            _categoryType = new CategoryType();
        }

        public bool NewCategory(Category C)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "NewCategory";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", C.Name);
                command.Parameters.AddWithValue("@CategoryTypeId", C._categoryType.Id);
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
        public bool UpdateCategory(Category C)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "UpdateCategory";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", C.Name);
                command.Parameters.AddWithValue("Id", C.Id);
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
        public bool DeleteCategory(int C)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "DeleteCategory";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Id", C);
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
        public bool FindCategory(string C)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "FindCategory";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", C);
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

        public bool FindCategoryInCashMovement(int C)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "FindCategoryInCashMovement";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CategoryId", C);
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


        public string GetCategoryName(int C)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            string categoryName="";
            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "SELECT Name FROM Category WHERE Id="+C;
                var scl = command.ExecuteScalar();
                categoryName = Convert.ToString(scl);
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
            return categoryName;
        }

        public List<Category> List(int C)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            var List = new List<Category>();
            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "ListCategory";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CategoryTypeId", C);
                var rdr = command.ExecuteReader();
                while (rdr != null && rdr.Read())
                {
                    var reg = new Category();
                    reg.Id = int.Parse(rdr["Id"].ToString());
                    reg.Name = (string)rdr["Name"];
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

        public int GetCategoryId(string C)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            int id = 0;
            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "SELECT Id FROM Category WHERE Name="+"'"+C+"'";
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

        public List<Category> Listar(string Name, int categoryTypeId)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            var Lista = new List<Category>();


            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "ListCategories";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@CategoryTypeId", categoryTypeId);
                var rdr = command.ExecuteReader();

                while (rdr != null && rdr.Read())
                {
                    var reg = new Category();
                    reg.Name = (string)rdr["Name"];
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