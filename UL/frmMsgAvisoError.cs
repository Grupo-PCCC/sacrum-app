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
    public partial class frmMsgAvisoError : Form
    {
        public frmMsgAvisoError()
        {
            InitializeComponent();
        }

        static frmMsgAvisoError MsgBox; static DialogResult result = DialogResult.No;
        ////////////////////////////////////////////////////////////////////////////////
        public static DialogResult Show(string Text, string Caption, string btnOK)
        {
            MsgBox = new frmMsgAvisoError();
            MsgBox.label1.Text = Text;
            MsgBox.button1.Text = btnOK;

            MsgBox.Text = Caption;
            result = DialogResult.No;
            MsgBox.ShowDialog();
            return result;
        }

    

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        ////////////////////////////////////////////////////////////////////////////////


    }
}
