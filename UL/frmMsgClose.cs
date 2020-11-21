using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UL
{
    public partial class frmMsgClose : Form
    {
        public frmMsgClose()
        {
            InitializeComponent();
        }

        static frmMsgClose MsgBox; static DialogResult result = DialogResult.No;
        ////////////////////////////////////////////////////////////////////////////////
        public static DialogResult Show(string Text, string Caption, string btnOK, string btnCancel)
        {
            MsgBox = new frmMsgClose();
            MsgBox.label1.Text = Text;
            MsgBox.button1.Text = btnOK;
            MsgBox.button2.Text = btnCancel;
            MsgBox.Text = Caption;
            result = DialogResult.No;
            MsgBox.ShowDialog();
            return result;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            
            this.Dispose();
            this.Close();
            Application.Exit();

        }




        ////////////////////////////////////////////////////////////////////////////////


    }
}
