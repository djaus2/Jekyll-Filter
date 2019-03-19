using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace RunBatch
{
    class ImageMarkUp
    {
        //Ref: https://www.codeproject.com/Articles/8268/Convert-any-URL-to-a-MHTML-archive-using-native-NE
        string html { get; set; }
        string Url { get; set; }
        public System.Collections.Specialized.NameValueCollection DoIt()
        {
            System.Collections.Specialized.NameValueCollection _ExternalFileCollection = new System.Collections.Specialized.NameValueCollection;
            Regex r;

            

            Debug.WriteLine("Resolving all external HTML references from URL:");
            Debug.WriteLine("    " + this.Url);

            //'-- src='filename.ext' ; background="filename.ext"
            //'-- note that we have to test 3 times to catch all quote styles: '', "", and none
            r = new Regex(
            @"(\ssrc|\sbackground)\s*=\s*((?<Key>'(?<Value>[^']+)')|" +
            @"(?<Key>""(?<Value>[^""]+)"")|(?<Key>(?<Value>[^ \n\r\f]+)))",
            RegexOptions.IgnoreCase | RegexOptions.Multiline);
            AddMatchesToCollection(html, r, _ExternalFileCollection)


          //'-- @import "style.css" or @import url(style.css)
                    r = new Regex(
            @"(@import\s|\S+-image:|background:)\s*?(url)*\s*?(?<Key>" +
            @"[""'(]{1,2}(?<Value>[^""')]+)[""')]{1,2})",
            RegexOptions.IgnoreCase | RegexOptions.Multiline);
                    AddMatchesToCollection(html, r, _ExternalFileCollection);
    

          //'-- <link rel=stylesheet href="style.css">
              r = new Regex(
            @"<link[^>]+?href\s*=\s*(?<Key>" +
            @"('|"")*(?<Value>[^'"">]+)('|"")*)",
            RegexOptions.IgnoreCase | RegexOptions.Multiline);
                    AddMatchesToCollection(html, r, _ExternalFileCollection);
    

          //'-- <iframe src="mypage.htm"> or <frame src="mypage.aspx">
              r = new Regex(
            @"<i*frame[^>]+?src\s*=\s*(?<Key>" +
            @"['""]{0,1}(?<Value>[^'""\\>]+)['""]{0,1})",
            RegexOptions.IgnoreCase | RegexOptions.Multiline);
            AddMatchesToCollection(html, r, _ExternalFileCollection);



        return _ExternalFileCollection;
    }

        private void AddMatchesToCollection(string html, Regex r, NameValueCollection externalFileCollection)
        {
            throw new NotImplementedException();
        }
    }
}
