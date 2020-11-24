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
    public partial class frmNewCategory : Form
    {
        public string titulo;
        public string categoryName;
        public int categoryType;
        public Category C;
        public Log L;
        public string oldCategory;
        public bool validCategory;
        public int flag;
        frmCategory owner;
        public frmNewCategory(string action, string selectedCategory, frmCategory _owner)
        {
            InitializeComponent();
            titulo = action;
            oldCategory = "";
            categoryName = selectedCategory;
            C = new Category();
            L = new Log();
            flag = 0;
            owner = _owner;
        }

        private void NewCategory_Load(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                btnAccept.Enabled = false;
            }
            txtName.Text = categoryName;
            if (titulo == "nuevotipodeingreso")
            {
                this.Text = "Nuevo tipo de ingreso";
                this.Text = "Nuevo tipo de ingreso";
                categoryType = 1;
            }
            if (titulo == "nuevotipodeegreso")
            {
                this.Text = "Nuevo tipo de egreso";
                this.Text = "Nuevo tipo de egreso";
                categoryType = 2;
            }
            if (titulo == "modifyingresscategory")
            {
                this.Text = "Modificar categoria";
                this.Text = "Modificar categoria";
                categoryType = 1;
                oldCategory = txtName.Text;
            }
            if (titulo == "modifyegresscategory")
            {
                this.Text = "Modificar categoria";
                this.Text = "Modificar categoria";
                categoryType = 2;
                oldCategory = txtName.Text;
            }

        }

    
        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if (titulo == "modifyingresscategory" || titulo == "modifyegresscategory")
            {
                categoryName = null;
            }
            if (txtName.Text == "")
            {
                btnAccept.Enabled = false;
            }
            else
            {
                btnAccept.Enabled = true;
            }
              
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAccept_Click_1(object sender, EventArgs e)
        {

            flag = 0;
            if (titulo == "nuevotipodeingreso" || titulo == "nuevotipodeegreso")
            {
                categoryName = txtName.Text.Trim();
                validCategory = C.FindCategory(categoryName);
                if (validCategory == true)
                {
                    MessageBox.Show("Ya existe una categoría con el nombre " + "'" + categoryName + "'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Clear();
                    txtName.Focus();
                     flag = 1;
                }
                else
                {
                    flag = 0;
                    C.Name = categoryName;
                    C._categoryType.Id = categoryType;
                    C.NewCategory(C);
                    owner.LoadListBox();
                    MessageBox.Show("Se ha guardado la categoría " + "'" + categoryName + "'.", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Clear();
                    txtName.Focus();
                    if (titulo == "nuevotipodeingreso")
                    {
                        L.Action = "El usuario " + Users.CacheUser.Nick + " registró una nueva categoría " + "'" + categoryName + "'" + " de tipo Ingreso.";
                        L.ActionDate = DateTime.Now;
                        L._users.Id = Users.CacheUser.Id;
                        L.WriteLog(L);
                    }
                    else
                    {
                        L.Action = "El usuario " + Users.CacheUser.Nick + " registró una nueva categoría " + "'" + categoryName + "'" + " de tipo Egreso.";
                        L.ActionDate = DateTime.Now;
                        L._users.Id = Users.CacheUser.Id;
                        L.WriteLog(L);
                    }
                }


            }
            else if (titulo == "modifyingresscategory" || titulo == "modifyegresscategory")
            {
                categoryName = txtName.Text.ToString();
                if (oldCategory == categoryName)
                {
                    this.Close();
                    flag = 1;
                }
                if (flag == 0)
                {
                    categoryName = txtName.Text.Trim();
                    validCategory = C.FindCategory(categoryName);
                    if (validCategory == true)
                    {
                        MessageBox.Show("Ya existe una categoría con el nombre " + "'" + categoryName + "'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtName.Clear();
                        txtName.Focus();
                        flag = 1;
                    }
                }
                if (oldCategory!=categoryName && validCategory==false)
                {
                    categoryName = txtName.Text.ToString();
                    C.Name = categoryName;
                    C.Id = C.GetCategoryId(oldCategory);
                    C.UpdateCategory(C);
                    owner.LoadListBox();
                    MessageBox.Show("Se ha actualizado la categoría " + "'" + categoryName + "'.", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    if (titulo == "modifyingresscategory")
                    {
                        L.Action = "El usuario " + Users.CacheUser.Nick + " cambió el nombre de la categoría de tipo ingreso " + "'" + oldCategory + "'" + " por: " + "'" + categoryName + "'.";
                        L.ActionDate = DateTime.Now;
                        L._users.Id = Users.CacheUser.Id;
                        L.WriteLog(L);
                    }
                    else if (titulo == "modifyegresscategory")
                    {
                        L.Action = "El usuario " + Users.CacheUser.Nick + " cambio el nombre de la categoría de tipo egreso " + "'" + oldCategory + "'" + " por: " + "'" + categoryName + "'.";
                        L.ActionDate = DateTime.Now;
                        L._users.Id = Users.CacheUser.Id;
                        L.WriteLog(L);
                    }
                }

            }
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
