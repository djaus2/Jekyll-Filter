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
        public static void Word2MD(bool isword, bool ishtmlNothpp, string blogSiteRoot, string batDir, string filebasename)
        {
            //string paramz = filebasename  + " " +  title;

            string batchFilePath = Path.Combine(batDir, "bat");
            string filePath = blogSiteRoot;
            string cmd = "";
            //batDir = Path.Combine(batDir, "bin");
            if (isword)
            {
                if (!ishtmlNothpp)
                {
                    //workingDir = Path.Combine(workingDir, "docx");
                    batchFilePath = Path.Combine(batchFilePath, "wrd2md.bat");
                    filePath = Path.Combine(blogSiteRoot,"_word");
                    filePath = Path.Combine(filePath,filebasename);
                    cmd = "\"" + batchFilePath + " " + filePath + "\"";
                }
                else
                {
                    //batchFilePath = Path.Combine(batchFilePath, "md2html.bat");
                    //filePath = Path.Combine("_html");
                    //filePath = Path.Combine(filebasename);
                    //cmd = "\"" + batchFilePath + " " + filePath + "\"";
                }
            }
            else //HTML2MD
            {
                if (!ishtmlNothpp)
                {
                    //orkingDir = Path.Combine(workingDir, "docx");
                    batchFilePath = Path.Combine(batchFilePath, "http2md.bat");
                    filePath = Path.Combine(blogSiteRoot, "_html");
                    filePath = Path.Combine(filePath, filebasename);
                    cmd = "\"" + batchFilePath + " " + filePath + "\"";
                }
                else
                {
                    batchFilePath = Path.Combine(batchFilePath, "html2md.bat");
                    filePath = Path.Combine(blogSiteRoot, "_html");
                    filePath = Path.Combine(filePath, filebasename);
                    cmd = "\"" + batchFilePath + " " + filePath + "\"";
                }
            }
            

            //Directory.SetCurrentDirectory(pwd);

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

        public static void Http2MD(string batDir,string mediafolder, string url, string targetPath)
        {
            //string of = Path.Combine(blogSiteRoot, pwd);
            //of = Path.Combine(of, title);
            string paramz = "\"" + mediafolder +  "\"" +" " + url + " " + "\"" + targetPath + "\"";

            


            //string workingDir = blogSiteRoot;
            string cmd = "";
            //Directory.SetCurrentDirectory(Path.Combine(blogSiteRoot, pwd));

            string batchFilePath = Path.Combine(batDir, "bat");

            batchFilePath = Path.Combine(batchFilePath, "http2md.bat");
            cmd = "\"" + batchFilePath + " " + paramz + "\"";




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
                //MessageBox.Show(output, "Info", MessageBoxButtons.OK);
                MessageBox.Show(error, "Error", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Done","Http to MD Conversion", MessageBoxButtons.OK);
            }
        }

        public static void MD2Html(string blogsiteroot,  string appDir, string srcfilename, string targetPath, string title )
        {
            //string of = Path.Combine(blogSiteRoot, pwd);
            //of = Path.Combine(of, title);
            
            string paramz = "\"" + blogsiteroot + "\"" + " " + "\"" + srcfilename + "\"" + " " + "\"" + targetPath + "\"" + " " + title + " " ;



            //string workingDir = blogSiteRoot;
            string cmd = "";
            //Directory.SetCurrentDirectory(Path.Combine(blogSiteRoot, pwd));

            string batchFilePath = Path.Combine(appDir, "bat");

            batchFilePath = Path.Combine(batchFilePath, "md2html.bat");
            cmd = "\"" + batchFilePath + " " + paramz + "\"";

                       

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
                MessageBox.Show(output, "Info", MessageBoxButtons.OK);
            }
        }

        public static void GetWithCurl(string blogsiteroot, string appDir, string srcfilename, string targetPath)
        {
            string paramz =  "\"" + srcfilename + "\"" + " " + "\"" + targetPath + "\"" ;



            //string workingDir = blogSiteRoot;
            string cmd = "";
            //Directory.SetCurrentDirectory(Path.Combine(blogSiteRoot, pwd));

            string batchFilePath = Path.Combine(appDir, "bat");

            batchFilePath = Path.Combine(batchFilePath, "httpGetWithCurl.bat");
            cmd = "\"" + batchFilePath + " " + paramz + "\"";



            //var processInfo = new ProcessStartInfo("cmd.exe", "/c" + "\"C:\\Program Files (x86)\AssaultCube_v1.1.0.4\assaultcube.bat\"");
            var processInfo = new ProcessStartInfo("cmd.exe", "/c" + cmd);

            processInfo.CreateNoWindow = true;

            processInfo.UseShellExecute = false;

            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            try
            {

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
                    MessageBox.Show(output, "Info", MessageBoxButtons.OK);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
