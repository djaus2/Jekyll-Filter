using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shell32;

namespace FilterWF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            //webBrowser1.attachEvent("load", function() {
            //    // Set a timeout...
            //    setTimeout(function() {
            //        // Hide the address bar!
            //        window.scrollTo(0, 1);
            //    }, 0);
            //});
        }

        string filename = "";


        // Navigates to the URL in the address box when 
        // the ENTER key is pressed while the ToolStripTextBox has focus.
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(textBox1.Text);

            }
        }

            // Navigates to the URL in the address box when 
            // the Go button is clicked.
            private void goButton_Click(object sender, EventArgs e)
        {
            Navigate(textBox1.Text);
        }

        // Navigates to the given URL if it is valid.
        private void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                webBrowser1.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        // Updates the URL in TextBoxAddress upon navigation.
        private void webBrowser1_Navigated(object sender,
            WebBrowserNavigatedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            goButton_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start()
            //Shell32.Shell shell = new Shell32.Shell();
            //object[] args = new object[] { "-f html", "-t markdown", "http://xamarin101.sportronics.com.au/","-o twoone.md" };
            //string param = "-f html -t markdown   http://xamarin101.sportronics.com.au -o one.md";
            //shell.ShellExecute("pandoc", args,);
            //this.Close();
        }

        //private Shell32.Folder GetShell32Folder(string folderPath)
        //{
        //    Shell32.
        //    Type shellAppType = Type.GetTypeFromProgID("Shell.Application");
        //    Object shell = Activator.CreateInstance(shellAppType);
        //    return (Shell32.Folder)shellAppType.InvokeMember("NameSpace",
        //    System.Reflection.BindingFlags.InvokeMethod, null, shell, new object[] { folderPath });
        //}
    }

}


