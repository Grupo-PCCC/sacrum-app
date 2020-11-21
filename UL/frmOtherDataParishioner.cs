using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LL;

namespace UL
{
    public partial class frmOtherDataParishioner : Form
    {
        public string titulo;
        public string action;
        public ParishionerData _parishionerData;
        public string selectedData;
        public Log L;
        frmDataParishioners owner;
        public frmOtherDataParishioner(string action, frmDataParishioners _owner)
        {
            InitializeComponent();
            titulo = action;
            _parishionerData = new ParishionerData();
            L = new Log();
            action = "";
            owner = _owner;
        }

        private void FrmOtherDataParishioner_Load(object sender, EventArgs e)
        {
            if (selectedData is null)
            {
                btnModifyData.Enabled = false;
                btnDeleteData.Enabled = false;
            }
            if (titulo == "telefono")
            {
                this.Text = "Teléfonos";
                lblDataType.Text = "tel";
                action = "nuevotelefono";
            }
            if (titulo == "direccion")
            {
                this.Text = "Dirección";
                lblDataType.Text = "address";
                action = "nuevadireccion";
            }
            LoadListBox();
        }

        public void LoadListBox()
        {
            string DateType = lblDataType.Text;
            lbData.Items.Clear();

            var PD = _parishionerData.Listar(DateType, 1);

            foreach (ParishionerData x in PD)
            {
                lbData.Items.Add(x.Data);
            }
        }

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            if (titulo == "catingresos")
            {
                string emptyCategory = "";
                action = "nuevotipodeingreso";
                frmNewCategory FNC = new frmNewCategory(action, emptyCategory, this);
                FNC.ShowDialog();

            }
            else
            {
                string emptyCategory = "";
                action = "nuevotipodeegreso";
                frmNewCategory FNC = new frmNewCategory(action, emptyCategory, this);
                FNC.ShowDialog();
            }
        }

        private void BtnRemoveCategory_Click(object sender, EventArgs e)
        {
            selectedData = lbData.SelectedItem.ToString();
            int categoryId = _parishionerData.GetDataId(selectedData);
            bool IsCategoryInCashMovement = _parishionerData.FindCategoryInCashMovement(categoryId);
            if (IsCategoryInCashMovement == false)
            {
                _parishionerData.DeleteCategory(categoryId);
                MessageBox.Show("Se ha eliminado la categoría " + "'" + selectedData + "'", "Categoría", MessageBoxButtons.OK, MessageBoxIcon.Information);
                L.Action = "El usuario " + Users.CacheUser.Nick + " eliminó la categoría " + "'" + selectedData + "'" + "(" + categoryId + ")";
                L.ActionDate = DateTime.Now;
                L._users.Id = Users.CacheUser.Id;
                L.WriteLog(L);
                LoadListBox();
            }
            else
            {
                MessageBox.Show("No se puede eliminar la categoría " + "'" + selectedData + "'" + " porque está asociada a uno o más movimientos", "Eliminar categoría", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void BtnModifyCategory_Click(object sender, EventArgs e)
        {
            selectedData = lbData.SelectedItem.ToString();
            int dataId = _parishionerData.GetDataId(selectedData);
            if (titulo == "catingresos")
            {
                action = "modifyingresscategory";
                frmNewDataParishioner FNC = new frmNewDataParishioner(action, selectedData, this);
                FNC.Show();
            }
            else if (titulo == "categresos")
            {
                action = "modifyegresscategory";
                frmNewDataParishioner FNC = new frmNewDataParishioner(action, selectedData, this);
                FNC.Show();
            }
        }

        private void LbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbData.SelectedItem == null)
            {
                return;
            }

            selectedData = lbData.SelectedItem.ToString();
            if (selectedData is null)
            {
                btnModifyData.Enabled = false;
                btnDeleteData.Enabled = false;
            }
            else
            {
                btnModifyData.Enabled = true;
                btnDeleteData.Enabled = true;
            }
        }

        private void FindParishionerData()
        {
            lbData.Items.Clear();
            string dateType = lblDataType.Text;
            var PD = _parishionerData.Listar(dateType, 1);

            foreach (ParishionerData x in PD)
            {
                lbData.Items.Add(x.Data);
            }
        }


        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            if (!Regex.Match(owner.titulo, "nuev*").Success)
            {
                owner.lblAction.Text = "Nuevo ingreso";
                this.Text = "Nuevo ingreso";
            }
            else
            {
                owner.lblAction.Text = "Nuevo egreso";
                this.Text = "Nuevo egreso";
            }
            if (owner.cbCategory.Items.Count == 0)
            {
                owner.btnAccept.Enabled = false;
            }
            else
            {
                owner.btnAccept.Enabled = true;
            }
            */
        }

        

        private void BtnAddData_Click(object sender, EventArgs e)
        {

        }
    }
}