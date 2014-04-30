using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlterMarket.logic;
using Newtonsoft.Json;

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Get and save json

            try
            {
                // Set the proxy to null to reduce a lot of time.
                WebClient wc = new WebClient {Proxy = null};
                // Download and save the json.
                string downloadLink = wc.DownloadString("http://darkshadw.com/game_patcher/index.php");
                // Deserialize the JSON and put it in a list for later use.
                JsonConvert.DeserializeObject<List<Collections.Items>>(downloadLink);
                // Make <Items> "searchable"
                Collections.ListApplications.Clear();
                // Put the stuff in a enumerable (searchable) list.
                Collections.ListApplications.AddRange(JsonConvert.DeserializeObject<List<Collections.Items>>(downloadLink));
            }
            catch (Exception exception)
            {
                // The JSON cannot be found.
                if (exception is WebException)
                {
                    // Show the user a message with the erroe.
                    MessageBox.Show("There seems to be an error with the webserver, please contact the developers.\nThe application will not work how it's intended to so expect some errors.", Application.ProductName);
                }
            }

            #endregion

            #region Add the items to the ListView

            Console.WriteLine("Adding Items");
            try
            {
                // Clear the items collection to prevent double items.
                lstvwApplications.Items.Clear();
                // Scan through the collection of items.
                foreach (var application in Collections.ListApplications)
                {
                    Console.WriteLine("Applications: " + application.Name);
                    // Add the items to the ListView.
                    lstvwApplications.Items.Add(application.Name);
                }
            }
            catch (Exception exception)
            {

            }

            #endregion
        }

        private void lstvwApplications_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Adding Subitems");
            try
            {
                lstvwApplicationsVersions.Items.Clear();
                foreach (var application in Collections.ListApplications)
                {
                    if (application.Versions != null)
                    {
                        foreach (var version in application.Versions)
                        {
                            if (application.Name == lstvwApplications.SelectedItems[0].Text)
                            {
                                Console.WriteLine("Versions: " + version.Name);
                                lstvwApplicationsVersions.Items.Add(version.Name);
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {

            }
        }   
    }
}
