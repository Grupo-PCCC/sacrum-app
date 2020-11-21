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
    public partial class frmActivities : Form
    {
        public Parishioner P;
        public Activity A;
        public Log L;
        public frmParishioners FP;
        public frmActivities()
        {
            InitializeComponent();
            P = new Parishioner();
            A = new Activity();
            L = new Log();
            FP = new frmParishioners();
        }

        public void FrmActivities_Load(object sender, EventArgs e)
        {
            Combo.Combo2Campos(cbActivity, "Id", "Name", "Activity");
            CheckComboItems();
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            if (cbActivity.Items.Count>0)
            {
                dgv_Activities.Rows.Clear();
                var name = txtBuscar.Text.Trim();
                int activityId = Convert.ToInt32(((DataRowView)cbActivity.SelectedItem)["Id"]);
                var l = P.ListParishByActivity(name, activityId);
                foreach (var X in l)
                {
                    dgv_Activities.Rows.Add(X.Id, X.Name, X.Surname, X.Documento, X.BirthDate, X.Telephone, X.Address, X.Mail, X.Observation, X._parishionerData.IdTel, X._parishionerData.IdAddress, X._parishionerData.IdMail);
                }
                Lbl_Filas.Text = "Registros:" + Convert.ToString(dgv_Activities.Rows.Count);
                Lbl_Filas.Visible = true;
            }
            
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CbActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void BtnActivities_Click(object sender, EventArgs e)
        {
            frmNewActivity FNA = new frmNewActivity(this);
            FNA.ShowDialog();
            CheckComboItems();
        }

        
        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            int activityId = Convert.ToInt32(((DataRowView)cbActivity.SelectedItem)["Id"]);
            frmModifyActivity FMA = new frmModifyActivity(activityId,this);
            FMA.txtName.Text = (Convert.ToString(((DataRowView)cbActivity.SelectedItem)["Name"]));
            FMA.txtDescription.Text =A.GetActivityObservation(activityId);
            FMA.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgv_Activities.Rows.Count == 0)
            {
                string categoryName= Convert.ToString(((DataRowView)cbActivity.SelectedItem)["Name"]);
                A.DeleteActivity(Convert.ToInt32(((DataRowView)cbActivity.SelectedItem)["Id"]));
                L.Action = "El usuario " + Users.CacheUser.Nick + " eliminó la actividad " + categoryName + " (" + (Convert.ToInt32(((DataRowView)cbActivity.SelectedItem)["Id"])) + ").";
                L.ActionDate = DateTime.Now;
                L._users.Id = Users.CacheUser.Id;
                L.WriteLog(L);
                Combo.Combo2Campos(cbActivity, "Id", "Name", "Activity");
                CargarGrilla();
                MessageBox.Show("Se ha eliminado la actividad " + categoryName + ".", "Actividad eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string categoryName = Convert.ToString(((DataRowView)cbActivity.SelectedItem)["Name"]);
                DialogResult answ = MessageBox.Show("La actividad " + categoryName + " tiene uno o más feligreses registrados." + "\n¿Desea eliminarla igualmente?", "Eliminar actividad", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answ == DialogResult.Yes)
                {
                    A.DeleteActivity(Convert.ToInt32(((DataRowView)cbActivity.SelectedItem)["Id"]));
                    L.Action = "El usuario " + Users.CacheUser.Nick + " eliminó la actividad " +categoryName+ " (" + (Convert.ToInt32(((DataRowView)cbActivity.SelectedItem)["Id"])) + ").";
                    L.ActionDate = DateTime.Now;
                    L._users.Id = Users.CacheUser.Id;
                    L.WriteLog(L);
                    Combo.Combo2Campos(cbActivity, "Id", "Name", "Activity");
                    CargarGrilla();
                    MessageBox.Show("Se ha eliminado la actividad " + categoryName + ".", "Actividad eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            CheckComboItems();
        }

        private void FrmActivities_Activated(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CheckComboItems()
        {
            if (cbActivity.Items.Count == 0)
            {
                BtnDelete.Enabled = false;
                BtnModify.Enabled = false;
                dgv_Activities.Rows.Clear();
            }
            else
            {
                BtnDelete.Enabled = true;
                BtnModify.Enabled = true;
            }
        }

        private void Dgv_Activities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_Activities.Columns[e.ColumnIndex].Name.Equals("clmViewDetail"))
            {
                FP.SendParish(dgv_Activities);
            }
        }

        private void TxtBuscar_TextChanged_1(object sender, EventArgs e)
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

        private void Dgv_Activities_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FP.SendParish(dgv_Activities);
        }

        private void Dgv_Activities_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            BtnModify.Enabled = true;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
