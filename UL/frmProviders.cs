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
    public partial class frmProviders : Form
    {
        public Provider _Provider;
        public int selectedProvider;
        public Log L;
        public frmProviders()
        {
            _Provider = new Provider();
            L = new Log();
            selectedProvider = 0;
            InitializeComponent();
        }

        public void CargarGrilla()
        {
            dgvProvider.Rows.Clear();
            var name = txtBuscar.Text.Trim();
            var l = _Provider.Listar(name);

            foreach (var X in l)
            {
                dgvProvider.Rows.Add(X.Id, X.BusinessName, X.Telephone, X.Address, X.Mail, X.Observation, X._providerData.IdTel, X._providerData.IdAddress, X._providerData.IdMail);
            }

            Lbl_Filas.Text = "Registros: " + Convert.ToString(dgvProvider.Rows.Count);
            Lbl_Filas.Visible = true;
        }

        private void FrmProviders_Load(object sender, EventArgs e)
        {
            txtBuscar.Focus();
            CargarGrilla();
            if (dgvProvider.Rows.Count == 0)
            {
                BtnDelete.Enabled = false;
                BtnModify.Enabled = false;
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
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

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void SendProvider()
        {

            frmDataProvider frm = new frmDataProvider("ModifyProvider", this);
            selectedProvider = Convert.ToInt32(dgvProvider.CurrentRow.Index.ToString());
            DataGridViewRow dgv = dgvProvider.Rows[selectedProvider];
            frm.provId = Convert.ToInt32(dgv.Cells["clmId"].Value);
            frm.txtName.Text = dgv.Cells["Nombre"].Value.ToString();
            frm.txtTelephone.Text = dgv.Cells["Telephone"].Value.ToString();
            frm.txtAddress.Text = dgv.Cells["Address"].Value.ToString();
            frm.txtMail.Text = dgv.Cells["Mail"].Value.ToString();
            frm.txtObservation.Text = dgv.Cells["clmObservation"].Value.ToString();
            frm.telephoneId = Convert.ToInt32(dgv.Cells["clmParishionerPhoneId"].Value);
            frm.addressId = Convert.ToInt32(dgv.Cells["clmParishionerAddressId"].Value);
            frm.mailId = Convert.ToInt32(dgv.Cells["clmParishionerMailId"].Value);
            frm.ShowDialog();
        }

        private void DgvProvider_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvProvider.Columns[e.ColumnIndex].Name.Equals("clmViewDetail"))
            {
                SendProvider();
            }
        }

        private void DgvProvider_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SendProvider();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmDataProvider FDP = new frmDataProvider("NewProvider", this);
            FDP.ShowDialog();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            SendProvider();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            selectedProvider = Convert.ToInt32(dgvProvider.CurrentRow.Index.ToString());
            DataGridViewRow row = dgvProvider.Rows[selectedProvider];
            int provId = Convert.ToInt32(row.Cells[0].Value);
            DialogResult answ = MessageBox.Show("¿Está seguro que desea eliminar el proveedor " + Convert.ToString(row.Cells[1].Value) + "?", "Eliminar proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answ == DialogResult.Yes)
            {
                _Provider.DeleteProvider(provId);
                CargarGrilla();
                MessageBox.Show("Se ha eliminado el proveedor " + "'" + Convert.ToString(row.Cells[1].Value) + "'", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                L.Action = "El usuario " + Users.CacheUser.Nick + " elimino el proveedor " + "'" + Convert.ToString(row.Cells[1].Value) + "'.";
                L.ActionDate = DateTime.Now;
                L._users.Id = Users.CacheUser.Id;
                L.WriteLog(L);
            }
        }

        private void Btn_cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvProvider_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            BtnDelete.Enabled = true;
            BtnModify.Enabled = true;
        }

        private void DgvProvider_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvProvider.Rows.Count == 0)
            {
                BtnDelete.Enabled = false;
                BtnModify.Enabled = false;
            }
        }
        private void BtnExcel_Click(object sender, EventArgs e)
        {
            if (dgvProvider.Rows.Count > 0)
            {

                SLDocument sl = new SLDocument();
                SLStyle style = new SLStyle();
                style.Font.FontSize = 14;
                style.Font.Bold = true;
                sl.SetCellValue(1, 1, "Nombre / Razón social");
                sl.SetCellStyle(1, 1, style);
                sl.SetCellValue(1, 2, "Teléfono");
                sl.SetCellStyle(1, 2, style);
                sl.SetCellValue(1, 3, "Dirección");
                sl.SetCellStyle(1, 3, style);
                sl.SetCellValue(1, 4, "Mail");
                sl.SetCellStyle(1, 4, style);

                int iR = 2;
                foreach (DataGridViewRow row in dgvProvider.Rows)
                {
                    sl.SetCellValue(iR, 1, row.Cells[1].Value.ToString());
                    sl.SetCellValue(iR, 2, row.Cells[2].Value.ToString());
                    sl.SetCellValue(iR, 3, row.Cells[3].Value.ToString());
                    sl.SetCellValue(iR, 4, row.Cells[4].Value.ToString());
                    sl.SetCellValue(iR, 5, row.Cells[5].Value.ToString());
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
