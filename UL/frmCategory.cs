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

namespace UL
{
    public partial class frmCategory : Form
    {
        public string titulo;
        public string action;
        public Category _category;
        public string selectedCategory;
        public Log L;
        frmNewCashMovement owner;
        public frmCategory(string action, frmNewCashMovement _owner)
        {
            InitializeComponent();
            titulo = action;
            _category = new Category();
            L = new Log();
            action = "";
            owner = _owner;
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
            if (selectedCategory is null)
            {
                btnModifyCategory.Enabled = false;
                btnRemoveCategory.Enabled = false;
            }
            if (titulo == "catingresos")
            {
                this.Text = "Categorías de ingreso";
                lblCategoryTypeId.Text = "1";
                action = "nuevotipodeingreso";

            }
            else
            {
                this.Text = "Categorías de egreso";
                lblCategoryTypeId.Text = "2";
                action = "nuevotipodeegreso";
            }
            LoadListBox();
        }

        public void LoadListBox()
        {
            int CategoryTypeId = Convert.ToInt32(lblCategoryTypeId.Text.ToString());
            lbCategory.Items.Clear();

            var C = _category.List(CategoryTypeId);

            foreach (Category x in C)
            {
                lbCategory.Items.Add(x.Name);
            }
        }

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            if (titulo == "catingresos")
            {
                string emptyCategory = "";
                action = "nuevotipodeingreso";
                frmNewCategory FNC = new frmNewCategory(action, emptyCategory,this);
                FNC.ShowDialog();

            }
            else
            {
                string emptyCategory = "";
                action = "nuevotipodeegreso";
                frmNewCategory FNC = new frmNewCategory(action, emptyCategory,this);
                FNC.ShowDialog();
            }
        }

        private void BtnRemoveCategory_Click(object sender, EventArgs e)
        {
            selectedCategory = lbCategory.SelectedItem.ToString();
            int categoryId = _category.GetCategoryId(selectedCategory);
            bool IsCategoryInCashMovement = _category.FindCategoryInCashMovement(categoryId);
            if (IsCategoryInCashMovement == false)
            {
                _category.DeleteCategory(categoryId);
                MessageBox.Show("Se ha eliminado la categoría " + "'" + selectedCategory + "'", "Categoría", MessageBoxButtons.OK, MessageBoxIcon.Information);
                L.Action = "El usuario " + Users.CacheUser.Nick + " eliminó la categoría " + "'" + selectedCategory + "'" + "(" + categoryId + ")";
                L.ActionDate = DateTime.Now;
                L._users.Id = Users.CacheUser.Id;
                L.WriteLog(L);
                LoadListBox();
            }
            else
            {
                MessageBox.Show("No se puede eliminar la categoría " + "'" + selectedCategory + "'" + " porque está asociada a uno o más movimientos", "Eliminar categoría", MessageBoxButtons.OK,MessageBoxIcon.Error);
                
                
            }
        }

        private void BtnModifyCategory_Click(object sender, EventArgs e)
        {
            selectedCategory = lbCategory.SelectedItem.ToString();
            int categoryId = _category.GetCategoryId(selectedCategory);
            bool IsCategoryInCashMovement = _category.FindCategoryInCashMovement(categoryId);
            if (IsCategoryInCashMovement == false && titulo == "catingresos")
            {
                action = "modifyingresscategory";
                frmNewCategory FNC = new frmNewCategory(action, selectedCategory,this);
                FNC.Show();
            }
            else if (IsCategoryInCashMovement == false && titulo == "categresos")
            {
                action = "modifyegresscategory";
                frmNewCategory FNC = new frmNewCategory(action, selectedCategory,this);
                FNC.Show();
            }
            else if (IsCategoryInCashMovement == true)
            {
                MessageBox.Show("No se puede modificar la categoría " + "'" + selectedCategory + "'" + " porque está asociada a uno o más movimientos", "Modificar categoría", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void LbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCategory.SelectedItem == null)
            {
                return;
            }

            selectedCategory = lbCategory.SelectedItem.ToString();
            if (selectedCategory is null)
            {
                btnModifyCategory.Enabled = false;
                btnRemoveCategory.Enabled = false;
            }
            else
            {
                btnModifyCategory.Enabled = true;
                btnRemoveCategory.Enabled = true;
            }
        }

        private void FindCategory()
        {
            lbCategory.Items.Clear();
            var name = txtSearch.Text.Trim();
            int CategoryTypeId = Convert.ToInt32(lblCategoryTypeId.Text.ToString());
            var C = _category.Listar(name, CategoryTypeId);

            foreach (Category x in C)
            {
                lbCategory.Items.Add(x.Name);
            }
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.TextLength < 3)
            {

            }
            else
            {
                FindCategory();
            }
            if (txtSearch.TextLength == 0)
            {
                FindCategory();
            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (owner.titulo == "nuevoingreso")
            {
                owner.lblAction.Text = "Nuevo ingreso";
                Combo.Combo3Campos(owner.cbCategory, "Name", "Id", "Category", " WHERE CategoryTypeId=1");
                this.Text = "Nuevo ingreso";
            }
            else
            {
                owner.lblAction.Text = "Nuevo egreso";
                Combo.Combo3Campos(owner.cbCategory, "Name", "Id", "Category", " WHERE CategoryTypeId=2");
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
        }
    }
}
