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
    public partial class frmDataUsers : Form
    {

        public Users _User;
        public UserType _userType;
        public Log L;
        public int UserID;
        public string titulo;
        public string action;
        public frmUsers owner;
        public frmDataUsers(frmUsers _owner)
        {
            _User = new Users();
            _userType = new UserType();
            titulo = action;
            L = new Log();
            UserID = 0;
            InitializeComponent();
            owner = _owner;
        }

        private void CargaCacheUser()
        {
            lblUserId.Text = Users.CacheUser.Id.ToString();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            Combo.Combo2Campos(cbprofile, "Id", "Name", "UserType");
            CargaCacheUser();
        }

     
        private void Txt_Nick_Enter(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void Txt_Pass_Enter(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void Txt_RPass_Enter(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void Txt_Name_Enter(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void Txt_Surname_Enter(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void Txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidData.SoloLetras(e);
            if (e.Handled == true)
           {
               Error.SetError(Txt_Name, "Se permiten solamente letras.");
           }
           else
           {
               Error.Clear();
           }
       
        }

        private void Txt_Surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidData.SoloLetras(e);
            if (e.Handled == true)
            {
                Error.SetError(Txt_Surname, "Se permiten solamente letras.");
            }
            else
            {
                Error.Clear();
            }
        }

        private void Txt_Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidData.LetNumEspGui(e);
        }

        private void Txt_RPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidData.LetNumEspGui(e);
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            _User.Nick = Txt_Nick.Text.ToString();                 
            _User.Password = "nuevousuario";
            _User.Name = Txt_Name.Text.ToString();
            _User.Surname = Txt_Surname.Text.ToString();
            _User._userType.Id = Convert.ToInt32(((DataRowView)cbprofile.SelectedItem)["Id"]);
            if (Txt_Nick.Text.Trim() != "")
            {
                Error.Clear();
                if (Txt_Name.Text.Trim() != "")
                {
                    Error.Clear();
                    if (Txt_Surname.Text.Trim() != "")
                    {
                        Error.Clear();
                        var uschk = _User.CheckUser(Txt_Nick.Text);
                        if (uschk == true)
                        {
                            Error.SetError(Txt_Nick, "El nombre de usuario " + _User.Nick + " ya existe en el sistema.\nPor favor ingrese otro para continuar.");
                            Txt_Nick.Clear();
                        }
                        else
                        {
                            _User.NewUser(_User);
                            MessageBox.Show("El usuario fue creado correctamente", "Registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Txt_Surname.Clear();
                            Txt_Name.Clear();
                            Txt_Pass.Clear();
                            Txt_RPass.Clear();
                            Txt_Pass.Clear();
                            Txt_RPass.Clear();
                            Txt_Nick.Clear();
                            Txt_Nick.Clear();
                            L.Action = "El usuario " + Users.CacheUser.Nick + " registró un nuevo usuario: " + _User.Nick;
                            L.ActionDate = DateTime.Now;
                            L._users.Id = Users.CacheUser.Id;
                            L.WriteLog(L);
                        }
                    }//Apellido
                    else
                        Error.SetError(Txt_Surname, "Debe ingresar el apellido");

                }//Name
                else
                    Error.SetError(Txt_Name, "Debe ingresar el nombre");
            }//Nick
            else
            { 
                Error.SetError(Txt_Nick, "Debe ingresar el nick del usuario");
            }
            
        }//BTN



      
      private void Btn_NewP_Click(object sender, EventArgs e)
        {
            
            _User.Nick = Txt_Nick.Text.ToString();
            if (MessageBox.Show("¿Está seguro que desea blanquear la contraseña del usuario " + _User.Nick + "?", "Contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _User.Password = "nuevousuario";
                _User.NewPassUser(_User);
                MessageBox.Show("Se ha blanqueado la contraseña exitósamente.", "Contraseña blanqueada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                L.Action = "El usuario " + Users.CacheUser.Nick + " blanqueó la contraseña del usuario " + _User.Nick;
                L.ActionDate = DateTime.Now;
                L._users.Id = Users.CacheUser.Id;
                L.WriteLog(L);
                this.Close();

            }
            else
            {    
            }
        }

        private void Btn_CancelAdm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_CancelFirst_Click(object sender, EventArgs e)
        {
            frmLogin FL = new frmLogin();
            this.Close();
            FL.Show();
        }

        private void Lbl_Perfil_Click(object sender, EventArgs e)
        {

        }

        private void Btn_UserPass_Click_1(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frmLogin frmLogin = new frmLogin();
            int flag = 0;
            if (Txt_Pass.Text == "")
            {
                Error.SetError(Txt_Pass, "Debe ingresar una contraseña");
                flag = 1;
            }
            if (Txt_Pass.TextLength >= 1 && Txt_Pass.TextLength < 6)
            {
                Txt_Pass.Clear();
                Txt_RPass.Clear();
                Txt_Pass.Focus();
                Error.SetError(Txt_Pass, "La contraseña debe tener 6 caractéres como mínimo");
                flag = 1;
            }
            if (Txt_Pass.Text != Txt_RPass.Text && flag==0)
            {
                Error.SetError(Txt_Pass, "Las contraseñas escritas no son iguales");
                Error.SetError(Txt_RPass, "Las contraseñas escritas no son iguales");
                flag = 1;
            }
            if (Txt_Pass.Text==Txt_RPass.Text && flag == 0)
            {
                Error.Clear();
                _User.Nick = Txt_Nick.Text.ToString();
                _User.Password = Txt_Pass.Text.ToString();
                _User.UpdatePass(_User);
                MessageBox.Show("La contraseña ha sido modificada exitósamente.", "Contraseña modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                L.Action = "El usuario " + Users.CacheUser.Nick + " modificó su contraseña";
                L.ActionDate = DateTime.Now;
                L._users.Id = Users.CacheUser.Id;
                L.WriteLog(L);
                this.Close();
                frmLogin.Show();
                frm.Close();

                
            }
        }

        private void Btn_Refresh_Click_1(object sender, EventArgs e)
        {
             UserID = _User.GetUserId(Txt_Nick.Text);
            _User.Id = UserID;
            _User.Nick = Txt_Nick.Text.ToString();
            _User.Name = Txt_Name.Text.ToString();
            _User.Surname = Txt_Surname.Text.ToString();
            _User._userType.Id = Convert.ToInt32(((DataRowView)cbprofile.SelectedItem)["Id"]);
            _User.UpdateUser(_User);
            MessageBox.Show("Usuario modificado correctamente.", "Modificación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            L.Action = "El administrador " + Users.CacheUser.Nick + " modificó al usuario: " + _User.Nick;
            L.ActionDate = DateTime.Now;
            L._users.Id = Users.CacheUser.Id;
            L.WriteLog(L);
            this.Dispose();
            this.Close();
            
        }

        private void FrmDataUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.CargarGrilla();
        }
    }

}
