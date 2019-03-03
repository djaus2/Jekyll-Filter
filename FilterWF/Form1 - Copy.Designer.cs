using System;

namespace FilterWF_Copy
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbSrcFilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSrcFolder = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbStartFilterCSVList = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSkipListLines = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEndFilterCSVList2 = new System.Windows.Forms.TextBox();
            this.tbNoLinesToSkipAtStart = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSubTopic = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CategoriesComboBox = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.cbAddHeader = new System.Windows.Forms.CheckBox();
            this.cmdAddCategory = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tbSeperator = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.chkJustrDoneConversion = new System.Windows.Forms.CheckBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbHtmlTitle = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(12, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get new File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSrcFilename
            // 
            this.tbSrcFilename.Location = new System.Drawing.Point(251, 67);
            this.tbSrcFilename.Name = "tbSrcFilename";
            this.tbSrcFilename.Size = new System.Drawing.Size(213, 20);
            this.tbSrcFilename.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filename:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder:";
            // 
            // tbSrcFolder
            // 
            this.tbSrcFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSrcFolder.Location = new System.Drawing.Point(251, 98);
            this.tbSrcFolder.Name = "tbSrcFolder";
            this.tbSrcFolder.Size = new System.Drawing.Size(829, 20);
            this.tbSrcFolder.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Location = new System.Drawing.Point(14, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Apply Filters";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbStartFilterCSVList
            // 
            this.tbStartFilterCSVList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStartFilterCSVList.Location = new System.Drawing.Point(253, 215);
            this.tbStartFilterCSVList.Name = "tbStartFilterCSVList";
            this.tbStartFilterCSVList.Size = new System.Drawing.Size(829, 20);
            this.tbStartFilterCSVList.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start Filter (Start after this):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Skip Filter (Skip ines with):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "End Fiter (End at this):";
            // 
            // tbSkipListLines
            // 
            this.tbSkipListLines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSkipListLines.Location = new System.Drawing.Point(253, 243);
            this.tbSkipListLines.Multiline = true;
            this.tbSkipListLines.Name = "tbSkipListLines";
            this.tbSkipListLines.Size = new System.Drawing.Size(829, 96);
            this.tbSkipListLines.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "No. lines to include at start:";
            // 
            // tbEndFilterCSVList2
            // 
            this.tbEndFilterCSVList2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEndFilterCSVList2.Location = new System.Drawing.Point(254, 359);
            this.tbEndFilterCSVList2.Name = "tbEndFilterCSVList2";
            this.tbEndFilterCSVList2.Size = new System.Drawing.Size(828, 20);
            this.tbEndFilterCSVList2.TabIndex = 11;
            // 
            // tbNoLinesToSkipAtStart
            // 
            this.tbNoLinesToSkipAtStart.Location = new System.Drawing.Point(254, 398);
            this.tbNoLinesToSkipAtStart.Name = "tbNoLinesToSkipAtStart";
            this.tbNoLinesToSkipAtStart.Size = new System.Drawing.Size(80, 20);
            this.tbNoLinesToSkipAtStart.TabIndex = 13;
            this.tbNoLinesToSkipAtStart.Text = "0";
            // 
            // tbOutput
            // 
            this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.Location = new System.Drawing.Point(-4, 537);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOutput.Size = new System.Drawing.Size(1117, 230);
            this.tbOutput.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Location = new System.Drawing.Point(14, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 42);
            this.button3.TabIndex = 15;
            this.button3.Text = "Save As";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Topic";
            // 
            // tbTopic
            // 
            this.tbTopic.Location = new System.Drawing.Point(253, 438);
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.Size = new System.Drawing.Size(519, 20);
            this.tbTopic.TabIndex = 18;
            this.tbTopic.Text = "Topic";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "SubTopic";
            // 
            // tbSubTopic
            // 
            this.tbSubTopic.Location = new System.Drawing.Point(253, 471);
            this.tbSubTopic.Name = "tbSubTopic";
            this.tbSubTopic.Size = new System.Drawing.Size(284, 20);
            this.tbSubTopic.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 506);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Category";
            // 
            // CategoriesComboBox
            // 
            this.CategoriesComboBox.FormattingEnabled = true;
            this.CategoriesComboBox.Location = new System.Drawing.Point(256, 503);
            this.CategoriesComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.CategoriesComboBox.Name = "CategoriesComboBox";
            this.CategoriesComboBox.Size = new System.Drawing.Size(281, 21);
            this.CategoriesComboBox.TabIndex = 24;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightCoral;
            this.button6.Location = new System.Drawing.Point(12, 98);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 42);
            this.button6.TabIndex = 25;
            this.button6.Text = "Load/Reload  this File:";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cbAddHeader
            // 
            this.cbAddHeader.AutoSize = true;
            this.cbAddHeader.Checked = true;
            this.cbAddHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAddHeader.Location = new System.Drawing.Point(555, 473);
            this.cbAddHeader.Margin = new System.Windows.Forms.Padding(1);
            this.cbAddHeader.Name = "cbAddHeader";
            this.cbAddHeader.Size = new System.Drawing.Size(104, 17);
            this.cbAddHeader.TabIndex = 26;
            this.cbAddHeader.Text = "Add Header Info";
            this.cbAddHeader.UseVisualStyleBackColor = true;
            // 
            // cmdAddCategory
            // 
            this.cmdAddCategory.BackColor = System.Drawing.Color.LightCoral;
            this.cmdAddCategory.Location = new System.Drawing.Point(555, 506);
            this.cmdAddCategory.Name = "cmdAddCategory";
            this.cmdAddCategory.Size = new System.Drawing.Size(86, 20);
            this.cmdAddCategory.TabIndex = 27;
            this.cmdAddCategory.Text = "Add Category";
            this.cmdAddCategory.UseVisualStyleBackColor = false;
            this.cmdAddCategory.Visible = false;
            this.cmdAddCategory.Click += new System.EventHandler(this.cmdAddCategory_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.Location = new System.Drawing.Point(14, 503);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 20);
            this.button4.TabIndex = 28;
            this.button4.Text = "Remove  Category";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCoral;
            this.button5.Location = new System.Drawing.Point(674, 485);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 41);
            this.button5.TabIndex = 29;
            this.button5.Text = "Update YAML";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightCoral;
            this.button7.Location = new System.Drawing.Point(12, 153);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 54);
            this.button7.TabIndex = 30;
            this.button7.Text = "AutoGen Topic Pages";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tbSeperator
            // 
            this.tbSeperator.Location = new System.Drawing.Point(352, 157);
            this.tbSeperator.Name = "tbSeperator";
            this.tbSeperator.Size = new System.Drawing.Size(55, 20);
            this.tbSeperator.TabIndex = 31;
            this.tbSeperator.Text = "@@@";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "AutoGen Topic-Blurb Seperator:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(186, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Need to select a Category first";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(432, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(254, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Generate a set of posts on same topic and cetegory.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(432, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(201, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Give each a subtopic and optional blurb..";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(432, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(340, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Alt. Each a separte heading, but common Category; and optional blurb.";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightCoral;
            this.button8.Location = new System.Drawing.Point(483, 50);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 42);
            this.button8.TabIndex = 37;
            this.button8.Text = "Convert Word2MD";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // chkJustrDoneConversion
            // 
            this.chkJustrDoneConversion.AutoSize = true;
            this.chkJustrDoneConversion.Location = new System.Drawing.Point(18, 415);
            this.chkJustrDoneConversion.Name = "chkJustrDoneConversion";
            this.chkJustrDoneConversion.Size = new System.Drawing.Size(130, 17);
            this.chkJustrDoneConversion.TabIndex = 38;
            this.chkJustrDoneConversion.Text = "Just Done Conversion";
            this.chkJustrDoneConversion.UseVisualStyleBackColor = true;
            this.chkJustrDoneConversion.CheckedChanged += new System.EventHandler(this.chkJustrDoneConversion_CheckedChanged);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightCoral;
            this.button9.Location = new System.Drawing.Point(634, 50);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(152, 42);
            this.button9.TabIndex = 39;
            this.button9.Text = "Clear _word & _html folders";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LightCoral;
            this.button10.Location = new System.Drawing.Point(627, 124);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(133, 30);
            this.button10.TabIndex = 40;
            this.button10.Text = "Convert web page to MD";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(251, 130);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(213, 20);
            this.tbUrl.TabIndex = 41;
            this.tbUrl.Text = "http://pandoc.org/index.html";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(187, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Web Url:";
            // 
            // tbHtmlTitle
            // 
            this.tbHtmlTitle.Location = new System.Drawing.Point(475, 130);
            this.tbHtmlTitle.Name = "tbHtmlTitle";
            this.tbHtmlTitle.Size = new System.Drawing.Size(146, 20);
            this.tbHtmlTitle.TabIndex = 43;
            this.tbHtmlTitle.Text = "Pandoc";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightCoral;
            this.button11.Location = new System.Drawing.Point(787, 124);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(133, 30);
            this.button11.TabIndex = 44;
            this.button11.Text = "Local html page to MD";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Visible = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 761);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.tbHtmlTitle);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.chkJustrDoneConversion);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbSeperator);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cmdAddCategory);
            this.Controls.Add(this.cbAddHeader);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.CategoriesComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbSubTopic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTopic);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbNoLinesToSkipAtStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEndFilterCSVList2);
            this.Controls.Add(this.tbSkipListLines);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbStartFilterCSVList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbSrcFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSrcFilename);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Filter Markdown File";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSrcFilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSrcFolder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbStartFilterCSVList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSkipListLines;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEndFilterCSVList2;
        private System.Windows.Forms.TextBox tbNoLinesToSkipAtStart;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTopic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSubTopic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CategoriesComboBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox cbAddHeader;
        private System.Windows.Forms.Button cmdAddCategory;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox tbSeperator;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.CheckBox chkJustrDoneConversion;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbHtmlTitle;
        private System.Windows.Forms.Button button11;
    }
}

