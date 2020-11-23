using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using SpreadsheetLight;
using LL;

namespace UL
{
    public partial class frmLog : Form
    {
        public Log L;
        public frmLog()
        {
            InitializeComponent();
            L = new Log();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            if (chbUsers.Checked == true && txtBuscar.Text=="")
            {
                LoadDgvByDate();
            }

            if (chbUsers.Checked == true && txtBuscar.Text != "")
            {
                LoadDgvByDateAndChain();
            }

            if (chbUsers.Checked == false && txtBuscar.Text == "")
            {
                LoadDgvByDateAndUser();
            }

            if (chbUsers.Checked == false && txtBuscar.Text != "")
            {
                LoadDgvByDateUserAndChain();
            }


        }

        public void LoadDgvByDate()
        {
            DateTime Date1 = dtPicker1.Value.Date;
            DateTime Date2 = dtPicker2.Value.Date;
            dgvLog.Rows.Clear();
            var _l = L.ListLogByDate(Date1,Date2);
            foreach (Log x in _l)
            {
                dgvLog.Rows.Add(x.ActionDate, x.Action,x._users.Nick) ;
            }
            Lbl_Filas.Text = "Registros: " + Convert.ToString(dgvLog.Rows.Count);
        }

        public void LoadDgvByDateAndUser()
        {
            DateTime Date1 = dtPicker1.Value.Date;
            DateTime Date2 = dtPicker2.Value.Date;
            int userId = Convert.ToInt32(((DataRowView)cbUsers.SelectedItem)["Id"]);
            dgvLog.Rows.Clear();
            var _l = L.ListLogByDateAndUser(Date1, Date2,userId);
            foreach (Log x in _l)
            {
                dgvLog.Rows.Add(x.ActionDate, x.Action, x._users.Nick);
            }
            Lbl_Filas.Text = "Registros: " + Convert.ToString(dgvLog.Rows.Count);
        }

        public void LoadDgvByDateAndChain()
        {
            DateTime Date1 = dtPicker1.Value.Date;
            DateTime Date2 = dtPicker2.Value.Date;
            string chain = txtBuscar.Text;
            dgvLog.Rows.Clear();
            var _l = L.ListLogByDateAndChain(Date1, Date2, chain);
            foreach (Log x in _l)
            {
                dgvLog.Rows.Add(x.ActionDate, x.Action, x._users.Nick);
            }
            Lbl_Filas.Text = "Registros: " + Convert.ToString(dgvLog.Rows.Count);
        }

        public void LoadDgvByDateUserAndChain()
        {
            DateTime Date1 = dtPicker1.Value.Date;
            DateTime Date2 = dtPicker2.Value.Date;
            int userId = Convert.ToInt32(((DataRowView)cbUsers.SelectedItem)["Id"]);
            string chain = txtBuscar.Text;
            dgvLog.Rows.Clear();
            var _l = L.ListLogByDateUserAndChain(Date1, Date2, userId,chain);
            foreach (Log x in _l)
            {
                dgvLog.Rows.Add(x.ActionDate, x.Action, x._users.Nick);
            }
            Lbl_Filas.Text = "Registros: " + Convert.ToString(dgvLog.Rows.Count);
        }

        private void FrmLog_Load(object sender, EventArgs e)
        {
            dtPicker1.Value = DateTime.Now.Date;
            dtPicker2.Value = DateTime.Now.Date;
            chbUsers.Checked = true;
            cbUsers.Enabled = false;

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChbUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (chbUsers.Checked == false)
            {
                cbUsers.Enabled = true;
                Combo.Combo2Campos(cbUsers, "Id", "Nick","Users");
            }
            else
            {
                cbUsers.DataSource = null;
                cbUsers.Items.Clear();
                cbUsers.Enabled = false;
            }
        }
        private void BtnExcel_Click(object sender, EventArgs e)
        {
            if (dgvLog.Rows.Count > 0)
            {

                SLDocument sl = new SLDocument();
                SLStyle style = new SLStyle();
                style.Font.FontSize = 14;
                style.Font.Bold = true;
                sl.SetCellValue(1, 1, "Fecha y hora");
                sl.SetCellStyle(1, 1, style);
                sl.SetCellValue(1, 2, "Acción");
                sl.SetCellStyle(1, 2, style);
                sl.SetCellValue(1, 3, "Usuario");
                sl.SetCellStyle(1, 3, style);

                int iR = 2;
                foreach (DataGridViewRow row in dgvLog.Rows)
                {
                    sl.SetCellValue(iR, 1, row.Cells[0].Value.ToString());
                    sl.SetCellValue(iR, 2, row.Cells[1].Value.ToString());
                    sl.SetCellValue(iR, 3, row.Cells[2].Value.ToString());
                    iR++;
                }
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "Guardar archivo";
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "xlsx";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        sl.SaveAs(saveFileDialog1.FileName);
                        MessageBox.Show("Archivo exportado con éxito", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay resultados para exportar a Excel.\nPor favor, realice una búsqueda que arroje resultados.", "No hay resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
