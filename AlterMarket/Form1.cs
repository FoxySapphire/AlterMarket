using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlterMarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            #region - Detect Dll Files -

            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                var resourceName = new AssemblyName(args.Name).Name + ".dll";
                var resource = Array.Find(GetType().Assembly.GetManifestResourceNames(),
                                          element => element.EndsWith(resourceName));

                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                {
                    var assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            };

            #endregion

            InitializeComponent();
        }
    }
}
