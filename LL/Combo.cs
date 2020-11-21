using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace LL
{
    public static class Combo
    { 
        public static bool Combo2Campos(ComboBox combo, string campo1, string campo2, string tabla)
        {
            bool rta;
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var connect = new DBConnect();
            var sql = "select " + campo1 + " , " + campo2 + " from " + tabla + " order by '" + campo2 + "'";

            try
            {
                conn = connect.Open();
                cmd.Connection = conn;
                var cmd1 = new SqlCommand(sql, conn);

                var da = new SqlDataAdapter(cmd1);
                var ds = new DataSet();

                da.Fill(ds);

                combo.DataSource = ds.Tables[0];
                combo.DisplayMember = ds.Tables[0].Columns[1].Caption;

                rta = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el comboBox: " + ex.ToString());
                rta = false;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                }

            }

            return rta;

        }

        public static bool Combo3Campos(ComboBox combo, string campo1, string campo2, string tabla, string condicion)
        {
            bool rta;
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var connect = new DBConnect();
            var sql = "select " + campo1 + " , " + campo2 + " from " + tabla + condicion + " order by '" + campo2 + "'";

            try
            {
                conn = connect.Open();
                cmd.Connection = conn;
                var cmd1 = new SqlCommand(sql, conn);

                var da = new SqlDataAdapter(cmd1);
                var ds = new DataSet();

                da.Fill(ds);

                combo.DataSource = ds.Tables[0];
                combo.DisplayMember = ds.Tables[0].Columns[0].Caption;

                rta = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el comboBox: " + ex.ToString());
                rta = false;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                }

            }

            return rta;

        }

    }
}

