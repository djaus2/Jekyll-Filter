using System;
using System.IO;
using System.Windows.Forms;

namespace FilterWF
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            if (Program.firstRun)
                this.textBox1.Text = @"c:\";
            else
                this.textBox1.Text = Program.BlogSiteRoot;
            checkBox1.Checked = Program.CategorisIn_data;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdlg = new FolderBrowserDialog();
            fdlg.SelectedPath = this.textBox1.Text;
            fdlg.Description =
            "Select the root directory of your Jekyll Blog Site.";
            fdlg.ShowNewFolderButton = false;
            if (!Directory.Exists(fdlg.SelectedPath))
            {
                fdlg.SelectedPath = Program.BlogSiteRoot;
                if (!Directory.Exists(fdlg.SelectedPath))
                {
                    fdlg.RootFolder = Environment.SpecialFolder.MyDocuments;
                }
            }


            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = fdlg.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.BlogSiteRoot =
                    this.textBox1.Text;
            Program.CategorisIn_data = checkBox1.Checked;

            Properties.Settings.Default.BlogSiteRoot = Program.BlogSiteRoot;
            Properties.Settings.Default.CategorisIn_data = Program.CategorisIn_data;

            Properties.Settings.Default.Save(); 

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();
            MessageBox.Show("Reset Settings", "You should now restart the app,", MessageBoxButtons.OK);
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
