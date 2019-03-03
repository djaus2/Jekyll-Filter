namespace FilterWF
{
    partial class frmGenerateSeqOfBlogs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
  
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.txtSubTopics = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCategory2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTopic
            // 
            this.txtTopic.Location = new System.Drawing.Point(113, 12);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(289, 20);
            this.txtTopic.TabIndex = 0;
            this.txtTopic.Text = "Topic";
            // 
            // txtSubTopics
            // 
            this.txtSubTopics.Location = new System.Drawing.Point(113, 106);
            this.txtSubTopics.Multiline = true;
            this.txtSubTopics.Name = "txtSubTopics";
            this.txtSubTopics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSubTopics.Size = new System.Drawing.Size(289, 117);
            this.txtSubTopics.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Topic:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SubTopics";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Category";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCategory2
            // 
            this.txtCategory2.Location = new System.Drawing.Point(113, 43);
            this.txtCategory2.Name = "txtCategory2";
            this.txtCategory2.Size = new System.Drawing.Size(289, 20);
            this.txtCategory2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tags:";
            // 
            // txtTags
            // 
            this.txtTags.Location = new System.Drawing.Point(113, 69);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(289, 20);
            this.txtTags.TabIndex = 8;
            this.txtTags.Text = "Tags";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 312);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 370);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 11;
            // 
            // frmGenerateSeqOfBlogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 468);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTags);
            this.Controls.Add(this.txtCategory2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubTopics);
            this.Controls.Add(this.txtTopic);
            this.Name = "frmGenerateSeqOfBlogs";
            this.Text = "Add Set of Blogs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.TextBox txtTopic;
        internal System.Windows.Forms.TextBox txtSubTopics;
        private System.Windows.Forms.TextBox txtTags;
        internal System.Windows.Forms.TextBox txtCategory2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
    }
}