using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LL;
using Excel = Microsoft.Office.Interop.Excel;
using SpreadsheetLight;
namespace UL
{
    public partial class frmCashMovement : Form
    {
        #region-Variables_Y_Constructor-
        public CashMovement _cashMovement;
        public Category _category;
        public DateTime dateNow;
        public string action;
        public string action2;
        public string action3;
        public int categoryType;
        public int categoryId;
        float ingresos = 0;
        float egresos = 0;
        float total = 0;
        public int selectedCashMovement = 0;
        public int flag = 0;
        public int oneMore = 0;
        public int count = 0;
        public int rowsCount = 0;
        public frmCashMovement()
        {
            InitializeComponent();
            _cashMovement = new CashMovement();
            _category = new Category();
            dateNow = new DateTime();

        }
        #endregion
        #region-LoadDgv_By_Date-
        public void LoadDgvByDate()
        {
            ingresos = 0;
            egresos = 0;
            total = 0;
            DateTime Date1 = dtPicker1.Value.Date;
            DateTime Date2 = dtPicker2.Value.Date;
            dgvCashMovement.Rows.Clear();
            var CM = _cashMovement.Listar(Date1, Date2);
            foreach (CashMovement x in CM)
            {
                if (x._category._categoryType.Id == 1)
                {
                    ingresos = ingresos + x.Value;

                }
                else
                    egresos = egresos + x.Value;

                dgvCashMovement.Rows.Add(x.Id,
                    x.CashMovementDate.ToString("dd/MM/yyy"), x._category.Name, x.Value.ToString("N2"), x._category._categoryType.Name, x._users.Nick, x._category.Id, x._category._categoryType.Id, x.Observation, x._users.Id);
                RowColor(dgvCashMovement);
            }

            total = ingresos - egresos;
            txtTotal.Text = "$ " + total.ToString("N2");
            Lbl_Filas.Text = "Registros: " + Convert.ToString(dgvCashMovement.Rows.Count);
        }
        #endregion
        #region-LoadDgv_By_Date_And_Category_Type-
        public void LoadDgvByDateAndCategoryType()
        {
            ingresos = 0;
            egresos = 0;
            total = 0;
            DateTime Date1 = dtPicker1.Value.Date;
            DateTime Date2 = dtPicker2.Value.Date;
            if (chbIngress.Checked == true)
            {
                categoryType = 1;
            }
            else if (chbEgress.Checked == true)
            {
                categoryType = 2;
            }

            dgvCashMovement.Rows.Clear();

            var CM = _cashMovement.ListByDateAndCategoryType(Date1, Date2, categoryType);

            foreach (CashMovement x in CM)
            {
                dgvCashMovement.Rows.Add(x.Id, x.CashMovementDate.ToString("dd/MM/yyy"), x._category.Name, x.Value.ToString("N2"), x._category._categoryType.Name, x._users.Nick, x._category.Id, x._category._categoryType.Id, x.Observation, x._users.Id);
                if (x._category._categoryType.Id == 1)
                { ingresos = ingresos + x.Value; }
                else
                { egresos = egresos + x.Value; }
                RowColor(dgvCashMovement);
            }
            if (categoryType == 1)
            {
                total = ingresos - egresos;
                txtTotal.Text = "$ " + total.ToString("N2");
            }
            else
                total = ingresos - egresos;
            txtTotal.Text = "$ " + total.ToString("N2");
        }
        #endregion
        #region-LoadDgv_By_Date_And_Category-
        public void LoadDgvByDateAndCategory()
        {
            ingresos = 0;
            egresos = 0;
            total = 0;
            DateTime Date1 = dtPicker1.Value.Date;
            DateTime Date2 = dtPicker2.Value.Date;
            categoryId = Convert.ToInt32(((DataRowView)cbCategories.SelectedItem)["Id"]);
            dgvCashMovement.Rows.Clear();
            var CM = _cashMovement.ListByDateAndCategory(Date1, Date2, categoryId);
            foreach (CashMovement x in CM)
            {
                if (x._category._categoryType.Id == 1)
                    ingresos = ingresos + x.Value;
                else
                    egresos = egresos + x.Value;
                dgvCashMovement.Rows.Add(x.Id, x.CashMovementDate.ToString("dd/MM/yyy"), x._category.Name, x.Value.ToString("N2"), x._category._categoryType.Name, x._users.Nick, x._category.Id, x._category._categoryType.Id, x.Observation, x._users.Id);
                RowColor(dgvCashMovement);
            }

            total = ingresos - egresos;
            txtTotal.Text = "$ " + total;

        }
        #endregion
        #region-RowColor-
        private void RowColor(DataGridView datagrid)

        {
              foreach (DataGridViewRow row in datagrid.Rows)
            {
                 if (Convert.ToInt32(datagrid.Rows[row.Index].Cells[7].Value) == 1)
                
                {
                    row.Cells[3].Style.ForeColor = Color.Green;
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(64, 235, 97);
                }
                else
                {
                    row.Cells[3].Style.ForeColor = Color.Red;
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 77, 34);
                }
            }
        }


        #endregion
        #region-Load-
        private void FrmCashMovement_Load(object sender, EventArgs e)
        {
            dtPicker1.Value = DateTime.Now.Date;
            dtPicker2.Value = DateTime.Now.Date;
            cbCategories.Enabled = false;
            chbCategory.Enabled = false;
            btnNewCategory.Enabled = false;
        }
        #endregion
        #region-Search_Button-
        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            if (chbIngress.Checked == false && chbEgress.Checked == false)
            {
                LoadDgvByDate();
                categoryType = 0;
            }

            if ((chbIngress.Checked == true || chbEgress.Checked == true) && chbCategory.Checked == true)
            {
                LoadDgvByDateAndCategoryType();
            }

            if ((chbIngress.Checked == true || chbEgress.Checked == true) && chbCategory.Checked == false)
            {
                LoadDgvByDateAndCategory();
            }
        }
        #endregion
        #region-New_Ingress_Button-
        private void BtnNewIngress_Click(object sender, EventArgs e)
        {
            action = "nuevoingreso";
            frmNewCashMovement NWC = new frmNewCashMovement(action,this);
            NWC.ShowDialog();
        }
        #endregion
        #region-New_Egress_Button-
        private void BtnNewEgress_Click(object sender, EventArgs e)
        {
            action = "nuevoegreso";
            frmNewCashMovement NWC = new frmNewCashMovement(action,this);
            NWC.ShowDialog();
        }
        #endregion
        #region-Only_Ingress-
        private void OnlyIngress()
        {
            if (chbIngress.Checked == true)
            {
                btnNewCategory.Enabled = true;
                chbCategory.Enabled = true;
                chbCategory.Checked = true;
                chbEgress.Enabled = false;
                Combo.Combo3Campos(cbCategories, "Name", "Id", "Category", " WHERE CategoryTypeId=1");
            }
            else
            {
                btnNewCategory.Enabled = false;
                chbCategory.Enabled = false;
                chbCategory.Checked = false;
                chbEgress.Enabled = true;
            }
        }
        #endregion
        #region-Only_Egress-
        private void OnlyEgress()
        {
            if (chbEgress.Checked == true)
            {
                btnNewCategory.Enabled = true;
                chbCategory.Enabled = true;
                chbCategory.Checked = true;
                chbIngress.Enabled = false;
                Combo.Combo3Campos(cbCategories, "Name", "Id", "Category", " WHERE CategoryTypeId=2");
            }
            else
            {
                btnNewCategory.Enabled = false;
                chbCategory.Enabled = false;
                chbCategory.Checked = false;
                chbIngress.Enabled = true;
            }
        }
        #endregion
        #region-Checbox_Changed-
        private void ChbIngress_CheckedChanged(object sender, EventArgs e)
        {
            OnlyIngress();
            if (chbIngress.Checked == false || chbEgress.Checked == false)
            {
                cbCategories.Enabled = false;
                cbCategories.DataSource = null;
                cbCategories.Items.Clear();
            }
        }

        private void ChbEgress_CheckedChanged(object sender, EventArgs e)
        {
            OnlyEgress();
            if (chbIngress.Checked == false || chbEgress.Checked == false)
            {
                cbCategories.Enabled = false;
                cbCategories.DataSource = null;
                cbCategories.Items.Clear();
            }
        }

        private void ChbCategory_CheckedChanged(object sender, EventArgs e)
        {

            if (chbCategory.Checked == true)
            {
                cbCategories.DataSource = null;
                cbCategories.Items.Clear();
            }
            if (chbIngress.Checked == true)
            {
                LoadIngressCategories();
            }
            else
            {
                LoadEgressCategories();
            }

            if (chbCategory.Checked == true)
            {
                cbCategories.Enabled = false;
            }

        }
        #endregion
        #region-Load_ComboBox_Categories-
        private void LoadIngressCategories()
        {
            if (chbCategory.Checked == false)
            {
                cbCategories.Enabled = true;
                Combo.Combo3Campos(cbCategories, "Name", "Id", "Category", " WHERE CategoryTypeId=1");
            }
        }

        private void LoadEgressCategories()
        {
            if (chbCategory.Checked == false)
            {
                cbCategories.Enabled = true;
                Combo.Combo3Campos(cbCategories, "Name", "Id", "Category", " WHERE CategoryTypeId=2");
            }
        }
        #endregion
        #region-New_Category-
        private void BtnNewCategory_Click(object sender, EventArgs e)
        {
            if (chbIngress.Checked == true)
            {
                action3 = "catingresos";
                frmNewCashMovement FNC = new frmNewCashMovement("",this);
                frmCategory FC = new frmCategory(action3,FNC);
                FC.ShowDialog();
            }
            else
            {
                action3 = "categresos";
                frmNewCashMovement FNC = new frmNewCashMovement("", this);
                frmCategory FC = new frmCategory(action3, FNC);
                FC.ShowDialog();
            }
        }
        #endregion
        #region-SearchButton-
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            oneMore = 0;
            flag = 0;
            count = 0;
            rowsCount = 0;
            if (chbIngress.Checked == false && chbEgress.Checked == false)
            {
                LoadDgvByDate();
                categoryType = 0;
                Lbl_Filas.Text = "Registros: " + Convert.ToString(dgvCashMovement.Rows.Count);
            }

            if ((chbIngress.Checked == true || chbEgress.Checked == true) && chbCategory.Checked == true)
            {
                LoadDgvByDateAndCategoryType();
                Lbl_Filas.Text = "Registros: " + Convert.ToString(dgvCashMovement.Rows.Count);
            }

            if ((chbIngress.Checked == true || chbEgress.Checked == true) && chbCategory.Checked == false && cbCategories.Items.Count==0)
            {
                LoadDgvByDateAndCategoryType();
                Lbl_Filas.Text = "Registros: " + Convert.ToString(dgvCashMovement.Rows.Count);
            }
            if ((chbIngress.Checked == true || chbEgress.Checked == true) && chbCategory.Checked == false && cbCategories.Items.Count != 0)
            {
                LoadDgvByDateAndCategory();
                Lbl_Filas.Text = "Registros: " + Convert.ToString(dgvCashMovement.Rows.Count);
            }
        }
        #endregion
        #region-SendCashMovement-
        private void SendCashMovement()
        {
            selectedCashMovement = Convert.ToInt32(dgvCashMovement.CurrentRow.Index.ToString());
            DataGridViewRow row = dgvCashMovement.Rows[selectedCashMovement];
            int cashMovementId = Convert.ToInt32(row.Cells[0].Value);
            DateTime date = DateTime.ParseExact(row.Cells[1].Value.ToString(), "dd/MM/yyyy", null);
            string movement = Convert.ToString(row.Cells[2].Value);
            decimal value = Convert.ToDecimal(row.Cells[3].Value);
            string movementType = Convert.ToString(row.Cells[4].Value);
            string userName = Convert.ToString(row.Cells[5].Value);
            string observation = Convert.ToString(row.Cells[8].Value);
            frmSelectedCashMovement FSC = new frmSelectedCashMovement(cashMovementId,this);
            FSC.txtDate.Text = date.ToShortDateString();
            FSC.txtDetail.Text = movement;
            FSC.txtValue.Text = value.ToString("N2");
            FSC.txtMovementType.Text = movementType;
            FSC.txtUser.Text = userName;
            FSC.txtObservation.Text = observation;
            FSC.ShowDialog();
        }
        #endregion
        #region-VerDetalle-
        private void DgvCashMovement_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SendCashMovement();
        }

        private void DgvCashMovement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvCashMovement.Columns[e.ColumnIndex].Name.Equals("clmViewDetail"))
            {
                SendCashMovement();
            }
        }
        #endregion
        #region-Cerrar-
        private void Btn_cerrar_Click(object sender, EventArgs e)
        {

            this.Close();

        }



        #endregion

        private void DtPicker1_ValueChanged(object sender, EventArgs e)
        {
            if(dtPicker1.Value> DateTime.Now.Date)
            {
                Error.SetError(dtPicker1, "La fecha elegida: " + dtPicker1.Value.Date.ToShortDateString() + " es mayor a la actual");
                dtPicker1.Value = DateTime.Now.Date;
            }
          
                       
        }
        private void DtPicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dtPicker2.Value > DateTime.Now.Date)
            {
                Error.SetError(dtPicker2, "La fecha elegida: " + dtPicker2.Value.Date.ToShortDateString() + " es mayor a la actual");
                dtPicker2.Value = DateTime.Now.Date;
            }
          
        }

        private void DtPicker1_MouseEnter(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void DtPicker2_MouseEnter(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void CbCategories_Click(object sender, EventArgs e)
        {
            if (chbIngress.Checked == true)
            {
                Combo.Combo3Campos(cbCategories, "Name", "Id", "Category", " WHERE CategoryTypeId=1");
            }
            if (chbEgress.Checked == true)
            {
                Combo.Combo3Campos(cbCategories, "Name", "Id", "Category", " WHERE CategoryTypeId=2");
            }
        }
        private void BtnExcel_Click(object sender, EventArgs e)
        {
            if (dgvCashMovement.Rows.Count > 0)
            {

                SLDocument sl = new SLDocument();
                SLStyle style = new SLStyle();
                style.Font.FontSize = 14;
                style.Font.Bold = true;
                sl.SetCellValue(1, 1, "Fecha");
                sl.SetCellStyle(1, 1, style);
                sl.SetCellValue(1, 2, "Categoría");
                sl.SetCellStyle(1, 2, style);
                sl.SetCellValue(1, 3, "Valor");
                sl.SetCellStyle(1, 3, style);
                sl.SetCellValue(1, 4, "Tipo de movimiento");
                sl.SetCellStyle(1, 4, style);
                sl.SetCellValue(1, 5, "Usuario");
                sl.SetCellStyle(1, 5, style);

                int iR = 2;
                foreach(DataGridViewRow row in dgvCashMovement.Rows)
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
                        MessageBox.Show("Archivo exportado con éxito", "Exportar",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}


