using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlterMarket
{
    public partial class ResolveCaptcha : Form
    {
        public ResolveCaptcha(Uri uri)
        {
            InitializeComponent();

            //string appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
            //string filePath = Path.Combine(appPath, "temp.html");
            //webBrowser1.Url = new Uri(Path.Combine(filePath));
            //webBrowser1.Document.Write(document.Body.InnerHtml);

            webBrowser1.Navigate(uri);
        }
    }
}
