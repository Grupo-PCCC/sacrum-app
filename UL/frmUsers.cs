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
    public partial class frmUsers : Form
    {
        public Users _Users;
        public UserType _UT;
        public Log L;
        public int selectedUser;
        public frmUsers()
        {
            _Users = new Users();
            _UT = new UserType();
            L = new Log();
            selectedUser = 0;
            InitializeComponent();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            if (dgv_Users.Rows.Count == 0)
            {
                BtnModify.Enabled = false;
            }
        }
        public void CargarGrilla()
        {
            dgv_Users.Rows.Clear();
            var Nick = txtBuscar.Text.Trim();
            var l =_Users.Listar(Nick);

            foreach (var X in l)
            {
                dgv_Users.Rows.Add(X.Id ,X.Nick, X.Name, X.Surname, X._userType.Name);
            }
            Lbl_Filas.Text = "Registros:" + Convert.ToString(dgv_Users.Rows.Count);
            Lbl_Filas.Visible = true;
        }

        private void Dgv_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_Users.Columns[e.ColumnIndex].Name.Equals("Btn_Det"))
            {
                frmDataUsers frmdata = new frmDataUsers(this);
                DataGridViewRow dgv = dgv_Users.Rows[e.RowIndex];
                frmdata.Txt_Nick.Text = dgv.Cells["Nick"].Value.ToString();
                frmdata.Txt_Name.Text = dgv.Cells["Nombre"].Value.ToString();
                frmdata.Txt_Surname.Text = dgv.Cells["Apellido"].Value.ToString();
                frmdata.cbprofile.ValueMember = dgv.Cells["TipoUsuario"].Value.ToString();
                frmdata.Btn_New.Visible = false;
                frmdata.Btn_Refresh.Visible = true;
                frmdata.Txt_Nick.Enabled = false;
                frmdata.Btn_NewP.Visible = true;
                frmdata.Txt_Pass.Enabled = false;
                frmdata.Txt_RPass.Enabled = false;
                frmdata.Btn_CancelFirst.Visible = false;
                frmdata.Btn_CancelUser.Visible = false;
                frmdata.Btn_CancelAdm.Enabled = true;
                if (frmdata.cbprofile.ValueMember == "Administrador")
                {
                    frmdata.cbprofile.Enabled = false;
                }

                frmdata.ShowDialog();

            }


        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.TextLength < 3)
            {

            }
            else
            {
                CargarGrilla();
            }
            if (txtBuscar.TextLength == 0)
            {
                CargarGrilla();
            }
        }

      


        private void Btn_cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmDataUsers frmdata = new frmDataUsers(this);
            frmdata.Btn_NewP.Visible = false;
            frmdata.Btn_CancelFirst.Visible = false;
            frmdata.Btn_CancelUser.Visible = false;
            frmdata.Btn_Refresh.Visible = false;
            frmdata.Btn_UserPass.Visible = false;
            frmdata.Btn_New.Visible = true;
            frmdata.Txt_Pass.Enabled = false;
            frmdata.Txt_RPass.Enabled = false;
            frmdata.ShowDialog();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            
                frmDataUsers frmdata = new frmDataUsers(this);
                if(dgv_Users.SelectedRows.Count >0)
                {
                    frmdata.Txt_Nick.Text = dgv_Users.CurrentRow.Cells["Nick"].Value.ToString();
                    frmdata.Txt_Name.Text = dgv_Users.CurrentRow.Cells["Nombre"].Value.ToString();
                    frmdata.Txt_Surname.Text = dgv_Users.CurrentRow.Cells["Apellido"].Value.ToString();
                    frmdata.cbprofile.ValueMember = dgv_Users.CurrentRow.Cells["TipoUsuario"].Value.ToString();
                    frmdata.Btn_New.Visible = false;
                    frmdata.Btn_Refresh.Visible = true;
                    frmdata.Txt_Nick.Enabled = false;
                    frmdata.Btn_NewP.Visible = true;
                    frmdata.Txt_Pass.Enabled = false;
                    frmdata.Txt_RPass.Enabled = false;
                frmdata.Btn_CancelFirst.Visible = false;
                frmdata.Btn_CancelUser.Visible = false;
                frmdata.Btn_CancelAdm.Enabled = true;
                if (frmdata.cbprofile.ValueMember == "Administrador")
                    {
                        frmdata.cbprofile.Enabled = false;
                    }

                        frmdata.ShowDialog();
            }
               

            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            frmDataUsers frmdata = new frmDataUsers(this);
            selectedUser = Convert.ToInt32(dgv_Users.CurrentRow.Index.ToString());
            DataGridViewRow row = dgv_Users.Rows[selectedUser];
            int parishId = Convert.ToInt32(row.Cells[0].Value);
            if (dgv_Users.SelectedRows.Count > 0)
            {
                if (dgv_Users.CurrentRow.Cells["Nick"].Value.ToString() != Users.CacheUser.Nick)
                {

                    if (MessageBox.Show("¿Esta seguro que desea borrar el usuario seleccionado?", "Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        _Users.DeleteUser(parishId);
                        MessageBox.Show("Se ha eliminado el usuario: " + "'" + dgv_Users.CurrentRow.Cells["Nick"].Value.ToString() + "'", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        L.Action = "El administrador " + Users.CacheUser.Nick + " elimino el usuario " + "'" + dgv_Users.CurrentRow.Cells["Nick"].Value.ToString() + "'";
                        L.ActionDate = DateTime.Now;
                        L._users.Id = Users.CacheUser.Id;
                        L.WriteLog(L);
                    }
                    else
                    {
                        MessageBox.Show("Se ha cancelado la eliminación del usuario.", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    
                        MessageBox.Show("No es posible eliminar el usuario con el cual esta logeado.", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }

        }

        private void Dgv_Users_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDataUsers frmdata = new frmDataUsers(this);
            frmdata.Txt_Nick.Text = dgv_Users.CurrentRow.Cells["Nick"].Value.ToString();
            frmdata.Txt_Name.Text = dgv_Users.CurrentRow.Cells["Nombre"].Value.ToString();
            frmdata.Txt_Surname.Text = dgv_Users.CurrentRow.Cells["Apellido"].Value.ToString();
            frmdata.cbprofile.ValueMember = dgv_Users.CurrentRow.Cells["TipoUsuario"].Value.ToString();
            frmdata.Btn_New.Visible = false;
            frmdata.Btn_Refresh.Visible = true;
            frmdata.Txt_Nick.Enabled = false;
            frmdata.Btn_NewP.Visible = true;
            frmdata.Txt_Pass.Enabled = false;
            frmdata.Txt_RPass.Enabled = false;
            frmdata.Btn_CancelFirst.Visible = false;
            frmdata.Btn_CancelUser.Visible = false;
            frmdata.Btn_CancelAdm.Enabled = true;
            if (frmdata.cbprofile.ValueMember == "Administrador")
            {
                frmdata.cbprofile.Enabled = false;
            }

            frmdata.ShowDialog();
        }

        private void Dgv_Users_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            BtnModify.Enabled = true;
        }
    }
}




                    
                    
                    
                    