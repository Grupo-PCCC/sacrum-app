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
    public partial class frmNewActivity : Form
    {
        public Activity A;
        public ParishionerByActivity PBA;
        public Log L;
        public frmActivities owner;
        public int flag;
        public bool validActivity;
        public frmNewActivity(frmActivities _owner)
        {
            InitializeComponent();
            A = new Activity();
            PBA = new ParishionerByActivity();
            L = new Log();
            owner = _owner;
            flag = 0;
            
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            flag = 0;
            
            if (txtName.Text.Trim() == "")
            {
                Error.SetError(txtName, "Debe ingresar un nombre para registrar la actividad");
                flag = 1;
            }
            if (flag == 0)
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

            if (flag == 0)
            {
                A.Name = txtName.Text.Trim();
                A.Observation = txtDescription.Text.Trim();
                A.NewActivity(A);
                Combo.Combo2Campos(owner.cbActivity, "Id", "Name", "Activity");
                owner.BtnDelete.Enabled = true;
                owner.CargarGrilla();
                L.Action = "El usuario " + Users.CacheUser.Nick + " registró una nueva actividad: " + txtName.Text.ToString();
                L.ActionDate = DateTime.Now;
                L._users.Id = Users.CacheUser.Id;
                L.WriteLog(L);
                DialogResult answ = MessageBox.Show("Se ha guardado la actividad exitosamente." + "\n ¿Desea agregar feligreses a la actividad?", "Ok", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answ == DialogResult.Yes)
                {
                    this.Dispose();
                    this.Close();
                    frmActivities FA = new frmActivities();
                    frmModifyActivity FMA = new frmModifyActivity(A.GetLastId(), FA);
                    FMA.txtName.Text = A.GetActivityName(A.GetLastId());
                    FMA.txtDescription.Text = A.GetActivityObservation(A.GetLastId());
                    FMA.ShowDialog();
                }
                else
                {
                    txtName.Clear();
                    txtDescription.Clear();
                    Combo.Combo2Campos(owner.cbActivity, "Id", "Name", "Activity");
                    owner.CargarGrilla();
                    owner.CheckComboItems();
                }
            }
        } 

        private void FrmNewActivity_Load(object sender, EventArgs e)
        {
            this.Text = "Nueva actividad";
        //    btnAccept.Enabled = false;
        }

        private void TxtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtName_Enter(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void TxtName_Leave(object sender, EventArgs e)
        {
            Error.Clear();
        }
    }
}
