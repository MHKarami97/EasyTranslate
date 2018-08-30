using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyTranslate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetStringClick(object sender, EventArgs e)
        {
            if (locationString.Text != null)
            {
                var list = new List<string>();

                var logFile = File.ReadAllLines(@locationString.Text.Replace(@"\\", @"\"));

                foreach (var str in logFile)
                {
                    var oneDot = "";
                    var threeDot = "";
                    var myStr = str;

                    if (str.Contains("..."))
                    {
                        threeDot = "...";
                        myStr = str.Replace(" ...", "").Replace("...", "");
                    }
                    else if (str.Contains("."))
                    {
                        oneDot = ".";
                        myStr = str.Replace(".", "").Replace(" .", "");
                    }

                    var mcol = Regex.Matches(myStr, @">\b(.+?)\b<");

                    foreach (Match m in mcol)
                    {
                        list.Add(m.ToString().Replace("<", "").Replace(">", "") + threeDot + oneDot);
                    }
                }

                File.WriteAllLines("SavedLists.txt", list);

                Process.Start("SavedLists.txt");
            }
            else
            {
                error.Visible = true;
            }
        }

        private void AddToText_Click(object sender, EventArgs e)
        {
            var list = new List<string>();

            var logFirstFile = File.ReadAllLines(@locationString.Text.Replace(@"\\", @"\"));
            var logFile = File.ReadAllLines(@changesText.Text.Replace(@"\\", @"\"));

            var i = 0;

            foreach (var str in logFirstFile)
            {
                var mcol = Regex.Matches(str, @">\b(.+?)\b<");
                var mcol1 = Regex.Matches(str, @"<sys\b(.+?)\b"">");

                foreach (Match m in mcol)
                {
                    foreach (Match match in mcol1)
                    {
                        list.Add(m.ToString().Replace(m.ToString(), match + logFile[i] + @"</sys:String>"));

                        i++;

                    }
                }
            }

            File.WriteAllLines("result.txt", list);

            Process.Start("result.txt");
        }
    }
}
