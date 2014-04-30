using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            try
            {
                Console.WriteLine("Adding Items");
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
            #region Add the subitems to the ListView

            try
            {
                Console.WriteLine("Adding Subitems");
                // Clear the items collection to prevent double items.
                lstvwApplicationsVersions.Items.Clear();
                // Clear the imagelist to prevent double images.
                imglstApplicationsVersions.Images.Clear();
                // Scan through the collection of items.
                foreach (var application in Collections.ListApplications)
                {
                    // Only add the items of the currently selected item.
                    if (application.Name == lstvwApplications.SelectedItems[0].Text)
                    {
                        // Only continue if there are versions, else cancel (saves time and errors).
                        if (application.Versions == null || application.Versions.Count == 0) continue;
                        // Scan through all the versions of the clicked application.
                        for (int index = 0; index < application.Versions.Count; index++)
                        {
                            // The version we are adding.
                            var version = application.Versions[index];
                            // Create the ListViewItem.
                            ListViewItem lvitem = new ListViewItem();

                            // Set the ListViewItem's text.
                            lvitem.Text = version.Name;
                            // Add the ListViewItem/
                            lvitem.SubItems.Add(ByteCountFormatter.FormatBytes((long)version.Size));
                            // Tell where to put the image.
                            lvitem.ImageIndex = index;
                            Console.WriteLine("Versions: " + version.Name);

                            // Download and add the image for the imagelist.
                            using (WebClient webClient = new WebClient())
                            {
                                byte[] bitmapData = webClient.DownloadData(version.Icon);

                                // Bitmap data => bitmap => resized bitmap.            
                                using (MemoryStream memoryStream = new MemoryStream(bitmapData))
                                using (Bitmap bitmap = new Bitmap(memoryStream))
                                using (Bitmap resizedBitmap = new Bitmap(bitmap, 16, 16))
                                {
                                    //Logic.Collections.LvApplicationsVersionsCollection.Add(lvitem);
                                    imglstApplicationsVersions.Images.Add(resizedBitmap);
                                }
                            }

                            // Add the items to the ListView.
                            lstvwApplicationsVersions.Items.Add(lvitem);
                        }
                    }
                }
            }
            catch (Exception exception)
            {

            }

            #endregion
        }   
    }
    public class ByteCountFormatter
    {
        public long DataSize { get; set; }
        public DateTime Time { get; set; }

        /// <summary>
        /// This method converts a # amount of bytes into a readable string.
        /// </summary>
        /// <param name="bytes">The amount of bytes.</param>
        /// <returns>A formatted string.</returns>
        public static string FormatBytes(long bytes)
        {
            string[] suffix = { "Bytes", "KB", "MB", "GB", "TB" };
            int i = 0;
            double dblSByte = bytes;
            if (bytes > 1024)
            {
                for (i = 0; (bytes / 1024) > 0; i++, bytes /= 1024)
                    dblSByte = bytes / 1024.0;
            }
            return String.Format("{0:0.##} {1}", dblSByte, suffix[i]);
        }
    }
}
