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
    public partial class frmDataParishioners : Form
    {
        public int flag;
        public Parishioner P;
        public ParishionerData PD;
        public Log L;
        public string Action;
        public int parishId;
        public int telephoneId;
        public int addressId;
        public int mailId;
        frmParishioners _owner;
        frmActivities _owner2;
        public int flag2;
        public string documento;
        public bool validParish;
        public string oldDocument;
        public frmDataParishioners(string action, frmParishioners owner, frmActivities owner2)
        {
            InitializeComponent();
            flag = 0;
            flag2 = 0;
            P = new Parishioner();
            PD = new ParishionerData();
            L = new Log();
            Action = action;
            parishId = 0;
            telephoneId = 0;
            addressId = 0;
            mailId = 0;
            _owner = owner;
            _owner2 = owner2;

        }
        private void BtnAccept_Click(object sender, EventArgs e)
        {
            flag = 0;
            if (Action == "NewParish")
            {
                if (txtName.Text.Trim() != "")
                {

                    if (txtSurname.Text.Trim() != "")
                    {
                        P.Name = txtName.Text.ToString();
                        P.Surname = txtSurname.Text.ToString();
                        if (chbDateTime.Checked == true)
                        {
                            P.BirthDate = dtBornDate.Value;
                        }
                        else
                        {
                            P.BirthDate = null;
                        }
                        if (txtDocumento.Text.Trim() != "")
                        {
                            documento = txtDocumento.Text.Trim();
                            validParish = P.FindParishioner(documento);
                            if (validParish == true)
                            {
                                Error.SetError(txtDocumento, "Ya existe un feligrés con el documento " + "'" + documento + "'.");
                                txtDocumento.Clear();
                                txtDocumento.Focus();
                                return;
                            }
                        }
                        else
                        {
                            P.Documento = txtDocumento.Text.ToString();
                            P.Observation = txtObservation.Text.ToString();
                            P.NewParishioner(P);
                            int lastParish = P.GetLastId();
                            PD.NewParishionerData("tel", lastParish, txtTelephone.Text.ToString(), 1);
                            PD.NewParishionerData("address", lastParish, txtAddress.Text.ToString(), 1);
                            PD.NewParishionerData("mail", lastParish, txtMail.Text.ToString(), 1);
                            L.Action = "El usuario " + Users.CacheUser.Nick + " registró el feligrés " + txtName.Text + " " + txtSurname.Text + " (" + lastParish.ToString() + ").";
                            L.ActionDate = DateTime.Now;
                            L._users.Id = Users.CacheUser.Id;
                            L.WriteLog(L);
                            MessageBox.Show("Se han ingresado los datos del feligrés correctamente", "Registro de feligrés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtName.Clear();
                            txtSurname.Clear();
                            txtDocumento.Clear();
                            dtBornDate.Value = DateTime.Now;
                            Error.Clear();
                            txtTelephone.Clear();
                            txtMail.Clear();
                            txtObservation.Clear();
                            _owner.CargarGrilla();
                            _owner2.CargarGrilla();
                            _owner.dgv_Parish.Rows[_owner.dgv_Parish.Rows.Count - 1].Selected = true;
                        }
                    }
                    else
                    {
                        Error.SetError(txtSurname, "Debe ingresar un apellido");
                    }
                }
                else
                {
                    Error.SetError(txtName, "Debe ingresar un Nombre");

                }

            }

            if (Action == "ModifyParish")
            {

                if (txtName.Text.Trim() == "" && flag == 0)
                {
                    Error.SetError(txtName, "Debe ingresar un nombre.");
                    flag = 1;
                }
                else if (txtSurname.Text.Trim() == "" && flag == 0)
                {
                    Error.SetError(txtSurname, "Debe ingresar un apellido.");
                    flag = 1;
                }

                }
                if (flag==0)
                {
                    documento = txtDocumento.Text.Trim().ToString();
                    if (oldDocument == documento)
                    {
                        flag = 0;
                    }
                    else
                    {
                        documento = txtDocumento.Text.Trim().ToString();
                        validParish = P.FindParishioner(documento);
                        if (validParish == true)
                        {
                            Error.SetError(txtDocumento, "Ya existe un feligrés con el documento " + "'" + documento + "'.");
                            txtDocumento.Clear();
                            txtDocumento.Focus();
                            flag = 1;
                        }
                    }
                    if (validParish == false && flag == 0)
                    {
                        P.Id = parishId;
                        P.Name = txtName.Text.ToString();
                        P.Surname = txtSurname.Text.ToString();
                        if (chbDateTime.Checked == true)
                        {
                            P.BirthDate = dtBornDate.Value;
                        }
                        else
                        {
                            P.BirthDate = null;
                        }
                        P.Documento = txtDocumento.Text.ToString();
                        P.Observation = txtObservation.Text.ToString();
                        P.UpdateParishioner(P);
                        PD.UpdateParishionerData(telephoneId, txtTelephone.Text.ToString());
                        PD.UpdateParishionerData(addressId, txtAddress.Text.ToString());
                        PD.UpdateParishionerData(mailId, txtMail.Text.ToString());
                        L.Action = "El usuario " + Users.CacheUser.Nick + " modificó el feligrés " + txtName.Text + " " + txtSurname.Text + " (" + parishId.ToString() + ").";
                        L.ActionDate = DateTime.Now;
                        L._users.Id = Users.CacheUser.Id;
                        L.WriteLog(L);
                        MessageBox.Show("Se han actualizado los datos del feligrés correctamente", "Registro de feligrés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _owner.CargarGrilla();
                        Combo.Combo2Campos(_owner2.cbActivity, "Id", "Name", "Activity");
                        _owner2.CargarGrilla();
                        this.Close();
                    }
                }

            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDataParishioners_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Action == "NewParish")
            {
                if (txtName.Text != "" || txtSurname.Text != "")
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
        private void FrmDataParishioners_Load(object sender, EventArgs e)
        {

            txtName.Focus();
            if (Action == "NewParish")
            {
                this.Text = "Nuevo feligrés";
                chbDateTime.Checked = false;
                EnableDateTime();
            }
            else
            {
                this.Text = "Modificar feligrés";
                if (txtDocumento.Text.Trim() != "")
                {
                    oldDocument = txtDocumento.Text.Trim();
                }
            }

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

        private void TxtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidData.SoloLetras(e);
            if (e.Handled == true)
            {
                Error.SetError(txtSurname, "Se permiten letras unicamente.");
            }
            else
            {
                Error.Clear();
            }
        }

        private void TxtName_Enter(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void TxtName_Leave(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void TxtSurname_Enter_1(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void TxtSurname_Leave(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void TxtTelephone1_Enter(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void TxtTelephone1_Leave(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void TxtTelephone1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtTelephone2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtTelephone2_Leave(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void TxtTelephone2_Enter(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void DtBornDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtBornDate.Value > DateTime.Now.Date)
            {
                Error.SetError(dtBornDate, "La fecha elegida: " + dtBornDate.Value.Date.ToShortDateString() + " es mayor a la actual");
                dtBornDate.Value = DateTime.Now.Date;
            }
        }

        private void ChbDateTime_CheckedChanged(object sender, EventArgs e)
        {
            EnableDateTime();
        }

        private void EnableDateTime()
        {
            if (chbDateTime.Checked == true)
            {
                dtBornDate.Enabled = true;
                dtBornDate.Value = DateTime.Today;
            }
            else
            {
                dtBornDate.Enabled = false;
                dtBornDate.Value = DateTime.Today;
            }
        }

        private void TxtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidData.SoloNumeros(e);
            if (e.Handled == true)
            {
                Error.SetError(txtDocumento, "Se permiten números unicamente.");
            }
            else
            {
                Error.Clear();
            }
        }

        private void BtnOtherTelephone_Click(object sender, EventArgs e)
        {

        }
    }
}