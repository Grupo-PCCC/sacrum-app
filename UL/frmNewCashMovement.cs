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
    public partial class frmNewCashMovement : Form
    {
        public string titulo;
        public string action;
        public CashMovement CM;
        public Log L;
        public Category C;
        public frmCashMovement _owner;
        public frmNewCashMovement(string _action, frmCashMovement owner)
        {
            InitializeComponent();
            titulo = _action;
            CM = new CashMovement();
            L = new Log();
            C = new Category();
            _owner = owner;
        }

        private void CargaCacheUser()
        {
            lblUserId.Text = Users.CacheUser.Id.ToString();
        }
        private void FrmNewCashMovement_Load(object sender, EventArgs e)
        {
            CargaCacheUser();
            dtPicker1.Value = DateTime.Now.Date;
            if (titulo == "nuevoingreso") 
            {
                lblAction.Text = "Nuevo ingreso";
                Combo.Combo3Campos(cbCategory, "Name", "Id", "Category", " WHERE CategoryTypeId=1");
                this.Text = "Nuevo ingreso";
            }
            else 
            {
                lblAction.Text = "Nuevo egreso";
                Combo.Combo3Campos(cbCategory, "Name", "Id", "Category", " WHERE CategoryTypeId=2");
                this.Text = "Nuevo egreso";
            }
            if (cbCategory.Items.Count == 0)
            {
                btnAccept.Enabled = false;
            }
        }

        private void BtnNewCategory_Click(object sender, EventArgs e)
        {
            if (titulo=="nuevoingreso")
            {
                action = "catingresos";
                frmCategory FC = new frmCategory(action,this);
                FC.ShowDialog();
            }
            else
            {
                action = "categresos";
                frmCategory FC = new frmCategory(action,this);
                FC.ShowDialog();
            }
        }
        private void BtnAccept_Click_1(object sender, EventArgs e)
        {
            if (txtValue.Text == "0,00" || txtValue.Text=="") 
            {
                txtValue.Focus();
                Error.SetError(txtValue, "El valor ingresado no es correcto.");
            }
            else
            {
                CM._category.Id = Convert.ToInt32(((DataRowView)cbCategory.SelectedItem)["Id"]);
                CM.Value = float.Parse(txtValue.Text.ToString());
                CM.CashMovementDate = dtPicker1.Value;
                CM.Observation = txtObservation.Text;
                CM._users.Id = Convert.ToInt32(lblUserId.Text.ToString());
                CM.NewCashMovement(CM);
                MessageBox.Show("Se ha guardado el movimiento.", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtPicker1.Value = DateTime.Now;
                Error.Clear();
                txtValue.Text = "";
                txtObservation.Text = "";
                if (titulo == "nuevoingreso")
                {
                    L.Action = "El usuario " + Users.CacheUser.Nick + " registró el movimiento de tipo ingreso, categoría " + C.GetCategoryName(CM._category.Id) + "(" + CM._category.Id + ")" + " de valor $" + CM.Value + ". Id del movimiento: " + CM.GetLastId();
                    L.ActionDate = DateTime.Now;
                    L._users.Id = Users.CacheUser.Id;
                    L.WriteLog(L);
                }
                else
                {
                    L.Action = "El usuario " + Users.CacheUser.Nick + " registró el movimiento de tipo egreso, categoría " + C.GetCategoryName(CM._category.Id) + "(" + CM._category.Id + ")" + " de valor $" + CM.Value + ". Id del movimiento: " + CM.GetLastId();
                    L.ActionDate = DateTime.Now;
                    L._users.Id = Users.CacheUser.Id;
                    L.WriteLog(L);
                }

                Error.Clear();
            }
            
                

            
        }

        private void CbCategory_Click(object sender, EventArgs e)
        {
            if (titulo == "nuevoingreso")
            {
                Combo.Combo3Campos(cbCategory, "Name", "Id", "Category", " WHERE CategoryTypeId=1");
                this.Text = "Nuevo ingreso";
            }
            else
            {
                Combo.Combo3Campos(cbCategory, "Name", "Id", "Category", " WHERE CategoryTypeId=2");
                this.Text = "Nuevo gasto";
            }
        }

        private void TxtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            char ch = e.KeyChar;
            if(ch==44 && txtValue.Text.IndexOf(",") != -1)
            {
                e.Handled = true;
                return;
            }
            if(!char.IsDigit(ch) && ch !=8 && ch !=44)
            {
                e.Handled = true;
            }

    */


           
        }

        private void TxtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtValue_TextChanged(object sender, EventArgs e)
        {
            /*if (txtValue.Text == "")
            {
                btnAccept.Enabled = false;
            }
            else
            {
                btnAccept.Enabled = true;
            }
            */
        }

        private void FrmNewCashMovement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_owner.dgvCashMovement.Rows.Count > 0)
            {
                if (_owner.chbIngress.Checked == false && _owner.chbEgress.Checked == false)
                {
                    _owner.LoadDgvByDate();
                    _owner.dgvCashMovement.ClearSelection();
                    _owner.categoryType = 0;
                    _owner.dgvCashMovement.Rows[_owner.dgvCashMovement.Rows.Count - 1].Selected = true;
                }

                if ((_owner.chbIngress.Checked == true || _owner.chbEgress.Checked == true) && _owner.chbCategory.Checked == true)
                {
                    _owner.LoadDgvByDateAndCategoryType();
                    _owner.dgvCashMovement.ClearSelection();
                    _owner.dgvCashMovement.Rows[_owner.dgvCashMovement.Rows.Count - 1].Selected = true;
                }

                if ((_owner.chbIngress.Checked == true || _owner.chbEgress.Checked == true) && _owner.chbCategory.Checked == false)
                {
                    _owner.LoadDgvByDateAndCategory();
                    _owner.dgvCashMovement.ClearSelection();
                    _owner.dgvCashMovement.Rows[_owner.dgvCashMovement.Rows.Count - 1].Selected = true;
                }
            }
        }

        private void DtPicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dtPicker1.Value > DateTime.Now.Date)
            {
                Error.SetError(dtPicker1, "La fecha elegida: " + dtPicker1.Value.Date.ToShortDateString() + " es mayor a la actual");
                dtPicker1.Value = DateTime.Now.Date;
            }
            
        }

        private void DtPicker1_Enter(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void DtPicker1_Leave(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void DtPicker1_MouseEnter(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void TxtValue_Enter(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void TxtValue_Leave(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void TxtValue1_TextChanged(object sender, EventArgs e)
        {
            /*if (txtValue.Text == "")
            {
                btnAccept.Enabled = false;
            }
            else
            {
                btnAccept.Enabled = true;
            }
            */
        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.Items.Count == 0)
            {
                btnAccept.Enabled = false;
            }
            else
            {
                btnAccept.Enabled = true;
            }
        }

        private void TxtValue_TextChanged_1(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void TxtValue_Leave_1(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void TxtValue_Enter_1(object sender, EventArgs e)
        {
            Error.Clear();
        }
    }
}