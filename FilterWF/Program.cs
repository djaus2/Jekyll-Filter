using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.RepresentationModel;

namespace FilterWF
{
    public class Categoryx
    {
        public string Name { get; set; } = "";
        public string Abbrev { get; set; } = "";

        public Categoryx(string name, string abbrev)
        {
            Name = name;
            Abbrev = abbrev;
        }
    }
    static class Program
    {
        public static string[] Categories;
        public static List<Categoryx> Categorys = new List<Categoryx>();

        public static string srcPath { get; set; } = "";

        public static string srcFilename { get; set; } = "";
        public static string srcFolder { get; set; } = "";
        
        public static string topic { get; set; } = "";

        public static string subTopic { get; set; } = "";

        public static string category { get; set; } = "";
        public static string startFilters { get;  set; } = "";
        public static string skipFilters { get;  set; } = "";
        public static string endFilters { get;  set; } = "";
        public static string categories { get; set; } = "";

        public static string   WorkingDirectory { get; set; } = "";

        public static string BatDir { get; set; } = "";
        public static string BlogSiteRoot { get; set; } = "";
        public static string tbSeperator_Text { get;
            set; } = "@@@";
        public static string ymlPath { get; private set; }
        public static bool firstRun { get; private set; }
        public static bool CategorisIn_data { get; internal set; }
        public static List<string> Layouts { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Properties.Settings.Default.Reload();


            WorkingDirectory = Environment.CurrentDirectory;
            BatDir = Path.Combine(WorkingDirectory, "Bat");
            // or: Directory.GetCurrentDirectory() gives the same result

            // This will get the current PROJECT directory
            string blogSiteRoot = Properties.Settings.Default.BlogSiteRoot;
            string initblogSiteRoot = Properties.Settings.Default.CBlogSiteRoot;
            CategorisIn_data = Properties.Settings.Default.CategorisIn_data;

            //string blogSiteRoot = (string)Properties.Settings.Default["BlogSiteRoot"];
            //string initblogSiteRoot = (string)Properties.Settings.Default["CBlogSiteRoot"];
            //CategorisIn_data  = (bool)Properties.Settings.Default["CategorisIn_data"];

            if (blogSiteRoot == initblogSiteRoot)
                firstRun = true;
            else
                firstRun = false;
            if (firstRun)
            {
                frmSettings frmSettings = new frmSettings();
                frmSettings.ShowDialog();
            }
/*#if DEBUG
            blogSiteRoot = Directory.GetParent(WorkingDirectory).Parent.FullName;
            blogSiteRoot = Path.Combine("..\\..", blogSiteRoot);
            DirectoryInfo di = new DirectoryInfo(blogSiteRoot);
            di = (di.Parent).Parent;
            blogSiteRoot = di.FullName;




#else
           //string  blogSiteRoot = Environment.GetEnvironmentVariable("BLOGSITEROOT");
           //blogSiteRoot = Properties.Settings.Default["BlogSiteRoot"]
#endif*/
            BlogSiteRoot = blogSiteRoot;
            Layouts = new List<string>();
            string layoutsFolder = Path.Combine(BlogSiteRoot, "_layouts");
            if (Directory.Exists(layoutsFolder))
            {
                string[] layoutsArray = Directory.GetFiles(layoutsFolder, "*.html");
                var layoutnames = from l in layoutsArray select  Path.GetFileNameWithoutExtension(l);
                Layouts = layoutnames.ToList<string>();
                if (Layouts.Contains("post"))
                {
                    Layouts.Remove("postpage");
                    Layouts.Insert(0, "postpage");
                }
                if (Layouts.Contains("default"))
                {
                    Layouts.Remove("post");
                    Layouts.Insert(0, "post");
                }
                if (Layouts.Contains("default"))
                {
                    Layouts.Remove("default");
                    Layouts.Insert(0, "default");
                }
                if (Layouts.Contains("page"))
                {
                    Layouts.Remove("page");
                    Layouts.Insert(0, "page");
                }
            }
            if (Layouts.Count == 0)
                Layouts.AddRange(new List<string>() { "default", "page" });

            LoadYaml();

            try
            {

                for (int i=0; i< args.Length-1; i=i+2)
                {
                    switch(args[i].ToLower())
                    {
                        case "filename":
                        case "-fn":
                            srcFilename = args[i+1];
                            srcPath = Path.Combine(srcFilename, srcFilename);
                            break;
                        case "directory":
                        case "-d":
                            srcFolder = args[i+1];
                            srcPath = Path.Combine(srcFolder, srcFilename);
                            break;
                        case "path":
                        case "-p":
                            string pth  = args[i + 1];
                            //MessageBox.Show(pth);
                            srcFilename = Path.GetFileName(pth);
                            //MessageBox.Show(srcFilename);
                            srcPath = Path.GetFullPath(srcFilename);
                            //MessageBox.Show(srcPath);
                            srcFolder = srcPath.Replace("\\"+ srcFilename,"");
                            //MessageBox.Show(srcFolder);
                            break;
                        case "topic":
                        case "-t":
                            topic = args[i+1];
                            break;
                        case "subtopic":
                        case "-st":
                            subTopic = args[i+1];
                            break;
                        case "category":
                        case "-cat":
                            category = args[i+1];
                            break;
                        case "categories":
                        case "-cats":
                            categories = args[i + 1];
                            break;
                        case "startFilter":
                        case "-sf":
                            startFilters = args[i + 1];
                            break;
                        case "skipFilter":
                        case "-skip":
                            skipFilters = args[i + 1];
                            break;
                        case "endFilter":
                        case "-ef":
                            endFilters = args[i + 1];
                            break;
                    }
                }
                Application.Run(new MDIParent1());
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void LoadYaml()
        {

            tbSeperator_Text = "@@@";

            //tbSrcFilename.Text = Program.srcFilename;
            //tbSrcFolder.Text = Program.srcFolder;
            //tbTopic.Text = Program.topic;
            //tbSubTopic.Text = Program.subTopic;
            ////tbCategory.Text = Program.category;
            //tbStartFilterCSVList.Text = Program.startFilters;
            //tbSkipListLines.Text = Program.skipFilters.Replace(",", "\r\n");
            //tbEndFilterCSVList2.Text = Program.endFilters;

            //srcFilePath = Program.srcPath;

            string blogSiteRoot = Program.BlogSiteRoot;


            if (blogSiteRoot == null)
            {
                //Insert a hard coded path here if needed
                blogSiteRoot = @"C:\Users\DavidJones\source\repos\DJzBlog";// Path.Combine("..", srcFilePath);
                //blogSiteRoot = Path.Combine("..", blogSiteRoot);
            }
            if (CategorisIn_data)
            {
                ymlPath = Path.Combine(blogSiteRoot, "_data");
                ymlPath = Path.Combine(ymlPath, "sections.yml");
            }
            else
            {
                ymlPath = Path.Combine(blogSiteRoot, "_config.yml");
            }

            if (File.Exists(ymlPath))
            {
                using (var reader = new StreamReader(ymlPath))
                {
                    // Load the stream
                    var yaml2 = new YamlStream();
                    yaml2.Load(reader);

                    if (CategorisIn_data)
                    {

                        // Examine the stream
                        YamlSequenceNode rootNode1 =
                           (YamlSequenceNode)yaml2.Documents[0].RootNode;
                        //YamlMappingNode rootNode =
                        //(YamlMappingNode)yaml2.Documents[0].RootNode;
                        //YamlDotNet.RepresentationModel.YamlNode sections = rootNode["sections"];


                        //if (sections.NodeType == YamlNodeType.Sequence)
                        //{
                        //    YamlSequenceNode ysn = (YamlSequenceNode)sections;

                        //        ysn.Children.Clear();
                        //    var sd = new YamlSequenceNode();
                        //    sd.Add("embed");
                        //    sd.Add("Embedded");
                        //    ysn.Add(sd);
                        //}

                        var sectionsList = rootNode1.Children.ToList();
                        //xx.Add(new YamlNode());

                        for (int i = 0; i < sectionsList.Count(); i++)
                        //for (int i = 0; i < sections.AllNodes.Count(); i++)
                        {
                            //if ( (sectionsList[i]).Count() == 2)
                            {
                                try
                                {
                                    YamlNode section = sectionsList[i];
                                    if (section.NodeType == YamlNodeType.Sequence)
                                    {
                                        YamlSequenceNode ysn = (YamlSequenceNode)section;
                                        if (ysn.Children.Count == 2)
                                        {
                                            //ysn.Children.Add
                                            if (section[0].NodeType == YamlNodeType.Scalar)
                                            {
                                                string Name = (string)section[0];
                                                if (!string.IsNullOrEmpty(Name))
                                                {
                                                    if (section[1].NodeType == YamlNodeType.Scalar)
                                                    {
                                                        string Abbrev = (string)section[1];
                                                        if (!string.IsNullOrEmpty(Abbrev))
                                                        {
                                                            Categorys.Add(new Categoryx(Abbrev, Name));
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                catch (Exception)
                                {
                                    //First section item will catch here as its a list of all nodes.
                                    //Just ignore. Could iterate from i=1
                                    //Why does this feel like deja vu?
                                }
                            }
                        }
                    }
                    else
                    {
                        YamlMappingNode rootNode =
                            (YamlMappingNode)yaml2.Documents[0].RootNode;
                        YamlDotNet.RepresentationModel.YamlNode sections = rootNode["sections"];


                        //if (sections.NodeType == YamlNodeType.Sequence)
                        //{
                        //    YamlSequenceNode ysn = (YamlSequenceNode)sections;

                        //        ysn.Children.Clear();
                        //    var sd = new YamlSequenceNode();
                        //    sd.Add("embed");
                        //    sd.Add("Embedded");
                        //    ysn.Add(sd);
                        //}

                        var sectionsList = sections.AllNodes.ToList();
                        //xx.Add(new YamlNode());

                        for (int i = 0; i < sectionsList.Count(); i++)
                        //for (int i = 0; i < sections.AllNodes.Count(); i++)
                        {
                            //if ( (sectionsList[i]).Count() == 2)
                            {
                                try
                                {
                                    YamlNode section = sectionsList[i];
                                    if (section.NodeType == YamlNodeType.Sequence)
                                    {
                                        YamlSequenceNode ysn = (YamlSequenceNode)section;
                                        if (ysn.Children.Count == 2)
                                        {
                                            //ysn.Children.Add
                                            if (section[0].NodeType == YamlNodeType.Scalar)
                                            {
                                                string Name = (string)section[0];
                                                if (!string.IsNullOrEmpty(Name))
                                                {
                                                    if (section[1].NodeType == YamlNodeType.Scalar)
                                                    {
                                                        string Abbrev = (string)section[1];
                                                        if (!string.IsNullOrEmpty(Abbrev))
                                                        {
                                                            Categorys.Add(new Categoryx(Abbrev, Name));
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                catch (Exception)
                                {
                                    //First section item will catch here as its a list of all nodes.
                                    //Just ignore. Could iterate from i=1

                                }
                            }
                        }
                    }

                }
                //var cats = from c in Categorys select c.Name;
                //CategoriesComboBox.Items.AddRange(cats.ToArray());
            }
            else
            {
                Categories = Program.categories.Split(new char[] { ',' });

                //CategoriesComboBox.Items.AddRange(Categories);
                //if (Program.category != "")
                //{
                //    if (Categories.ToList().Contains(Program.category))
                //        CategoriesComboBox.SelectedItem = Program.category;
                //}
            }
            var cats = from c in Categorys select c.Abbrev;
            Categories = cats.ToArray();
        }
        
    }
}
