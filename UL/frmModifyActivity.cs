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
    public partial class frmModifyActivity : Form
    {
        public int activityId;
        public ParishionerByActivity PBA;
        public int selectedParish;
        public Log L;
        public frmActivities owner;
        public Activity A;
        public int flag;
        public string oldCategory;
        public bool validActivity;
        public frmModifyActivity(int _activityId, frmActivities _owner)
        {
            InitializeComponent();
            activityId = _activityId;
            selectedParish = 0;
            PBA = new ParishionerByActivity();
            L = new Log();
            A = new Activity();
            owner = _owner;
            flag = 0;
            oldCategory = "";
        }

        private void FrmModifyActivity_Load(object sender, EventArgs e)
        {
            CargarGrillas();
            dgvParishRight.ClearSelection();
            dgvParishLeft.ClearSelection();
            txtName.Focus();
            btnParishToLeft.Enabled = false;
            btnParishToRight.Enabled = false;
            oldCategory = txtName.Text;


        }
        public void CargarGrillas()
        {
            dgvParishLeft.Rows.Clear();
            dgvParishRight.Rows.Clear();
            var l = PBA.ListAllParishionerNotInActivity(activityId);
            var r= PBA.ListAllParishionerInActivity(activityId);

            foreach (var X in l)
            {
                dgvParishLeft.Rows.Add(X._parishioner.Id, X._parishioner.Name);
            }

            foreach (var X in r)
            {
                dgvParishRight.Rows.Add(X._parishioner.Id, X._parishioner.Name);
            }
            label1.Text = "Feligreses disponibles: " + dgvParishLeft.Rows.Count;
            label2.Text = "Feligreses en la actividad: " + dgvParishRight.Rows.Count;
        }

        private void Dgv_Activities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvParishRight.ClearSelection();
        }

        private void DgvParishLeft_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvParishRight.ClearSelection();
            btnParishToLeft.Enabled = false;
            btnParishToRight.Enabled = true;
        }

        private void DgvParishRight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvParishLeft.ClearSelection();
            btnParishToLeft.Enabled = true;
            btnParishToRight.Enabled = false;
        }

        private void BtnParishToRight_Click(object sender, EventArgs e)
        {
            if (dgvParishLeft.Rows.Count != 0)
            {
                selectedParish = Convert.ToInt32(dgvParishLeft.CurrentRow.Index.ToString());
                DataGridViewRow row = dgvParishLeft.Rows[selectedParish];
                int parishId = Convert.ToInt32(row.Cells[0].Value);
                string parishName = Convert.ToString(row.Cells[1].Value);
                dgvParishLeft.Rows.Remove(row);
                dgvParishRight.Rows.Add(parishId, parishName);
                dgvParishRight.ClearSelection();
                CheckDGVCount();
                label1.Text = "Feligreses disponibles: " + dgvParishLeft.Rows.Count;
                label2.Text = "Feligreses en la actividad: " + dgvParishRight.Rows.Count;
            }

        }

        private void DgvParishRight_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvParishLeft.ClearSelection();

        }

        private void BtnParishToLeft_Click(object sender, EventArgs e)
        {
            if (dgvParishRight.Rows.Count != 0)
            {
                selectedParish = Convert.ToInt32(dgvParishRight.CurrentRow.Index.ToString());
                DataGridViewRow row = dgvParishRight.Rows[selectedParish];
                int parishId = Convert.ToInt32(row.Cells[0].Value);
                string parishName = Convert.ToString(row.Cells[1].Value);
                dgvParishRight.Rows.Remove(row);
                dgvParishLeft.Rows.Add(parishId, parishName);
                dgvParishLeft.ClearSelection();
                label1.Text = "Feligreses disponibles: " + dgvParishLeft.Rows.Count;
                label2.Text = "Feligreses en la actividad: " + dgvParishRight.Rows.Count;
            }


        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            flag = 0;
            if (txtName.Text.Trim() == "")
            {
                Error.SetError(txtName, "Debe ingresar un nombre para registrar la actividad");
                flag = 1;
            }
            if (flag==0 && oldCategory != txtName.Text)
            {
                validActivity = A.FindActivity(txtName.Text);
                if (validActivity == true)
                {
                    MessageBox.Show("Ya existe una actividad con el nombre " + "'" + txtName.Text + "'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Clear();
                    txtName.Focus();
                    flag = 1;
                }
            }
            //if (flag ==0 && txtName.Text != A.GetActivityName(activityId)||txtDescription.Text!=A.GetActivityObservation(activityId))
            if (flag == 0)
            {
                A.Name = txtName.Text;
                A.Observation = txtDescription.Text;
                A.Id = activityId;
                A.UpdateActivity(A);
                L.Action = "El usuario " + Users.CacheUser.Nick + " modificó la actividad " + txtName.Text + "(" + activityId + ").";
                L.ActionDate = DateTime.Now;
                L._users.Id = Users.CacheUser.Id;
                L.WriteLog(L);
            }
            if (flag == 0 && dgvParishRight.Rows.Count != 0)
            {
                PBA.DeleteActivityInParishionerByActivity(activityId);
                foreach (DataGridViewRow x in dgvParishRight.Rows)
                {
                    PBA.NewParishionerByActivity(activityId, Convert.ToInt32(x.Cells[0].Value));
                }
                L.Action = "El usuario " + Users.CacheUser.Nick + " modificó la actividad " + txtName.Text + "(" + activityId + ").";
                L.ActionDate = DateTime.Now;
                L._users.Id = Users.CacheUser.Id;
                L.WriteLog(L);
                MessageBox.Show("Los datos de la actividad han sido modificados con éxito.", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            if (flag==0 && dgvParishRight.Rows.Count == 0)
            {
                PBA.DeleteActivityInParishionerByActivity(activityId);
                L.Action = "El usuario " + Users.CacheUser.Nick + " modificó la actividad " + txtName.Text + "(" + activityId + ").";
                L.ActionDate = DateTime.Now;
                L._users.Id = Users.CacheUser.Id;
                L.WriteLog(L);
                MessageBox.Show("Los datos de la actividad han sido modificados con éxito.", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }


        }

        private void DgvParishLeft_SelectionChanged(object sender, EventArgs e)
        {
            //btnParishToLeft.Enabled = false;
            //btnParishToRight.Enabled = true;
        }

        private void DgvParishRight_SelectionChanged(object sender, EventArgs e)
        {
           // btnParishToLeft.Enabled = true;
            //btnParishToRight.Enabled = false;
        }

        private void BtnNewParishioner_Click(object sender, EventArgs e)
        {
            frmParishioners FP = new frmParishioners();
            frmDataParishioners FDP = new frmDataParishioners("NewParish", FP,owner);
            FDP.ShowDialog();
        }

        private void FrmModifyActivity_FormClosed(object sender, FormClosedEventArgs e)
        {
            Combo.Combo2Campos(owner.cbActivity, "Id", "Name", "Activity");
            owner.CargarGrilla();
            owner.CheckComboItems();
        }

        private void TxtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckDGVCount()
        {
            if (dgvParishRight.Rows.Count == 0)
            {
                btnParishToLeft.Enabled = false;
            }
            if (dgvParishLeft.Rows.Count == 0)
            {
                btnParishToRight.Enabled = false;
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            CargarGrillas();
        }
    }
}
