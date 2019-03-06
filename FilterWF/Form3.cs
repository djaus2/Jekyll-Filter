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
    public partial class Form3 : Form
    {
        public static string[] Categories = new string[0];
        

        public Form3()
        {
            InitializeComponent();

            comboBoxCategories.Items.AddRange(Categories);
            //this.comboBox1.SelectedIndex = 0;
        }

        public bool IsPost { get { return (comboBox1.SelectedIndex == 0); } set { if (value) { comboBox1.SelectedIndex = 0; } else { comboBox1.SelectedIndex = 1; } } }

        public bool IsDisqus { get { return checkBox1.Checked == true; } set { checkBox1.Checked = value; } }
        public string Topic { get { return textBox1.Text; } set { textBox1.Text = value; } }
        public string Cat { get { return (string)comboBoxCategories.SelectedItem; } set { comboBoxCategories.SelectedItem = value; } }
        public string Tags { get { return textBox3.Text; } set { textBox3.Text = value; } }

        public string SubTopics { get { return textBox4.Text; } set { textBox4.Text = value; } }
        public DateTime Date { get { return this.dateTimePicker1.Value; } }

        public bool TopicAndSubTopics { get { return checkBox2.Checked == true; } set { checkBox2.Checked = value; } }
        public bool HeadingsAndBlurbs { get { return checkBox3.Checked == true; } set { checkBox3.Checked = value; } }

        public string Seperator { get { return tbSeperator.Text; } set { tbSeperator.Text = value; } }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (comboBoxCategories.SelectedIndex != -1) && (textBox4.Text != ""))
                this.DialogResult = DialogResult.OK;
            else if ((!TopicAndSubTopics) && (comboBoxCategories.SelectedIndex != -1) && (textBox4.Text != ""))
                this.DialogResult = DialogResult.OK;
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Add a Category", string.Format("Please add a Topic, Category and SubTopics first."), buttons);
                return;
            }

            MDIParent1.Form3Close(this.DialogResult);
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            MDIParent1.Form3Close(this.DialogResult);
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox2.Text = "Topic and SubTopics";
                textBox1.Enabled = true;
                label1.Enabled = true;
            }
            else
            {
                checkBox2.Text = "Titles only";
                textBox1.Enabled = false;
                label1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text += tbSeperator.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
