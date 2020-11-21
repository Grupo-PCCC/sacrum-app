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
    public partial class frmSelectedCashMovement : Form
    {
        public int CashMovementId;
        public CashMovement C;
        public Log L;
        public frmCashMovement _owner;
        public frmSelectedCashMovement(int _cashMovementId, frmCashMovement owner)
        {
            InitializeComponent();
            CashMovementId = _cashMovementId;
            C = new CashMovement();
            L = new Log();
            _owner = owner;
        }

        private void FrmSelectedCashMovement_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            C.UpdateCashMovementDescription(CashMovementId, txtObservation.Text.ToString());
            MessageBox.Show("Se ha actualizado la observación correctamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            L.Action = "El usuario " + Users.CacheUser.Nick + " modificó la observación del movimiento monetario " + CashMovementId;
            L.ActionDate = DateTime.Now;
            L._users.Id = Users.CacheUser.Id;
            L.WriteLog(L);
            if (_owner.chbIngress.Checked == false && _owner.chbEgress.Checked == false)
            {
                _owner.LoadDgvByDate();
                _owner.categoryType = 0;
                _owner.dgvCashMovement.Rows[_owner.dgvCashMovement.Rows.Count - 1].Selected = true;
            }

            if ((_owner.chbIngress.Checked == true || _owner.chbEgress.Checked == true) && _owner.chbCategory.Checked == true)
            {
                _owner.LoadDgvByDateAndCategoryType();
                _owner.dgvCashMovement.Rows[_owner.dgvCashMovement.Rows.Count - 1].Selected = true;
            }

            if ((_owner.chbIngress.Checked == true || _owner.chbEgress.Checked == true) && _owner.chbCategory.Checked == false)
            {
                _owner.LoadDgvByDateAndCategory();
                _owner.dgvCashMovement.Rows[_owner.dgvCashMovement.Rows.Count - 1].Selected = true;
            }
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
