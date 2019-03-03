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
    public partial class frmGenerateSeqOfBlogs : Form
    {
        public frmGenerateSeqOfBlogs()
        {
            InitializeComponent();
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            


        }

        public string Topic { get { return txtTopic.Text; } set { txtTopic.Text = value; } }
        public string Cat { get { return txtCategory2.Text; } set { txtCategory2.Text = value; } }
        public string Tags { get { return txtTags.Text; } set { txtTags.Text = value; } }

        public string SubTopics { get { return txtSubTopics.Text; } set { txtSubTopics.Text = value; } }
        public string Date { get { return this.dateTimePicker1.Value.ToString("yyyy-mm-dd"); } }

        //public string  { get {return dateTimePicker1.Value.ToShortDateString();} }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtTopic.Text != "") && (txtSubTopics.Text != "") && (txtCategory2.Text != ""))
                this.DialogResult = DialogResult.OK;
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Add a Category", string.Format("Please add a Topic, Category and SubTopics first."), buttons);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
