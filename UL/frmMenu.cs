using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LL;


namespace UL
{

    public partial class frmMenu : Form
    {
        public Log L;
        public int flag;
        public Users U;
        public frmMenu()
        {
            InitializeComponent();
            customizeDesign();
            flag = 0;
            L = new Log();
            U = new Users();
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);
            if (Users.UserTypeId.TypeId == 1)
            {
                Btn_System.Visible = true;
                CargaCacheUser();

            }
            else
            {
                Btn_System.Visible = false;
                CargaCacheUser();
            }

        }
        private void Btn_Parish_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormulario<frmParishioners>();
            Btn_Parish.BackColor = Color.FromArgb(0, 187, 194);
        }

        private void Btn_Cash_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormulario<frmCashMovement>();
            Btn_Cash.BackColor = Color.FromArgb(0, 187, 194);
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Esta seguro que desea cerrar sesión?", "Cierre de sesión", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                frmLogin FL = new frmLogin();
                this.Close();
                FL.Show();
            }

        }
        private void Btn_minimizar_Click_1(object sender, EventArgs e)
        {

           
            
            this.Visible = false;
            
        }

        private void CargaCacheUser()
        {
            lblUser.Text =  Users.CacheUser.Nick;
        }

    

       

        private void Btn_Activities_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormulario<frmActivities>();
            Btn_Activities.BackColor = Color.FromArgb(0, 187, 194);
        }
        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frmParishioners"] == null)
                Btn_Parish.BackColor = Color.Transparent;
            if (Application.OpenForms["frmCashMovement"] == null)
                Btn_Cash.BackColor = Color.Transparent;
            if (Application.OpenForms["frmLog"] == null)
                Btn_System.BackColor = Color.Transparent;
            if (Application.OpenForms["frmUsers"] == null)
                Btn_System.BackColor = Color.Transparent;
            if (Application.OpenForms["frmDataUsers"] == null)
                Btn_Datos.BackColor = Color.Transparent;
            if (Application.OpenForms["frmActivities"] == null)
                Btn_Activities.BackColor = Color.Transparent;
            if (Application.OpenForms["frmProviders"] == null)
                //Btn_Prov.BackColor = Color.Transparent;
                Btn_Proveedor.BackColor = Color.Transparent;



        }

        private void Btn_Datos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Btn_Datos.BackColor = Color.FromArgb(0, 187, 194);
            frmUsers fu = new frmUsers();
            frmDataUsers frmdata = new frmDataUsers(fu,"misdatos");
            flag = 1;
            frmdata.Btn_NewP.Visible = false;
            frmdata.Txt_Nick.Enabled = false;
            frmdata.Txt_Nick.Text = Users.CacheUser.Nick;
            frmdata.Txt_Name.Text = Users.CacheUser.Name;
            frmdata.Txt_Name.Enabled = false;
            frmdata.Txt_Surname.Text = Users.CacheUser.Surname;
            frmdata.Txt_Surname.Enabled = false;
            frmdata.Btn_CancelAdm.Visible = false;
            frmdata.Btn_CancelFirst.Visible = false;
            frmdata.Btn_New.Visible = false;
            frmdata.Btn_Refresh.Visible = false;
            frmdata.Btn_UserPass.Visible = true;
            frmdata.Txt_Nick.Visible = true;
            /*frmdata.Lbl_Usuario.Visible = true;
            frmdata.Txt_Nick.Text = Users.CacheUser.Nick;
            frmdata.Txt_Nick.Visible = true;
            frmdata.Txt_Nick.Enabled = false;
            frmdata.Lbl_Contraseña.Visible = true;
            frmdata.Txt_Pass.Visible = true;
            frmdata.Lbl_Repetir.Visible = true;
            frmdata.Txt_RPass.Visible = true;
            frmdata.Lbl_Nombre.Visible = false;
            frmdata.Txt_Name.Visible = false;*/
            
            if(Users.UserTypeId.TypeId == 1)
            {
                frmdata.cbprofile.Text = "Administrador";
                frmdata.cbprofile.Enabled = false;
            }
            else
            {
                frmdata.cbprofile.Text = "Usuario";
                frmdata.cbprofile.Enabled = false;
            }

                   frmdata.ShowDialog();

        }

        private void Btn_System_Click(object sender, EventArgs e)
        {
            showSubMenu(PnlSubMenuSys);
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormulario<frmUsers>();
            Btn_System.BackColor = Color.FromArgb(0, 187, 194);

        }

        private void BtnLogAudit_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormulario<frmLog>();
            Btn_System.BackColor = Color.FromArgb(0, 187, 194);

        }

        private void customizeDesign()
        {
            PnlSubMenuSys.Visible = false;



        }

        private void hideSubMenu()
        {
            if (PnlSubMenuSys.Visible == true)
                PnlSubMenuSys.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;


        }

        private void Btn_Prov_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            
            AbrirFormulario<frmProviders>();
            Btn_Proveedor.BackColor = Color.FromArgb(0, 187, 194);
        }

   
        

        private void Btn_LogOff_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show ("¿Está seguro que desea cerrar sesión?","Cerrar sesión",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                L.Action = "El usuario " + Users.CacheUser.Name + " cerró sesión en la aplicación";
                L.ActionDate = DateTime.Now;
                L._users.Id = U.GetUserId(Users.CacheUser.Nick);
                L.WriteLog(L);
                this.Dispose();
                this.Close();
                frmLogin frm = new frmLogin();
                frm.Show();
                
            }
            else
            {
            }
        }

        private void FrmMenu_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.F) & e.Control)

            {
                Btn_Parish.PerformClick();
            }
            if ((e.KeyCode == Keys.A) & e.Control)

            {
                Btn_Activities.PerformClick();
            }
            if ((e.KeyCode == Keys.C) & e.Control)

            {
                Btn_Cash.PerformClick();
            }
            if ((e.KeyCode == Keys.P) & e.Control)

            {
                Btn_Proveedor.PerformClick();
            }
        }

   


        private void MnuMostrarAplicacion_Click_1(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Activate();
            
        }

       

      

        private void IconizarApp_BalloonTipClicked(object sender, EventArgs e)
        {
            MnuMostrarAplicacion_Click_1(sender, e);
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == 1)
            {
                Application.Exit();
            }
            else
            {
                DialogResult answ = MessageBox.Show("¿Está seguro que desea salir de Sacrum?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answ == DialogResult.Yes)
                {
                    L.Action = "El usuario " + Users.CacheUser.Nick + " cerró sesión en la aplicación";
                    L.ActionDate = DateTime.Now;
                    L._users.Id = Users.CacheUser.Id;
                    L.WriteLog(L);
                    flag = 1;
                    Application.Exit();
                }
                else
                {
                    flag = 0;
                    e.Cancel = true;
                }
            }
        }

        private void MnuCerrarAplicacion_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                Application.Exit();
            }
            else
            {
                DialogResult answ = MessageBox.Show("¿Está seguro que desea salir de Sacrum?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answ == DialogResult.Yes)
                {
                    L.Action = "El usuario " + Users.CacheUser.Name + " cerró sesión en la aplicación";
                    L.ActionDate = DateTime.Now;
                    L._users.Id = Users.CacheUser.Id;
                    L.WriteLog(L);
                    flag = 1;
                    this.Close();
                }
                else
                {
                    flag = 0;
                    
                }
            }
        }

        private void MnuContextual_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Btn_Proveedor_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            AbrirFormulario<frmProviders>();
            Btn_Proveedor.BackColor = Color.FromArgb(0, 187, 194);
        }
    }
}

