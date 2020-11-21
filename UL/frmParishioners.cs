using System;
using System.Windows.Forms;
using LL;

namespace UL
{
    public partial class frmParishioners : Form
    {
        public Parishioner _Parishioner;
        public int selectedParish;
        public Log L;
        public frmParishioners()
        {
            _Parishioner = new Parishioner();
            L = new Log();
            selectedParish = 0;
            InitializeComponent();
        }

        private void FrmParishioners_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            txtBuscar.Focus();
            if (dgv_Parish.Rows.Count == 0)
            {
                BtnDelete.Enabled = false;
                BtnModify.Enabled = false;
            }
        }

        public void CargarGrilla()
        {
            dgv_Parish.Rows.Clear();
            var name = txtBuscar.Text.Trim();
            var l = _Parishioner.Listar(name);
            foreach (var X in l)
            {
                dgv_Parish.Rows.Add(X.Id, X.Name, X.Surname, X.Documento, Convert.ToDateTime(X.BirthDate).ToShortDateString(), X.Telephone, X.Address, X.Mail, X.Observation, X._parishionerData.IdTel, X._parishionerData.IdAddress, X._parishionerData.IdMail);
            }

            NullDateTime(dgv_Parish);
            lblFilas.Text = "Registros: " + Convert.ToString(dgv_Parish.Rows.Count);
            lblFilas.Visible = true;
        }

        private void NullDateTime(DataGridView datagrid)

        {
            foreach (DataGridViewRow row in datagrid.Rows)
            {
                if (Convert.ToString(datagrid.Rows[row.Index].Cells[4].Value) == "1/1/0001")

                {
                    datagrid.Rows[row.Index].Cells[4].Value = "";
                }
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.TextLength <3)
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

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {

            this.Close();


        }


        public void SendParish(DataGridView datagrid)
        {

            frmActivities FA = new frmActivities();
            frmDataParishioners frm = new frmDataParishioners("ModifyParish", this, FA);
            selectedParish = Convert.ToInt32(datagrid.CurrentRow.Index.ToString());
            DataGridViewRow dgv = datagrid.Rows[selectedParish];
            frm.parishId = Convert.ToInt32(dgv.Cells["clmId"].Value);
            frm.txtName.Text = dgv.Cells["Nombre"].Value.ToString();
            frm.txtSurname.Text = dgv.Cells["Apellido"].Value.ToString();
            frm.txtDocumento.Text = dgv.Cells["clmDocumento"].Value.ToString();
            if (dgv.Cells["FechaNac"].Value?.ToString() != "")
            {
                frm.chbDateTime.Checked = true;
                frm.dtBornDate.Value = DateTime.Parse(dgv.Cells["FechaNac"].Value.ToString());
            }
            else
            {
                frm.chbDateTime.Checked = false;
                frm.dtBornDate.Enabled = false;
                frm.dtBornDate.Value = DateTime.Today;
            }
            frm.txtTelephone.Text = dgv.Cells["Telephone"].Value.ToString();
            frm.txtAddress.Text = dgv.Cells["Address"].Value.ToString();
            frm.txtMail.Text = dgv.Cells["Mail"].Value.ToString();
            frm.txtObservation.Text= dgv.Cells["clmObservation"].Value.ToString();
            frm.telephoneId = Convert.ToInt32(dgv.Cells["clmParishionerPhoneId"].Value);
            frm.addressId = Convert.ToInt32(dgv.Cells["clmParishionerAddressId"].Value);
            frm.mailId = Convert.ToInt32(dgv.Cells["clmParishionerMailId"].Value);
            frm.ShowDialog();
        }
        private void Dgv_Parish_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SendParish(dgv_Parish);
        }

        private void Dgv_Parish_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_Parish.Columns[e.ColumnIndex].Name.Equals("clmViewDetail"))
            {
                SendParish(dgv_Parish);
            }
        }

        

        

        

        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmActivities FA = new frmActivities();
            frmDataParishioners FDP = new frmDataParishioners("NewParish", this, FA);
            FDP.ShowDialog();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            SendParish(dgv_Parish);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            selectedParish = Convert.ToInt32(dgv_Parish.CurrentRow.Index.ToString());
            DataGridViewRow row = dgv_Parish.Rows[selectedParish];
            int parishId = Convert.ToInt32(row.Cells[0].Value);
            bool IsParishionerInAcrivity = _Parishioner.FindParishionerInActivities(parishId);
            if (IsParishionerInAcrivity == false)
            {
                DialogResult answ = MessageBox.Show("¿Está seguro que desea eliminar el feligrés " + Convert.ToString(row.Cells[1].Value) + " " + Convert.ToString(row.Cells[2].Value) + "?" , "Eliminar feligrés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answ == DialogResult.Yes)
                {
                    _Parishioner.DeleteParishioner(parishId);
                    CargarGrilla();
                    MessageBox.Show("Se ha eliminado el feligrés " + "'" + Convert.ToString(row.Cells[1].Value) + " " + Convert.ToString(row.Cells[2].Value) + "'", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    L.Action = "El usuario " + Users.CacheUser.Nick + " elimino el feligres " + "'" + Convert.ToString(row.Cells[1].Value) + " " + Convert.ToString(row.Cells[2].Value) + "'";
                    L.ActionDate = DateTime.Now;
                    L._users.Id = Users.CacheUser.Id;
                    L.WriteLog(L);
                }
                else
                {

                }
            }
            if (IsParishionerInAcrivity == true)
            {
                DialogResult answ2 = MessageBox.Show("El feligrés " + Convert.ToString(row.Cells[1].Value) + " " + Convert.ToString(row.Cells[2].Value) + " está registrado en una o más actividades. \n¿Desea igualmente eliminar el feligrés seleccionado?", "Eliminar feligrés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answ2 == DialogResult.Yes)
                {
                    _Parishioner.DeleteParishioner(parishId);
                    CargarGrilla();
                    MessageBox.Show("Se ha eliminado el feligrés " + "'" + Convert.ToString(row.Cells[1].Value) + " " + Convert.ToString(row.Cells[2].Value) + "'", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    L.Action = "El usuario " + Users.CacheUser.Nick + " elimino el feligres " + "'" + Convert.ToString(row.Cells[1].Value) + "'.";
                    L.ActionDate = DateTime.Now;
                    L._users.Id = Users.CacheUser.Id;
                    L.WriteLog(L);
                }
                else if (answ2 == DialogResult.No)
                {

                }

            }
        }

        private void Btn_cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_Parish_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgv_Parish.Rows.Count == 0)
            {
                BtnDelete.Enabled = false;
                BtnModify.Enabled = false;
            }
        }

        private void Dgv_Parish_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            BtnDelete.Enabled = true;
            BtnModify.Enabled = true;
        }
    }
    }

