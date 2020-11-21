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
    public partial class frmDataProvider : Form
    {
        public int flag;
        public Provider P;
        public ProviderData PD;
        public Log L;
        public string Action;
        public int provId;
        public int telephoneId;
        public int addressId;
        public int mailId;
        frmProviders _owner;
        public int flag2;
        public frmDataProvider(string action, frmProviders owner)
        {
            InitializeComponent();
            flag = 0;
            flag2 = 0;
            P = new Provider();
            PD = new ProviderData();
            L = new Log();
            Action = action;
            provId = 0;
            telephoneId = 0;
            addressId = 0;
            mailId = 0;
            _owner = owner;
        }

        private void FrmDataProvider_Load(object sender, EventArgs e)
        {
            if (Action == "NewProvider")
            {
                this.Text = "Nuevo proveedor";
            }
            else
            {
                this.Text = "Modificar proveedor";
            }
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (Action == "NewProvider")
            {
                if (txtName.Text.Trim() == "")
                {
                    flag = 0;
                    Error.SetError(txtName, "Debe ingresar un nombre/razón social.");
                }
                else
                {
                    flag = 1;
                }
                if (flag == 1)
                {
                    P.BusinessName = txtName.Text.ToString();
                    P.Observation = txtObservation.Text.ToString();
                    P.NewProvider(P);
                    int lastProvider = P.GetLastId();
                    PD.NewProviderData("tel", lastProvider, txtTelephone.Text.ToString(), 1);
                    PD.NewProviderData("address", lastProvider, txtAddress.Text.ToString(), 1);
                    PD.NewProviderData("mail", lastProvider, txtMail.Text.ToString(), 1);
                    L.Action = "El usuario " + Users.CacheUser.Nick + " registró el proveedor " + txtName.Text + " " +  " (" + lastProvider.ToString() + ").";
                    L.ActionDate = DateTime.Now;
                    L._users.Id = Users.CacheUser.Id;
                    L.WriteLog(L);
                    MessageBox.Show("Se han ingresado los datos del proveedor correctamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Clear();
                    txtTelephone.Clear();
                    txtMail.Clear();
                    txtObservation.Clear();
                    txtObservation.Clear();
                    _owner.CargarGrilla();
                    _owner.dgvProvider.Rows[_owner.dgvProvider.Rows.Count - 1].Selected = true;

                }
            }
            if (Action == "ModifyProvider")
            {
                if (txtName.Text.Trim() == "")
                {
                    flag = 0;
                    Error.SetError(txtName, "Debe ingresar un nombre/razón social.");
                }
                else
                {
                    flag = 1;
                }
                if (flag == 1)
                {
                    P.Id = provId;
                    P.BusinessName = txtName.Text.ToString();
                    P.Observation = txtObservation.Text.ToString();
                    P.UpdateProvider(P);
                    PD.UpdateProviderData(telephoneId, txtTelephone.Text.ToString());
                    PD.UpdateProviderData(addressId, txtTelephone.Text.ToString());
                    PD.UpdateProviderData(mailId, txtTelephone.Text.ToString());
                    L.Action = "El usuario " + Users.CacheUser.Nick + " modificó el proveedor " + txtName.Text + " " + " (" + provId.ToString() + ").";
                    L.ActionDate = DateTime.Now;
                    L._users.Id = Users.CacheUser.Id;
                    L.WriteLog(L);
                    MessageBox.Show("Se han actualizado los datos del proveedor correctamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _owner.CargarGrilla();
                    this.Close();


                }
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDataProvider_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Action == "NewProvider")
            {
                if (txtName.Text != "")
                {
                    DialogResult answ = MessageBox.Show("Los datos completados serán descartados. \n¿Desea cancelar la operación?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answ == DialogResult.Yes)
                    {
                        flag2 = 1;
                        e.Cancel = false;
                    }
                    else
                    {
                        flag2 = 0;
                        e.Cancel = true;
                    }
                }
            }
        }

        private void TxtName_Leave(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void TxtName_Enter(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidData.SoloLetras(e);
            if (e.Handled == true)
            {
                Error.SetError(txtName, "Se permiten letras unicamente.");
            }
            else
            {
                Error.Clear();
            }

        }
       
        private void TxtTelephone1_Enter_1(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void TxtTelephone1_Leave_1(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void TxtTelephone1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidData.SoloNumeros(e);
            if (e.Handled == true)
            {
                Error.SetError(txtTelephone, "Se permiten números unicamente.");
            }
            else
            {
                Error.Clear();
            }
        }

        private void TxtTelephone2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidData.SoloNumeros(e);
            if (e.Handled == true)
            {
                Error.SetError(txtTelephone, "Se permiten números unicamente.");
            }
            else
            {
                Error.Clear();
            }
        }
    

        private void TxtTelephone2_Leave_1(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void TxtTelephone2_Enter_1(object sender, EventArgs e)
        {
            Error.Clear();
        }
    }
}
