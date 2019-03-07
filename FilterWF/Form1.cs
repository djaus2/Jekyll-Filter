using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.RepresentationModel;
using RunBatch;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;

namespace FilterWF
{

    public partial class Form1 : Form
    {
        public string Url { get { return tbUrl.Text; } set { tbUrl.Text = value; } }
        public string Title { get { return tbHtmlTitle.Text; } set { tbHtmlTitle.Text = value; } }

        public string Topic { get { return tbTopic.Text; } set { tbTopic.Text = value; } }
        public string SubTopic { get { return tbSubTopic.Text; } set { tbSubTopic.Text = value; } }

        public string srcFilePath { get; set; } = "";
        public string tbSrcFolder_Text { get { return tbSrcFolder.Text; } set { tbSrcFolder.Text = value; } } 
        public string tbSrcFilename_Text { get{return tbSrcFilename.Text;} set {tbSrcFilename.Text = value;}} 

        public string filepath { get { return Path.Combine(tbSrcFolder_Text, tbSrcFilename_Text); } }

        public bool JustDoneConversion { get; set; } = false;
        public string WorkFolder { get;  set; } = "";
        public bool chkJustrDoneConversion_Checked { get { return chkJustrDoneConversion.Checked; }  set { chkJustrDoneConversion.Checked = value; } }

        public string tbUrl_Text { get { return tbUrl.Text; } set { tbUrl.Text = value; } } 

        public string tbHtmlTitle_Text { get { return tbHtmlTitle.Text; }   set { tbHtmlTitle.Text = value; } }

 

        public Form1()
        {
            InitializeComponent();

            

            tbSrcFilename.Text = Program.srcFilename;
            tbSrcFolder.Text = Program.srcFolder;
            tbTopic.Text = Program.topic;
            tbSubTopic.Text = Program.subTopic;
            //tbCategory.Text = Program.category;
            tbStartFilterCSVList.Text = Program.startFilters;
            tbSkipListLines.Text = Program.skipFilters.Replace(",", "\r\n");
            tbEndFilterCSVList2.Text = Program.endFilters;

            var cats = from c in Program.Categorys select c.Name;
            CategoriesComboBox.Items.AddRange(cats.ToArray());

            srcFilePath = Program.srcPath;
            groupBox1.Visible = false;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            //tbSrcFilename.Text = "";
            //textBox2.Text = "";
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select Markdown file to filter";
            fdlg.InitialDirectory = Path.Combine(
               Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
               "");
            if (tbSrcFolder.Text != "")
                fdlg.InitialDirectory = tbSrcFolder.Text;
            if (JustDoneConversion)
                fdlg.InitialDirectory = Path.Combine(Program.BlogSiteRoot, WorkFolder);
            // fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Markdown (*.md)|*.md|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                srcFilePath = fdlg.FileName;
                tbSrcFilename.Text = Path.GetFileName(srcFilePath);
                tbSrcFolder.Text = Path.GetFullPath(srcFilePath).Replace(tbSrcFilename.Text,"");

                LoadFile();
            }
        }

        public void LoadFile()
        {
            if (File.Exists(srcFilePath))
            {
                tbSrcFilename.Text = Path.GetFileName(srcFilePath);
                tbSrcFolder.Text = Path.GetFullPath(srcFilePath).Replace(tbSrcFilename.Text, ""); ;

                Output("__CLEAR__");
                using (StreamReader sr = File.OpenText(srcFilePath))
                    Output(sr.ReadToEnd());
                Post post = ReadHeader(tbOutput.Text);
                if (post !=null)
                {
                    tbTopic.Text = post.title;
                    tbSubTopic.Text = post.subtitle;
                    tbTags.Text = post.tags;
                    string cat = post.category;
                    var category = from n in Program.Categorys where n.Abbrev == cat select n;
                    if (category.Count()>0)
                        if (CategoriesComboBox.Items.Contains(category.First().Name))
                            CategoriesComboBox.SelectedItem = category.First().Name;

                    if (post.disqus == "1")
                        checkBox1.Checked = true;
                    else
                        checkBox1.Checked = false;

                    if (post.layout == "postpage")
                        comboBoxPostOrArticle.SelectedIndex = 0;
                    else
                        comboBoxPostOrArticle.SelectedIndex = 1;

                    if (!string.IsNullOrEmpty(post.lang))
                        tbLang.Text = post.lang;

                    if (! string.IsNullOrEmpty(post.date))
                        tbDate.Text = post.date;
                    if (!string.IsNullOrEmpty(post.author))
                        tbAuth.Text = post.author;
                }
            }
            else
            {
                string message =
                    "File doesn't exist!\r\n" + srcFilePath;
                const string caption = "Openfile";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Exclamation);
               
            }
        }

        public class Post
        {
            public Post()
            { }
            public string layout { get; set; }
            public string title { get; set; }
            public string subtitle { get; set; }
            public string category { get; set; }
            public string date { get; set; }
            public string author { get; set; }
            public string tags { get; set; }
            public string disqus { get; set; }
            public string lang { get; set; }

        }

        public Post ReadHeader(string fileText)
        {
            //Ref: https://markheath.net/post/markdown-html-yaml-front-matter
            var yamlDeserializer = new DeserializerBuilder()
                                .WithNamingConvention(new CamelCaseNamingConvention())
                                .Build();
            Post post = null;
            var text = fileText;
            try
            {
                using (var input = new StringReader(text))
                {
                    var parser = new Parser(input);
                    parser.Expect<StreamStart>();
                    parser.Expect<DocumentStart>();
                    post = yamlDeserializer.Deserialize<Post>(parser);
                    parser.Expect<DocumentEnd>();
                }
            } catch (Exception ex)
            { post = null; }
            return post;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            string[] args = new string[] {  tbSkipListLines.Text, tbStartFilterCSVList.Text, tbEndFilterCSVList2.Text };
            //Main(args);
            int skipstart = 0;
            if (!int.TryParse(tbNoLinesToSkipAtStart.Text, out skipstart))
            {
                skipstart = 0;
            }

            //FilterCls.filterMD.OutputMsg outMsg = Output;
            string[] Lines = tbOutput.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            tbOutput.Text = "";
            FilterCls.filterMD.ExecFilters(args, Output, skipstart,Lines);
        }

        private void Main(string[] args)
        {
            List<string> lineToStartAfter = new List<string>();
            bool started = true;
            List<string> linesToSkipStartingWith = new List<string>();
            List<string> linesToSkipContaining = new List<string>();
            List<string> lineToStopAt = new List<string>();

            Output("__CLEAR__");

            if (args[1].ToLower() == "help")
            {
                Output("Usage: filter [LinesToSkip] [LinesContainingToStartAt] [LinesContainingToStopAt]");
                Output("[..] are optional args.");
                Output("The second arg requires the first arg to be present");
                Output("The third arg requires the first and second args to be present");
                Output("args are either single item or a comma separated list");
                Output("Single filter lists have @ as prefix");
                Output("If any spaces, arg should be in double quotes. (Whole arg not individual, comma sperated items.)");
                Output("LinesToSkip:              + or no prefix: Any line STARTING with one of these filters is skipped.");
                Output("                          + prefix is optional for lines starting with filters.");
                Output("                          Alternative is any filter with - prefix ");
                Output("                          - prefix: Any line CONTAINING that filter is skipped.");
                Output("LinesContainingToStartAt: Lines at start are skipped until first line after line containing one of these filters.");
                Output("LinesContainingToStopAt:  Lines at end are skipped from first line (that line inluded) containing one of these filters.");
                return;
            }
            if (args.Length > 0)
            {
                if (args[0].Length > 0)
                {
                    if (args[0][0] == '@')
                    {
                        // If string starts with @ then use whole argumenet as one (can therefore have a comma)
                        linesToSkipStartingWith = new List<string> { args[0].Substring(1) };
                    }
                    linesToSkipStartingWith = (args[0].Split(new string[] { "\r","\n" }, StringSplitOptions.RemoveEmptyEntries)).ToList();
                }
            }

            //Skip lines:
            //Starting with is default. + prefix = starting with  - prefix is contains
            linesToSkipContaining = (from f in linesToSkipStartingWith where f[0] == '-' select f).ToList();
            linesToSkipStartingWith = (from f in linesToSkipStartingWith where f[0] != '-' select f).ToList();
            for (int i = 0; i < linesToSkipStartingWith.Count(); i++)
                if (linesToSkipStartingWith[i][0] == '+')
                    linesToSkipStartingWith[i] = linesToSkipStartingWith[i].Substring(1);

            if (args.Length > 1)
            {
                if (args[1].Length > 0)
                {
                    if (args[1][0] == '@')
                    {
                        // If string starts with @ then use whole argumenet as one (can therefore have a comma)
                        lineToStartAfter = new List<string> { args[1].Substring(1) };
                    }
                    lineToStartAfter = (args[1].Split(new char[] { ',' })).ToList();
                }
            }
            if (lineToStartAfter.Count() > 0)
                started = false;

            if (args.Length > 2)
            {
                if (args[2].Length > 0)
                {
                    if (args[2][0] == '@')
                    {
                        // If string starts with @ then use whole argumenet as one (can therefore have a comma)
                        lineToStopAt = new List<string> { args[2].Substring(1) };
                    }
                    lineToStopAt = (args[2].Split(new char[] { ',' })).ToList();
                }
            }


            if (File.Exists(srcFilePath))// only executes if the file at pathtofile exists//you need to add the using System.IO reference at the top of te code to use this
            {
                int skipstart = 0;
                bool stop = false;
                if (!int.TryParse(tbNoLinesToSkipAtStart.Text, out skipstart))
                {
                    skipstart = 0;
                }
                StreamReader sr = File.OpenText(srcFilePath);
                string line;
                while (((line = sr.ReadLine()) != null) && (!stop))
                {
                    if (skipstart-- > 0)
                    {
                        Output(line);
                        continue;
                    }

                    //Skip lines until
                    if (!started)
                    {
                        foreach (var f in lineToStartAfter)
                            if (line.Length >= f.Length)
                                if (line.ToLower().Contains(f.ToLower()))
                                {
                                    started = true;
                                    break;
                                }
                        if (!started)
                            continue;
                    }

                    bool skip = false;
                    //Lines to filter out starting with filter
                    foreach (var f in linesToSkipStartingWith)
                        if (line.Length >= f.Length)
                            if (line.ToLower().Substring(0, f.Length) == f.ToLower())
                            {
                                skip = true;
                                break;
                            }
                    if (skip)
                        continue;

                    skip = false;
                    //Lines to filter out containing filter
                    foreach (var f in linesToSkipContaining)
                        if (line.Length >= f.Length)
                            if (line.ToLower().Contains(f.ToLower()))
                            {
                                skip = true;
                                break;
                            }
                    if (skip)
                        continue;

                    //stopNow asserts skip finishing line
                    bool stopNow = false;
                    //Line to stop at
                    foreach (var f in lineToStopAt)
                        if (line.Length >= f.Length)
                        { 
                
                            if (line.ToLower().Contains(f.ToLower()))
                            {
                                stop = true;
                                break;
                            }
                            else
                            {
                                string subf = f.Substring(1);
                                if ((f[0]=='-') && subf != "")
                                {
                                    if (line.ToLower().Contains(subf.ToLower()))
                                    {
                                        stopNow = true;
                                        break;
                                    }
                                }
                                else if ((f[0] == '+') && subf != "")
                                {
                                    if (line.ToLower().Contains(subf.ToLower()))
                                    {
                                        stop = true;
                                        break;
                                    }
                                }

                            }

                        }

                    if (stopNow)
                        break;


                    Output(line);
                }
            }



        }


        private void Output(string line)
        {
            if (line == "__CLEAR__")
                tbOutput.Text = "";
            else
                tbOutput.Text += "\r\n" + line;
        }

        public void button3_Click(object sender, EventArgs e)
        {
            string cat = "post";
            if (CategoriesComboBox.SelectedIndex != -1)
            {
                var abbrev = from n in Program.Categorys where n.Name == (string)CategoriesComboBox.SelectedItem select n;
                if (abbrev.Count() == 1)
                    cat = abbrev.First().Abbrev;
            }
            string filenameMd = DateTime.UtcNow.ToString("yyyy-MM-dd") + "-" + tbTopic.Text.Replace(" ","-") + "-" + cat;
            SaveFileDialog fdlg = new SaveFileDialog();
            fdlg.Title = "Save Markdown file As";
            var x = Environment.CurrentDirectory;
            fdlg.InitialDirectory = Path.Combine(
               Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
               "");
            if (tbSrcFolder.Text != "")
                fdlg.InitialDirectory = tbSrcFolder.Text;
            if (Program.BlogSiteRoot != "")
                fdlg.InitialDirectory = Path.Combine(Program.BlogSiteRoot, "_" + CategoriesComboBox.SelectedItem);

            if (JustDoneConversion)
                fdlg.InitialDirectory = Path.Combine(Program.BlogSiteRoot, "_posts");

            fdlg.Filter = "Markdown (*.md)|*.md|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            fdlg.FileName = filenameMd + ".md";
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                //string header = "";
                //if (cbAddHeader.Checked == true)
                //{
                //    header = "---\r\n";
                //    header += "layout: page\r\n";
                //    if (tbTopic.Text != "")
                //        header += "title: " + tbTopic.Text + "\r\n";
                //    if (tbSubTopic.Text != "")
                //        header += "subtitle: " + tbSubTopic.Text + "\r\n";
                //    if (CategoriesComboBox.SelectedIndex != -1)
                //        header += "category: " + cat + "\r\n";
                //    header += "date: " + DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss") + "\r\n";
                //    header += "---\r\n\r\n";
                //    File.WriteAllText(fdlg.FileName, header);
                //}
                File.WriteAllText( fdlg.FileName, tbOutput.Text);                
            }
        }

        public void button3_saveexisting_Click(object sender, EventArgs e)
        {
            string filenameMd = Path.Combine(tbSrcFolder.Text, tbSrcFilename.Text);
            if (!File.Exists(filenameMd))
            {
                MessageBox.Show("File doesn't exist. Do Save As first.", "Fie Save", MessageBoxButtons.OK);
                return;
            }
            File.WriteAllText(filenameMd, tbOutput.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.ShowDialog();
        }



        private void button6_Click(object sender, EventArgs e)
        {
            srcFilePath = Path.Combine(tbSrcFolder.Text, tbSrcFilename.Text);
            LoadFile();
        }

        public void cmdAddCategory_Click(object sender, EventArgs e)
        {
            frmInputBox testDialog = new frmInputBox();
            string newCategoryName = "";
            string newCategoryAbbrev = "";

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                newCategoryName = testDialog.Cat;
                newCategoryAbbrev = testDialog.Abbrev;
                Program.Categorys.Add(new Categoryx(newCategoryAbbrev, newCategoryName));
                CategoriesComboBox.Items.Add(newCategoryName);
                button5_Click_1(null, null);
            }
            else
            {
                
            }
            testDialog.Dispose();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            if (CategoriesComboBox.SelectedIndex ==-1)
            {
                MessageBox.Show("Select a Category from the list first.");
                return;
            }
            string cat = (string)CategoriesComboBox.SelectedItem;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show("Delete a Category", string.Format("Do you really want' to delete the Category: {0}?", cat), buttons);
            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                return;
            }
            CategoriesComboBox.SelectedIndex = -1;
            CategoriesComboBox.Items.Remove(cat);
            var cats = from n in Program.Categorys where n.Name != cat select n;
            Program.Categorys = cats.ToList();
            if (CategoriesComboBox.Items.Count ==0)
            {
                CategoriesComboBox.Items.Clear();

            }
            CategoriesComboBox.Refresh();
            button5_Click_1(null, null);
        }

        public  void button5_Click_1(object sender, EventArgs e)
        {
            //YamlMappingNode rootNode;
            YamlSequenceNode rootNode;
            if (File.Exists(Program.ymlPath))
            {
                using (var reader = new StreamReader(Program.ymlPath))
                {
                    // Load the stream
                    var yaml2 = new YamlStream();
                    yaml2.Load(reader);

                    // Examine the stream
                    //rootNode =
                    //    (YamlMappingNode)yaml2.Documents[0].RootNode;
                    //YamlDotNet.RepresentationModel.YamlNode sections = rootNode["sections"];
                    rootNode =
                       (YamlSequenceNode)yaml2.Documents[0].RootNode;
                    //YamlDotNet.RepresentationModel.YamlNode sections = rootNode["sections"];

                    //if (sections.NodeType == YamlNodeType.Sequence)
                    if (rootNode.NodeType == YamlNodeType.Sequence)
                    {
                        //YamlSequenceNode ysn = (YamlSequenceNode)sections;
                        YamlSequenceNode ysn = (YamlSequenceNode)rootNode;

                        ysn.Children.Clear();
                        foreach (var cat in Program. Categorys)
                        {
                            var sd = new YamlSequenceNode();

                            YamlScalarNode sn2 = new YamlScalarNode("~" + cat.Abbrev + "~");
                            sd.Add(sn2);

                            YamlScalarNode sn = new YamlScalarNode("~" + cat.Name + "~");
                            sd.Add(sn);
                            ysn.Add(sd);
                        }
                    }
                }
                using (var writer = new StreamWriter(Program.ymlPath))
                {
                    // Load the stream
                    var yaml2 = new YamlStream();
                    yaml2.Documents.Clear();
                    var ggg = new YamlDocument(rootNode);
                    yaml2.Documents.Add(ggg);
                    yaml2.Save(writer);

                }
                string tx = "";
                using (var reader = new StreamReader(Program.ymlPath))
                {
                    tx = reader.ReadToEnd();
                    tx = tx.Replace("~", "'");
                }
                using (var writer = new StreamWriter(Program.ymlPath))
                {

                    writer.Write(tx);
                }

            }
        }

        public void button7_Click(object sender, EventArgs e)
        {
            if (CategoriesComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Category from the list first.");
                return;
            }
            string cat = (string)CategoriesComboBox.SelectedItem;

            var cats = from c in Program.Categorys select c.Name;
            Form3.Categories = cats.ToArray();


            Form3 testDialog = new Form3();
            testDialog.Cat = cat;
            testDialog.IsPost = true;
            testDialog.IsDisqus = true;
            testDialog.Seperator = Program.tbSeperator_Text;

            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the raw contents of testDialog's TextBox.
                string newTopic = testDialog.Topic;
                string newCategoryName = testDialog.Cat;
                string newTags= testDialog.Tags;
                string newSubTopics = testDialog.SubTopics;
                DateTime newDate = testDialog.Date;
                bool isPost = testDialog.IsPost;
                bool isDisqus = testDialog.IsDisqus;
                bool topicAndSubTopics = testDialog.TopicAndSubTopics;
                bool headingsAndBlurbs = testDialog.HeadingsAndBlurbs;
                ;

                //Process it
                string topic = newTopic.Trim();
                string CategoryName = newCategoryName;
                string catz = "";
                var abbrev = from n in Program.Categorys where n.Name == CategoryName select n;
                if (abbrev.Count() == 1)
                    catz = abbrev.First().Abbrev;
                string[] tags = newTags.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries); //This would have trimmed
                string[] subTopics;
                if (!topicAndSubTopics)
                {
                    topic = "";
                    subTopics = newSubTopics.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                }
                else
                {
                    subTopics = newSubTopics.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                }
                
                for (int i = 0; i < subTopics.Length; i++)
                    subTopics[i] = subTopics[i].Trim();
                

                DateTime date = newDate;
                string blurb = "The quick brown fox jumps over the lazy dog";
                string subTopicOrHeadingBlurbSep = testDialog.Seperator;

                string postslPath = Path.Combine(Program.BlogSiteRoot, "_posts");
                for (int i = 0; i < subTopics.Length; i++)
                {
                    string subtopic = subTopics[i];
                    if (headingsAndBlurbs)
                    {
                        string[] headnblurb = subtopic.Split(new string[] { subTopicOrHeadingBlurbSep }, StringSplitOptions.RemoveEmptyEntries);                        
                        blurb = subtopic.Substring(headnblurb[0].Length + subTopicOrHeadingBlurbSep.Length);
                        subtopic = headnblurb[0];
                        blurb = blurb.Trim();
                        subtopic = subtopic.Trim();
                    }
                  

                    string filename = date.ToString("yyyy-MM-dd") + "-" + CategoryName + "-" + topic + "-" + subTopics[i] + ".md";
                    date = date.AddDays(1);
                    filename = filename.Replace(" ", "-");
                    string path = Path.Combine(postslPath, filename);
                    string header = "";
                    header = "---\r\n";
                    if (isPost)
                        header += "layout: postpage\r\n";
                    else
                        header += "layout: page\r\n";
                    if (topic != "")
                    {
                        header += "title: " + topic + "\r\n";
                        if (subtopic!= "")
                            header += "subtitle: " + subtopic + "\r\n";
                    }
                    else
                    {
                        header += "title: " + subtopic + "\r\n";
                    }
                    if (newTags != "")
                        header += "tags: " + newTags + "\r\n";
                    if (CategoriesComboBox.SelectedIndex != -1)
                        header += "category: " + catz + "\r\n";
                    if (isDisqus)
                        header += "disqus: " + "1" + "\r\n";
                    else
                        header += "disqus: " + "0" + "\r\n";
                    header += "date: " + date + "\r\n";
                    header += "---\r\n\r\n";
                    header += blurb + "\r\n";
                    using (var writer = new StreamWriter(path))
                    {
                        writer.Write(header);
                    }
                }
                
            }
            else
            {

            }
            testDialog.Dispose();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            string file = "";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

               
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileFolder =  Program.BlogSiteRoot;
                    fileFolder = Path.Combine(fileFolder, "_word");
                    WorkFolder = fileFolder;
                    var fileName = openFileDialog.FileName;
                    file = Path.GetFileName(fileName);
                    string filebase = Path.GetFileNameWithoutExtension(fileName);
                    string filebasedotted = filebase.Replace(" ", "-");
                    string targfile = filebasedotted + ".docx";
                    targfile = Path.Combine(fileFolder, targfile);
                    System.IO.File.Copy(fileName,targfile ,true);
                    MessageBox.Show(fileContent, "Got File Content: " + file, MessageBoxButtons.OK);
                    PandocUtil.Word2MD(true, false, Program.BlogSiteRoot, fileFolder, targfile);//, filebase);
                    chkJustrDoneConversion.Checked = true;
                }
                
            }

           
        }


        private void chkJustrDoneConversion_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if (chk != null)
            {
                JustDoneConversion = (chk.Checked == true);
            }
        }

        public static void button_clear_all_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show( "Do you wish to delete all files in _word, _html and _drafts folders in your Jekyll site?", "Delete work folder contents", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string folder = Path.Combine(Program.BlogSiteRoot, "_word");
                    if (Directory.Exists(folder))
                    {
                        string[] files = Directory.GetFiles(folder);
                        foreach (var file in files)
                            File.Delete(file);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK);
                }
                try
                {
                    string folder = Path.Combine(Program.BlogSiteRoot, "_html");
                    if (Directory.Exists(folder))
                    {
                        string[] files = Directory.GetFiles(folder);
                        foreach (var file in files)
                            File.Delete(file);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK);
                }
                try
                {
                    string folder = Path.Combine(Program.BlogSiteRoot, "_drafts");
                    if (Directory.Exists(folder))
                    {
                        string[] files = Directory.GetFiles(folder);
                        foreach (var file in files)
                            File.Delete(file);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK);
                }
            }
        }

        public static void button_clear_drafts_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to delete all files in _drafts folder in your Jekyll site?", "Delete _drafts folder contents", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    string folder = Path.Combine(Program.BlogSiteRoot, "_drafts");
                    if (Directory.Exists(folder))
                    {
                        string[] files = Directory.GetFiles(folder);
                        foreach (var file in files)
                            File.Delete(file);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK);
                }
            }
        }

        public static void butto_clear_9word_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show( "Do you wish to delete all files in the _word folder in your Jekyll site?", "Delete _word folder contents", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string folder = Path.Combine(Program.BlogSiteRoot, "_word");
                    if (Directory.Exists(folder))
                    {
                        string[] files = Directory.GetFiles(folder);
                        foreach (var file in files)
                            File.Delete(file);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK);
                }
            }

        }

        public static void button_clear_html_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to delete all files in the _html folder in your Jekyll site?", "Delete _html folder contents", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string folder = Path.Combine(Program.BlogSiteRoot, "_html");
                    if (Directory.Exists(folder))
                    {
                        string[] files = Directory.GetFiles(folder);
                        foreach (var file in files)
                            File.Delete(file);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string html = tbUrl.Text;
            string title = tbHtmlTitle.Text;
            string fileFolder = Program.BlogSiteRoot;
            fileFolder = Path.Combine(fileFolder, "_html");
            if (!Directory.Exists(fileFolder))
                Directory.CreateDirectory(fileFolder);
            string file = Path.Combine(fileFolder, "temp.html");
            //WorkFolder = fileFolder;
            PandocUtil.Http2MD(Program.WorkingDirectory, html, file);
            chkJustrDoneConversion.Checked = true;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            string file = "";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "html files (*.html)|*.html|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileFolder = Program.BlogSiteRoot;
                    fileFolder = Path.Combine(fileFolder, "_html");
                    WorkFolder = fileFolder;
                    var fileName = openFileDialog.FileName;
                    file = Path.GetFileName(fileName);
                    string filebase = Path.GetFileNameWithoutExtension(fileName);
                    string filebasedotted = filebase.Replace(" ", "-");
                    string targfile = filebasedotted + ".html";
                    System.IO.File.Copy(fileName, Path.Combine(fileFolder, targfile), true);
                    MessageBox.Show( "Got File Content: " + file, fileContent, MessageBoxButtons.OK);
                    PandocUtil.Word2MD(false, true, Program.BlogSiteRoot, fileFolder, targfile);//, filebase);
                    chkJustrDoneConversion.Checked = true;
                    
                }

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MDIParent1.DecrementCount();
        }

        public bool  ToggleFilter()
        {
            groupBox1.Visible = !groupBox1.Visible;
            return groupBox1.Visible;
        }

        private void groupBox1_VisibleChanged_1(object sender, EventArgs e)
        {
            if (groupBox1.Visible)
            {
                groupBox2.Top = groupBox1.Top + groupBox1.Height + 10;
                groupBox2.Height -= groupBox1.Height - 10;
            }
            else
            {
                groupBox2.Top = groupBox1.Top;
                groupBox2.Height += groupBox1.Height;
                tbOutput.Height = groupBox2.Height - 120;
            }
        }

        public void AddMetaInfo()
        {
            string header = "";
            string tags = tbTags.Text;
            bool useDiscuss = ( checkBox1.Checked==true);
            bool isPost = true;
            if (comboBoxPostOrArticle.SelectedIndex != -1)
            {
                string post = (string) comboBoxPostOrArticle.SelectedItem;
                if (post != "Post")
                    isPost = true;
            }
            string cat = "";
            if (CategoriesComboBox.SelectedIndex != -1)
            {
                var abbrev = from n in Program.Categorys where n.Name == (string)CategoriesComboBox.SelectedItem select n;
                if (abbrev.Count() == 1)
                    cat = abbrev.First().Abbrev;
            }

            header = "---\r\n";
            if (isPost)
                header += "layout: postpage\r\n";
            else
                header += "layout: page\r\n";
            if (tbTopic.Text != "")
                header += "title: " + tbTopic.Text + "\r\n";
            if (tbSubTopic.Text != "")
                header += "subtitle: " + tbSubTopic.Text + "\r\n";
            if (CategoriesComboBox.SelectedIndex != -1)
                header += "category: " + cat + "\r\n";
            if (tags != "")
                header += "tags: " + tags + "\r\n";
            //if (CategoriesComboBox.SelectedIndex != -1)
            
            if (tbLang.Text != "")
                header += "lang: " + tbLang.Text + "\r\n";

            if (tbDate.Text != "")
                header += "date: " + tbDate.Text + "\r\n";

            if (tbAuth.Text != "")
                header += "author: " + tbAuth.Text + "\r\n";

            if (useDiscuss)
                header += "disqus: " + "1" + "\r\n";
            else
                header += "disqus: " + "0" + "\r\n";
            header += "---\r\n\r\n";

            tbOutput.Text = header + tbOutput.Text;
            
        }



        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            tbDate.Text = date.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }

  

}


