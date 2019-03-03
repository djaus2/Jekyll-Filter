using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunBatch
{
    public static  class PandocUtil
    {
        public static void Word2MD(bool isword, bool ishtmlNothpp, string blogSiteRoot, string pwd,string filename, string title)
        {
            string paramz = filename  + " " +  title;
            
            //string workingDir = blogSiteRoot;
            string cmd = "";
            blogSiteRoot = Path.Combine(blogSiteRoot, "bin");
            if (isword)
            {
                if (!ishtmlNothpp)
                {
                    //workingDir = Path.Combine(workingDir, "docx");
                    blogSiteRoot = Path.Combine(blogSiteRoot, "wrd2md.bat");
                    cmd = "\"" + blogSiteRoot + " " + paramz + "\"";
                }
                else
                {
                    blogSiteRoot = Path.Combine(blogSiteRoot, "md2html.bat");
                    cmd = "\"" + blogSiteRoot + " " + paramz + "\"";
                }
            }
            else //HTML2MD
            {
                if (!ishtmlNothpp)
                {
                    //orkingDir = Path.Combine(workingDir, "docx");
                    blogSiteRoot = Path.Combine(blogSiteRoot, "http2md.bat");
                    cmd = "\"" + blogSiteRoot + " " + paramz + "\"";
                }
                else
                {
                    blogSiteRoot = Path.Combine(blogSiteRoot, "html2md.bat");
                    cmd = "\"" + blogSiteRoot + " " + paramz + "\"";
                }
            }
            

            Directory.SetCurrentDirectory(pwd);

            //var processInfo = new ProcessStartInfo("cmd.exe", "/c" + "\"C:\\Program Files (x86)\AssaultCube_v1.1.0.4\assaultcube.bat\"");
            var processInfo = new ProcessStartInfo("cmd.exe", "/c" + cmd);

            processInfo.CreateNoWindow = true;

            processInfo.UseShellExecute = false;

            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);

            process.Start();

            process.WaitForExit();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            if (error != "")
                MessageBox.Show( error, "Error", MessageBoxButtons.OK);
            else
                MessageBox.Show( output ,"Info", MessageBoxButtons.OK); 
        }

        public static void MD2Html( string blogSiteRoot, string pwd, string filename, string title)
        {
            string of = Path.Combine(blogSiteRoot, pwd);
            of = Path.Combine(of, title);
            string paramz = filename + " " + of;



            //string workingDir = blogSiteRoot;
            string cmd = "";
            //Directory.SetCurrentDirectory(Path.Combine(blogSiteRoot, pwd));

            

            blogSiteRoot = Path.Combine(blogSiteRoot, "bin");

            blogSiteRoot = Path.Combine(blogSiteRoot, "md2html.bat");
            cmd = "\"" + blogSiteRoot + " " + paramz + "\"";


           

            //var processInfo = new ProcessStartInfo("cmd.exe", "/c" + "\"C:\\Program Files (x86)\AssaultCube_v1.1.0.4\assaultcube.bat\"");
            var processInfo = new ProcessStartInfo("cmd.exe", "/c" + cmd);

            processInfo.CreateNoWindow = true;

            processInfo.UseShellExecute = false;

            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);

            process.Start();

            process.WaitForExit();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            if (error != "")
            {
                MessageBox.Show(output, "Info", MessageBoxButtons.OK);
                MessageBox.Show(error, "Error", MessageBoxButtons.OK);
            }
            else
            {

            }
        }
    }
}
