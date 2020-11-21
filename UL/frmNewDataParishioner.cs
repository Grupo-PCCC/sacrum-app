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
    public partial class frmNewDataParishioner : Form
    {
        public string titulo;
        public string data;
        public string dataType;
        public ParishionerData PD;
        public Log L;
        public string oldData;
        public bool validData;
        public int flag;
        frmOtherDataParishioner owner;
        public frmNewDataParishioner(string action, string selectedData, frmOtherDataParishioner _owner)
        {
            InitializeComponent();
            titulo = action;
            oldData = "";
            data = selectedData;
            PD = new ParishionerData();
            L = new Log();
            flag = 0;
            owner = _owner;
        }

        private void NewDataParishioner_Load(object sender, EventArgs e)
        {
            if (txtData.Text == "")
            {
                btnAccept.Enabled = false;
            }
            txtData.Text = data;
            if (titulo == "nuevotelefono")
            {
                this.Text = "Nuevo teléfono";
                dataType = "tel";
            }
            if (titulo == "nuevadireccion")
            {
                this.Text = "Nueva dirección";
                dataType = "address";
            }
            if (titulo == "nuevomail")
            {
                this.Text = "Nuevo mail";
                dataType = "mail";
            }
            if (titulo == "modificartelefono")
            {
                this.Text = "Modificar teléfono";
                dataType = "tel";
                oldData = txtData.Text;
            }
            if (titulo == "modificardireccion")
            {
                this.Text = "Modificar dirección";
                dataType = "address";
                oldData = txtData.Text;
            }
            if (titulo == "modificarmail")
            {
                this.Text = "Modificar mail";
                dataType = "mail";
                oldData = txtData.Text;
            }

        }


        private void TxtData_TextChanged(object sender, EventArgs e)
        {
            if (titulo == "modificartelefono" || titulo == "modificardireccion" || titulo == "modificarmail")
            {
                data = null;
            }
            if (txtData.Text == "")
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
            if (titulo == "nuevotelefono" || titulo == "nuevadireccion" || titulo == "nuevomail")
            {
                data = txtData.Text.Trim();
                validData = PD.FindData(data);
                if (validData == true)
                {
                    MessageBox.Show("Ya existe en la base de datos un dato con el valor " + "'" + data + "'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtData.Clear();
                    txtData.Focus();
                    flag = 1;
                }
                else
                {
                    flag = 0;
                    PD.Data = data;
                    PD.DataType = dataType;
                    PD.IsPrincipal = 2;
                    PD.NewParishionerData(dataType,1,data,2);
                    owner.LoadListBox();
                    MessageBox.Show("Se ha guardado el dato del feligrés", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtData.Clear();
                    txtData.Focus();
                    /*
                    if (titulo == "nuevotipodeingreso")
                    {
                        L.Action = "El usuario " + Users.CacheUser.Nick + " registró una nueva categoría " + "'" + data + "'" + " de tipo Ingreso.";
                        L.ActionDate = DateTime.Now;
                        L._users.Id = Users.CacheUser.Id;
                        L.WriteLog(L);
                    }
                    else
                    {
                        L.Action = "El usuario " + Users.CacheUser.Nick + " registró una nueva categoría " + "'" + data + "'" + " de tipo Egreso.";
                        L.ActionDate = DateTime.Now;
                        L._users.Id = Users.CacheUser.Id;
                        L.WriteLog(L);
                    }
                    */
                }


            }
            else if (titulo == "modificartelefono" || titulo == "modificardireccion" || titulo == "modificarmail")
            {
                data = txtData.Text.ToString();

                if (flag == 0)
                {
                    data = txtData.Text.Trim();
                    validData = PD.FindData(data);
                    if (validData == true)
                    {
                        MessageBox.Show("Ya existe un dato con el valor " + "'" + data + "'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtData.Clear();
                        txtData.Focus();
                        flag = 1;
                    }
                }
                if (oldData != data && validData == false)
                {
                    data = txtData.Text.ToString();
                    PD.Data = data;
                    PD.Id = PD.GetDataId(oldData);
                    PD.UpdateParishionerData(PD.Id, data);
                    owner.LoadListBox();
                    MessageBox.Show("Se ha actualizado el dato", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    /*
                    if (titulo == "modifyingresscategory")
                    {
                        L.Action = "El usuario " + Users.CacheUser.Nick + " cambió el nombre de la categoría de tipo ingreso " + "'" + oldData + "'" + " por: " + "'" + data + "'.";
                        L.ActionDate = DateTime.Now;
                        L._users.Id = Users.CacheUser.Id;
                        L.WriteLog(L);
                    }
                    else if (titulo == "modifyegresscategory")
                    {
                        L.Action = "El usuario " + Users.CacheUser.Nick + " cambio el nombre de la categoría de tipo egreso " + "'" + oldData + "'" + " por: " + "'" + data + "'.";
                        L.ActionDate = DateTime.Now;
                        L._users.Id = Users.CacheUser.Id;
                        L.WriteLog(L);
                    }
                    */
                }

            }
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void FrmNewDataParishioner_Load(object sender, EventArgs e)
        {

        }
    }
}