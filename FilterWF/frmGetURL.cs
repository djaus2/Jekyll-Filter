using System;
using System.IO;
using System.Windows.Forms;

namespace FilterWF
{
    public partial class frmGetUrl : Form
    {
        public frmGetUrl()
        {
            InitializeComponent();

        }

        public string Url { get { return textBox1.Text; } set { textBox1.Text = value; } }
        public string Title { get { return textBox2.Text; } set { textBox2.Text = value; } }

        private void frmGetUrl_Load(object sender, EventArgs e)
        {
           
        }

 
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = 
                Clipboard.GetText();
        }
    }
}
