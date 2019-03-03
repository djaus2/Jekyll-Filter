using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterWF
{
    public partial class frmInputBox : Form
    {
        public frmInputBox()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        public string Cat { get { return txtCategory.Text; } }
        public string Abbrev { get { return txtAbbrev.Text; } }

        private void button1_Click(object sender, EventArgs e)
        {
            if  ((txtCategory.Text != "") && (txtAbbrev.Text != ""))
            this.DialogResult = DialogResult.OK;
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Add a Category", string.Format("Please add a Category and Abbreviation first."), buttons);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
