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
    public partial class frmwebBrowser : Form
    {
        public string PathStr { get; set; }
        public frmwebBrowser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Cursor oldCursor;
        private void webBrowser_Load(object sender, EventArgs e)
        {
            try
            {
                //string path = "file:///" + PathStr;
                //webBrowser1.Navigate(new Uri(path));
                textBox1.Text = PathStr;
                textBox1.ReadOnly = true;
                string path = String.Format("file:///{0}", PathStr);
                webBrowser1.Url = new Uri( path);

            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            oldCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            Cursor.Current = oldCursor;
            MDIParent1.SetStatus("Done");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser_Load(sender, e);
        }
    }
}
