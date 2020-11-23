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
    public partial class frmActivities : Form
    {
        public Parishioner P;
        public Activity A;
        public Log L;
        public frmParishioners FP;
        public frmActivities()
        {
            InitializeComponent();
            P = new Parishioner();
            A = new Activity();
            L = new Log();
            FP = new frmParishioners();
        }

        public void FrmActivities_Load(object sender, EventArgs e)
        {
            Combo.Combo2Campos(cbActivity, "Id", "Name", "Activity");
            CheckComboItems();
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            if (cbActivity.Items.Count>0)
            {
                dgv_Activities.Rows.Clear();
                var name = txtBuscar.Text.Trim();
                int activityId = Convert.ToInt32(((DataRowView)cbActivity.SelectedItem)["Id"]);
                var l = P.ListParishByActivity(name, activityId);
                foreach (var X in l)
                {
                    dgv_Activities.Rows.Add(X.Id, X.Name, X.Surname, X.Documento, Convert.ToDateTime(X.BirthDate).ToShortDateString(), X.Telephone, X.Address, X.Mail, X.Observation, X._parishionerData.IdTel, X._parishionerData.IdAddress, X._parishionerData.IdMail);
                }
                NullDateTime(dgv_Activities);
                Lbl_Filas.Text = "Registros:" + Convert.ToString(dgv_Activities.Rows.Count);
                Lbl_Filas.Visible = true;
            }
            
        }

        private void NullDateTime(DataGridView datagrid)

        {
            foreach (DataGridViewRow row in datagrid.Rows)
            {
                if (Convert.ToString(datagrid.Rows[row.Index].Cells[4].Value) == "1/1/0001")

                {
                    datagrid.Rows[row.Index].Cells[4].Value = "";
                }
            }
        }
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CbActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void BtnActivities_Click(object sender, EventArgs e)
        {
            frmNewActivity FNA = new frmNewActivity(this);
            FNA.ShowDialog();
            CheckComboItems();
        }

        
        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            int activityId = Convert.ToInt32(((DataRowView)cbActivity.SelectedItem)["Id"]);
            frmModifyActivity FMA = new frmModifyActivity(activityId,this);
            FMA.txtName.Text = (Convert.ToString(((DataRowView)cbActivity.SelectedItem)["Name"]));
            FMA.txtDescription.Text =A.GetActivityObservation(activityId);
            FMA.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgv_Activities.Rows.Count == 0)
            {
                string categoryName= Convert.ToString(((DataRowView)cbActivity.SelectedItem)["Name"]);
                A.DeleteActivity(Convert.ToInt32(((DataRowView)cbActivity.SelectedItem)["Id"]));
                L.Action = "El usuario " + Users.CacheUser.Nick + " eliminó la actividad " + categoryName + " (" + (Convert.ToInt32(((DataRowView)cbActivity.SelectedItem)["Id"])) + ").";
                L.ActionDate = DateTime.Now;
                L._users.Id = Users.CacheUser.Id;
                L.WriteLog(L);
                Combo.Combo2Campos(cbActivity, "Id", "Name", "Activity");
                CargarGrilla();
                MessageBox.Show("Se ha eliminado la actividad " + categoryName + ".", "Actividad eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string categoryName = Convert.ToString(((DataRowView)cbActivity.SelectedItem)["Name"]);
                DialogResult answ = MessageBox.Show("La actividad " + categoryName + " tiene uno o más feligreses registrados." + "\n¿Desea eliminarla igualmente?", "Eliminar actividad", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answ == DialogResult.Yes)
                {
                    A.DeleteActivity(Convert.ToInt32(((DataRowView)cbActivity.SelectedItem)["Id"]));
                    L.Action = "El usuario " + Users.CacheUser.Nick + " eliminó la actividad " +categoryName+ " (" + (Convert.ToInt32(((DataRowView)cbActivity.SelectedItem)["Id"])) + ").";
                    L.ActionDate = DateTime.Now;
                    L._users.Id = Users.CacheUser.Id;
                    L.WriteLog(L);
                    Combo.Combo2Campos(cbActivity, "Id", "Name", "Activity");
                    CargarGrilla();
                    MessageBox.Show("Se ha eliminado la actividad " + categoryName + ".", "Actividad eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            CheckComboItems();
        }

        private void FrmActivities_Activated(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CheckComboItems()
        {
            if (cbActivity.Items.Count == 0)
            {
                BtnDelete.Enabled = false;
                BtnModify.Enabled = false;
                dgv_Activities.Rows.Clear();
            }
            else
            {
                BtnDelete.Enabled = true;
                BtnModify.Enabled = true;
            }
        }

        private void Dgv_Activities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_Activities.Columns[e.ColumnIndex].Name.Equals("clmViewDetail"))
            {
                FP.SendParish(dgv_Activities);
            }
        }

        private void TxtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBuscar.TextLength < 3)
            {

            }
            else
            {
                CargarGrilla();
            }
            if (txtBuscar.TextLength == 0)
            {
                CargarGrilla();
            }
        }

        private void Dgv_Activities_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FP.SendParish(dgv_Activities);
        }

        private void Dgv_Activities_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            BtnModify.Enabled = true;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void BtnExcel_Click(object sender, EventArgs e)
        {
            if (dgv_Activities.Rows.Count > 0)
            {

                SLDocument sl = new SLDocument();
                SLStyle style = new SLStyle();
                style.Font.FontSize = 14;
                style.Font.Bold = true;
                sl.SetCellValue(1, 1, "Nombre");
                sl.SetCellStyle(1, 1, style);
                sl.SetCellValue(1, 2, "Apellido");
                sl.SetCellStyle(1, 2, style);
                sl.SetCellValue(1, 3, "Documento");
                sl.SetCellStyle(1, 3, style);
                sl.SetCellValue(1, 4, "Fecha de nacimiento");
                sl.SetCellStyle(1, 4, style);
                sl.SetCellValue(1, 5, "Teléfono");
                sl.SetCellStyle(1, 5, style);
                sl.SetCellValue(1, 6, "Dirección");
                sl.SetCellStyle(1, 6, style);
                sl.SetCellValue(1, 7, "Mail");
                sl.SetCellStyle(1, 7, style);

                int iR = 2;
                foreach (DataGridViewRow row in dgv_Activities.Rows)
                {
                    sl.SetCellValue(iR, 1, row.Cells[1].Value.ToString());
                    sl.SetCellValue(iR, 2, row.Cells[2].Value.ToString());
                    sl.SetCellValue(iR, 3, row.Cells[3].Value.ToString());
                    sl.SetCellValue(iR, 4, row.Cells[4].Value.ToString());
                    sl.SetCellValue(iR, 5, row.Cells[5].Value.ToString());
                    sl.SetCellValue(iR, 6, row.Cells[6].Value.ToString());
                    sl.SetCellValue(iR, 7, row.Cells[7].Value.ToString());
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
