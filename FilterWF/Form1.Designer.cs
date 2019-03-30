using System;

namespace FilterWF
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbSrcFilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSrcFolder = new System.Windows.Forms.TextBox();
            this.tbStartFilterCSVList = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSkipListLines = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEndFilterCSVList2 = new System.Windows.Forms.TextBox();
            this.tbNoLinesToSkipAtStart = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSubTopic = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CategoriesComboBox = new System.Windows.Forms.ComboBox();
            this.cbAddHeader = new System.Windows.Forms.CheckBox();
            this.chkJustrDoneConversion = new System.Windows.Forms.CheckBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbHtmlTitle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.tbAuth = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbLang = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbTags = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbExcerptSep = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSrcFilename
            // 
            this.tbSrcFilename.Location = new System.Drawing.Point(162, 7);
            this.tbSrcFilename.Name = "tbSrcFilename";
            this.tbSrcFilename.Size = new System.Drawing.Size(316, 20);
            this.tbSrcFilename.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filename:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder:";
            // 
            // tbSrcFolder
            // 
            this.tbSrcFolder.Location = new System.Drawing.Point(162, 38);
            this.tbSrcFolder.Name = "tbSrcFolder";
            this.tbSrcFolder.Size = new System.Drawing.Size(516, 20);
            this.tbSrcFolder.TabIndex = 4;
            // 
            // tbStartFilterCSVList
            // 
            this.tbStartFilterCSVList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStartFilterCSVList.Location = new System.Drawing.Point(163, 30);
            this.tbStartFilterCSVList.Name = "tbStartFilterCSVList";
            this.tbStartFilterCSVList.Size = new System.Drawing.Size(1526, 20);
            this.tbStartFilterCSVList.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start Filter (Start after this):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Skip Filter (Skip ines with):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "End Fiter (End at this):";
            // 
            // tbSkipListLines
            // 
            this.tbSkipListLines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSkipListLines.Location = new System.Drawing.Point(163, 58);
            this.tbSkipListLines.Multiline = true;
            this.tbSkipListLines.Name = "tbSkipListLines";
            this.tbSkipListLines.Size = new System.Drawing.Size(1526, 87);
            this.tbSkipListLines.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "No. lines to include at start:";
            // 
            // tbEndFilterCSVList2
            // 
            this.tbEndFilterCSVList2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEndFilterCSVList2.Location = new System.Drawing.Point(164, 161);
            this.tbEndFilterCSVList2.Name = "tbEndFilterCSVList2";
            this.tbEndFilterCSVList2.Size = new System.Drawing.Size(1525, 20);
            this.tbEndFilterCSVList2.TabIndex = 11;
            // 
            // tbNoLinesToSkipAtStart
            // 
            this.tbNoLinesToSkipAtStart.Location = new System.Drawing.Point(164, 200);
            this.tbNoLinesToSkipAtStart.Name = "tbNoLinesToSkipAtStart";
            this.tbNoLinesToSkipAtStart.Size = new System.Drawing.Size(80, 20);
            this.tbNoLinesToSkipAtStart.TabIndex = 13;
            this.tbNoLinesToSkipAtStart.Text = "0";
            // 
            // tbOutput
            // 
            this.tbOutput.AcceptsReturn = true;
            this.tbOutput.AcceptsTab = true;
            this.tbOutput.AllowDrop = true;
            this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.Location = new System.Drawing.Point(4, 161);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOutput.Size = new System.Drawing.Size(964, 279);
            this.tbOutput.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Topic";
            // 
            // tbTopic
            // 
            this.tbTopic.Location = new System.Drawing.Point(163, 15);
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.Size = new System.Drawing.Size(519, 20);
            this.tbTopic.TabIndex = 18;
            this.tbTopic.Text = "Topic";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "SubTopic";
            // 
            // tbSubTopic
            // 
            this.tbSubTopic.Location = new System.Drawing.Point(163, 48);
            this.tbSubTopic.Name = "tbSubTopic";
            this.tbSubTopic.Size = new System.Drawing.Size(519, 20);
            this.tbSubTopic.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Category";
            // 
            // CategoriesComboBox
            // 
            this.CategoriesComboBox.FormattingEnabled = true;
            this.CategoriesComboBox.Location = new System.Drawing.Point(166, 80);
            this.CategoriesComboBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CategoriesComboBox.Name = "CategoriesComboBox";
            this.CategoriesComboBox.Size = new System.Drawing.Size(281, 21);
            this.CategoriesComboBox.TabIndex = 24;
            // 
            // cbAddHeader
            // 
            this.cbAddHeader.AutoSize = true;
            this.cbAddHeader.Checked = true;
            this.cbAddHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAddHeader.Location = new System.Drawing.Point(38, 96);
            this.cbAddHeader.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbAddHeader.Name = "cbAddHeader";
            this.cbAddHeader.Size = new System.Drawing.Size(104, 17);
            this.cbAddHeader.TabIndex = 26;
            this.cbAddHeader.Text = "Add Header Info";
            this.cbAddHeader.UseVisualStyleBackColor = true;
            // 
            // chkJustrDoneConversion
            // 
            this.chkJustrDoneConversion.AutoSize = true;
            this.chkJustrDoneConversion.Location = new System.Drawing.Point(515, 10);
            this.chkJustrDoneConversion.Name = "chkJustrDoneConversion";
            this.chkJustrDoneConversion.Size = new System.Drawing.Size(130, 17);
            this.chkJustrDoneConversion.TabIndex = 38;
            this.chkJustrDoneConversion.Text = "Just Done Conversion";
            this.chkJustrDoneConversion.UseVisualStyleBackColor = true;
            this.chkJustrDoneConversion.CheckedChanged += new System.EventHandler(this.chkJustrDoneConversion_CheckedChanged);
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(162, 70);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(213, 20);
            this.tbUrl.TabIndex = 41;
            this.tbUrl.Text = "http://pandoc.org/index.html";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(98, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Web Url:";
            // 
            // tbHtmlTitle
            // 
            this.tbHtmlTitle.Location = new System.Drawing.Point(386, 70);
            this.tbHtmlTitle.Name = "tbHtmlTitle";
            this.tbHtmlTitle.Size = new System.Drawing.Size(146, 20);
            this.tbHtmlTitle.TabIndex = 43;
            this.tbHtmlTitle.Text = "Pandoc";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.tbStartFilterCSVList);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbSkipListLines);
            this.groupBox1.Controls.Add(this.tbEndFilterCSVList2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbNoLinesToSkipAtStart);
            this.groupBox1.Controls.Add(this.cbAddHeader);
            this.groupBox1.Location = new System.Drawing.Point(0, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 192);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            this.groupBox1.VisibleChanged += new System.EventHandler(this.groupBox1_VisibleChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.tbExcerptSep);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbAuth);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbDate);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbLang);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.tbTags);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbTopic);
            this.groupBox2.Controls.Add(this.tbSubTopic);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CategoriesComboBox);
            this.groupBox2.Controls.Add(this.tbOutput);
            this.groupBox2.Location = new System.Drawing.Point(0, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(964, 440);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(683, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Set Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(741, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker1.TabIndex = 50;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(700, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Misc. Info:";
            // 
            // tbAuth
            // 
            this.tbAuth.Location = new System.Drawing.Point(740, 83);
            this.tbAuth.Name = "tbAuth";
            this.tbAuth.Size = new System.Drawing.Size(212, 20);
            this.tbAuth.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(695, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Author:";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(740, 51);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(212, 20);
            this.tbDate.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(700, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Date: ";
            // 
            // tbLang
            // 
            this.tbLang.Location = new System.Drawing.Point(740, 19);
            this.tbLang.Name = "tbLang";
            this.tbLang.Size = new System.Drawing.Size(54, 20);
            this.tbLang.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(700, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Lang:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(112, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Tags";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(806, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(146, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Enable Disqus Comments";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(512, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Layout: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(580, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 21);
            this.comboBox1.TabIndex = 28;
            // 
            // tbTags
            // 
            this.tbTags.Location = new System.Drawing.Point(166, 121);
            this.tbTags.Name = "tbTags";
            this.tbTags.Size = new System.Drawing.Size(350, 20);
            this.tbTags.TabIndex = 27;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(522, 124);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 52;
            this.label18.Text = "Excerpt Sep:";
            // 
            // tbExcerptSep
            // 
            this.tbExcerptSep.Location = new System.Drawing.Point(596, 121);
            this.tbExcerptSep.Name = "tbExcerptSep";
            this.tbExcerptSep.Size = new System.Drawing.Size(86, 20);
            this.tbExcerptSep.TabIndex = 46;
            this.tbExcerptSep.Text = "<!--more-->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(964, 614);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbHtmlTitle);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.chkJustrDoneConversion);
            this.Controls.Add(this.tbSrcFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSrcFilename);
            this.Name = "Form1";
            this.Text = "Filter Markdown File";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.TextBox tbSrcFilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSrcFolder;
        private System.Windows.Forms.TextBox tbStartFilterCSVList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSkipListLines;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEndFilterCSVList2;
        private System.Windows.Forms.TextBox tbNoLinesToSkipAtStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTopic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSubTopic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CategoriesComboBox;
        private System.Windows.Forms.CheckBox cbAddHeader;
        private System.Windows.Forms.CheckBox chkJustrDoneConversion;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbHtmlTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbTags;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbLang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAuth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbExcerptSep;
        private System.Windows.Forms.Label label18;
    }
}

