using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LL;

namespace UL
{
    public partial class frmLogin : Form
    {


        Users UL = new Users();
        ValidData VL = new ValidData();
        public Log L;
        
        public frmLogin()
        {
            InitializeComponent();
            L = new Log();
            
        }

         

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //this.AcceptButton = btn_ingresar; //Permite loggear apretando el boton enter en cualquier lado donde este el cursor.
        }

       
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            var answ =MessageBox.Show("¿Esta seguro que desea salir de la aplicación?", "Cerrar Aplicación", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (answ == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
            
        }

        private void Txt_usuario_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("Usuario"))

            {
                txtUser.ForeColor = Color.Black;
                txtUser.Text = "";
            }
        }

        private void Txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")

            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.DarkGray;
            }
            else
            {
                txtUser.ForeColor = Color.Black;
            }
        }

        private void Txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text.Equals("PASSWORD"))

            {
                txt_password.ForeColor = Color.Black;
                txt_password.Text = "";
            }
        }

        private void Txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text=="")

            {
                txt_password.ForeColor = Color.DarkGray;
                txt_password.Text = "PASSWORD";
            }
            else
            {
                txt_password.ForeColor = Color.Black;
            }
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "Usuario")
            {
                if (txt_password.Text != "Usuario")
                {
                    var loginvalido = UL.login(txtUser.Text, txt_password.Text); //Se guarda en variable el resultado del Metodo de Buscar Usuario (Log.login)
                    if (loginvalido == true) //Si la variable es verdadera, se ingresa al sistema.
                    {

                        L.Action = "El usuario " + txtUser.Text + " inició sesión en la aplicación";
                        L.ActionDate = DateTime.Now;
                        L._users.Id = UL.GetUserId(txtUser.Text);
                        L.WriteLog(L);
                        if (txt_password.Text == "nuevousuario")
                        {
                            frmUsers fu = new frmUsers();
                            frmDataUsers frmdata = new frmDataUsers(fu,"nuevousuario"); //Instancia Formulario de Bienvenida.
                            MessageBox.Show("Primer ingreso, cambio de contraseña obligatorio", "Solicitud de cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            frmdata.Btn_NewP.Visible = false;
                            frmdata.Txt_Nick.Enabled = false;
                            frmdata.Txt_Nick.Text = Users.CacheUser.Nick;
                            frmdata.Txt_Name.Text = Users.CacheUser.Name;
                            frmdata.Txt_Name.Enabled = false;
                            frmdata.Txt_Surname.Text = Users.CacheUser.Surname;
                            frmdata.Txt_Surname.Enabled = false;
                            frmdata.Btn_CancelAdm.Visible = false;
                            frmdata.Btn_CancelFirst.Visible = true;
                            frmdata.Btn_CancelUser.Visible = false;
                            frmdata.Btn_New.Visible = false;
                            frmdata.Btn_Refresh.Visible = false;
                            frmdata.Btn_UserPass.Visible = true;
                            frmdata.Txt_Nick.Visible = true;
                            frmdata.cbprofile.Enabled = false;
                            frmdata.ShowDialog();
                            this.Dispose();
                            this.Close(); 

                            /*frmdata.Lbl_Nombre.Visible = false;
                            frmdata.Txt_Name.Visible = false;
                            frmdata.Lbl_Apellido.Visible = false;
                            frmdata.Txt_Surname.Visible = false;
                            frmdata.Txt_Nick.Text = Users.CacheUser.Nick;
                            frmdata.Txt_Nick.Enabled = false;
                            frmdata.Lbl_Contraseña.Visible = true;
                            frmdata.Lbl_Repetir.Visible = true;
                            frmdata.Txt_Pass.Visible = true;
                            frmdata.Txt_RPass.Visible = true;
                            frmdata.Lbl_Perfil.Visible = false;
                            frmdata.cbprofile.Visible = false;
                            frmdata.Btn_CancelUser.Visible = false;
                            frmdata.Btn_CancelAdm.Visible = false;
                            frmdata.Btn_CancelFirst.Visible = true;
                            frmdata.Btn_New.Visible = false;
                            frmdata.Btn_Refresh.Visible = false;
                            frmdata.Btn_UserPass.Visible = true;
                            frmdata.Lbl_NUser.Visible = false;
                            frmdata.Txt_Nick.Visible = false;
                            frmdata.ShowDialog();
                            this.Dispose();
                            this.Close();*/
                        }
                        else
                        {
                            frmMenu frmMenu = new frmMenu(); //Instancia Formulario de Bienvenida.
                            frmMenu.WindowState = FormWindowState.Maximized;
                            frmMenu.Show();
                            this.Dispose();
                            this.Close();
                        }
                    }//IF LOGIN

                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña invalidos.", "Login", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        txtUser.Focus();
                        txt_password.Clear();

                    }//ELSE USER/PW

                }//IF PASSWORD
                else MessageBox.Show("Por favor ingrese una contraseña", "Login", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_password.Focus();

            }//IF USUARIO
            else
            {
                MessageBox.Show("Por favor ingrese un usuario", "Login", MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtUser.Focus();

            }//ELSE USUARIO
        }

       

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Txt_password_TextChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }


    }
    
    
}
