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
    public class CashMovement
    {
        public int Id { get; set; }

        public Category _category;
        public float Value { get; set; }
        public DateTime CashMovementDate { get; set; }
        public string Observation { get; set; }
        public Users _users;
        public float Total { get; set; }

        public CashMovement()
        {
            _category = new Category();
            _users = new Users();
        }

        public List<CashMovement> Listar(DateTime CMD1, DateTime CMD2)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            var List = new List<CashMovement>();
            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "ListCashMovementByDate";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Date1", CMD1);
                command.Parameters.AddWithValue("@Date2", CMD2);
                var rdr = command.ExecuteReader();
                while (rdr != null && rdr.Read())
                {
                    var reg = new CashMovement();
                    reg.Id = (int)rdr["Id"];
                    reg.CashMovementDate = (DateTime)rdr["Fecha"];
                    reg._category.Name = (string)rdr["Detalle"];
                    reg.Value = float.Parse(rdr["Valor"].ToString());
                    reg._category._categoryType.Name = (string)rdr["Tipo de movimiento"];
                    reg._users.Nick = (string)rdr["Usuario"];
                    reg._category.Id = int.Parse(rdr["cId"].ToString());
                    reg._category._categoryType.Id = int.Parse(rdr["ctId"].ToString());
                    reg._users.Id = int.Parse(rdr["uId"].ToString());
                    reg.Observation = (string)rdr["Observacion"];
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

        public List<CashMovement> ListByDateAndCategoryType(DateTime CMD1, DateTime CMD2, int categoryType)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            var List = new List<CashMovement>();
            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "ListCashMovementByDateAndCategoryType";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Date1", CMD1);
                command.Parameters.AddWithValue("@Date2", CMD2);
                command.Parameters.AddWithValue("@CategoryTypeId", categoryType);
                var rdr = command.ExecuteReader();
                while (rdr != null && rdr.Read())
                {
                    var reg = new CashMovement();
                    reg.Id = (int)rdr["Id"];
                    reg.CashMovementDate = (DateTime)rdr["Fecha"];
                    reg._category.Name = (string)rdr["Detalle"];
                    reg.Value = float.Parse(rdr["Valor"].ToString());
                    reg._category._categoryType.Name = (string)rdr["Tipo de movimiento"];
                    reg._users.Nick = (string)rdr["Usuario"];
                    reg._category.Id = int.Parse(rdr["cId"].ToString());
                    reg._category._categoryType.Id = int.Parse(rdr["ctId"].ToString());
                    reg._users.Id = int.Parse(rdr["uId"].ToString());
                    reg.Observation = (string)rdr["Observacion"];
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

        public List<CashMovement> ListByDateAndCategory(DateTime CMD1, DateTime CMD2, int categoryId)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            var List = new List<CashMovement>();
            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "ListCashMovementByDateAndCategory";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Date1", CMD1);
                command.Parameters.AddWithValue("@Date2", CMD2);
                command.Parameters.AddWithValue("@CategoryId", categoryId);
                var rdr = command.ExecuteReader();
                while (rdr != null && rdr.Read())
                {
                    var reg = new CashMovement();
                    reg.Id = (int)rdr["Id"];
                    reg.CashMovementDate = (DateTime)rdr["Fecha"];
                    reg._category.Name = (string)rdr["Detalle"];
                    reg.Value = float.Parse(rdr["Valor"].ToString());
                    reg._category._categoryType.Name = (string)rdr["Tipo de movimiento"];
                    reg._users.Nick = (string)rdr["Usuario"];
                    reg._category.Id = int.Parse(rdr["cId"].ToString());
                    reg._category._categoryType.Id = int.Parse(rdr["ctId"].ToString());
                    reg._users.Id = int.Parse(rdr["uId"].ToString());
                    reg.Observation = (string)rdr["Observacion"];
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

        public bool NewCashMovement(CashMovement CM)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "NewCashMovement";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CategoryId", CM._category.Id);
                command.Parameters.AddWithValue("@Value", CM.Value);
                command.Parameters.AddWithValue("@CashMovementDate", CM.CashMovementDate);
                command.Parameters.AddWithValue("@Observation", CM.Observation);
                command.Parameters.AddWithValue("@UserId", CM._users.Id);
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
            int id=0;
                try
                {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "SELECT MAX(Id) Id FROM CashMovement";
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

        public bool UpdateCashMovementDescription(int Id, string Observation)
        {
            var conn = new SqlConnection();
            var command = new SqlCommand();
            var dataBase = new DBConnect();
            bool answ;

            try
            {
                conn = dataBase.Open();
                command.Connection = conn;
                command.CommandText = "UpdateCashMovementDescription";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@Observation", Observation);
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