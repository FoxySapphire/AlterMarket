using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlterMarket.logic;
using Newtonsoft.Json;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace AlterMarket
{
    public partial class Form1 : Form
    {
        int _selectedGame;

        public Form1()
        {
            // This piece of code let's us embed the dll files into our application.
            #region - Detect Dll Files -

            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                var resourceName = new AssemblyName(args.Name).Name + ".dll";
                var resource = Array.Find(GetType().Assembly.GetManifestResourceNames(), element => element.EndsWith(resourceName));
                for (int i = 0; i < GetType().Assembly.GetManifestResourceNames().Count(); i++)
                {
                    if (GetType().Assembly.GetManifestResourceNames().ElementAt(0).EndsWith(resourceName))
                    {
                        Console.WriteLine();
                    }
                }

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
            LoadGames();
        }

        private void lstvGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvGames.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = lstvGames.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                _selectedGame = lstvGames.Items[intselectedindex].Index;
            } 
            LoadGamesSubs();
        }

        private void gamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGames();
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Scan through the collection of items.
            // UPDATE: Changed it to a for loop so we can keep track of the index to prevent weird download errors o_O...
            for (int index = 0; index < Collections.ListGames.Count; index++)
            {
                var game = Collections.ListGames[index];
                if (index == _selectedGame)
                {
                    // Only continue when there are sub items (never know, just to prevent random errors).
                    if (game.Subs == null) continue;
                    // Scan through all the sub items.
                    foreach (var sub in game.Subs)
                    {
                        // Only add the items of the currently selected item.
                        if (sub.Name != lstvwGamesSubs.SelectedItems[0].Text) continue;
                        // Only continue if there is a download link available.
                        if (!string.IsNullOrEmpty(sub.Download))
                        {
                            // Check if the url contains mediafire.com.
                            if (sub.Download.Contains("mediafire.com"))
                            {
                                // Set the user agent to chrome (to prevent captcha as much as possible).
                                webBrowser1.Navigate(sub.Download, null, null, "User-Agent: Chrome/27.0.1453.94");
                                return;
                            }
                            // Initialize the download.
                            Process.Start(sub.Download);
                        }
                    }
                }
            }
        }

        private void BrowserDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Wait for the page to be fully loaded.
            if (e.Url.AbsolutePath != ((WebBrowser) sender).Url.AbsolutePath)
                return;

            // Save the HTML to a string.
            var html = webBrowser1.Document.Body.InnerHtml;

            // The html document we send to our function.
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);

            // Send the html document so we can search for the download link.
            string url = Mediafire.GetUrl(doc);
            Process.Start(url);
        }

        /// <summary>
        /// This method downloads and adds the games.
        /// </summary>
        private void LoadGames()
        {
            #region Get and save json

            try
            {
                // Set the proxy to null to reduce a lot of time.
                WebClient wc = new WebClient { Proxy = null };
                // Download and save the json.
                string downloadLink = wc.DownloadString("http://darkshadw.com/game_patcher/index.php");
                // Deserialize the JSON and put it in a list for later use.
                JsonConvert.DeserializeObject<List<Collections.Items>>(downloadLink);
                // Make <Items> "searchable"
                Collections.ListGames.Clear();
                // Put the stuff in a enumerable (searchable) list.
                Collections.ListGames.AddRange(JsonConvert.DeserializeObject<List<Collections.Items>>(downloadLink));
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
                lstvGames.Items.Clear();
                // Scan through the collection of items.
                for (int index = 0; index < Collections.ListGames.Count; index++)
                {
                    // The game we are adding.
                    Collections.Items game = Collections.ListGames[index];

                    // Create the ListViewItem.
                    ListViewItem lvitem = new ListViewItem();

                    // Set the ListViewItem's text.
                    lvitem.Text = game.Name;
                    // Tell where to put the image.
                    lvitem.ImageIndex = index;

                    // Check if the game contains an icon
                    if (!string.IsNullOrEmpty(game.Icon))
                    {
                        // Download and add the image for the imagelist.
                        using (WebClient webClient = new WebClient())
                        {
                            byte[] bitmapData = webClient.DownloadData(game.Icon);

                            // Bitmap data => bitmap => resized bitmap.
                            using (MemoryStream memoryStream = new MemoryStream(bitmapData))
                            using (Bitmap bitmap = new Bitmap(memoryStream))
                            using (Bitmap resizedBitmap = new Bitmap(bitmap, 16, 16))
                            {
                                //Logic.Collections.LvGamesSubsCollection.Add(lvitem);
                                imglstGames.Images.Add(resizedBitmap);
                            }
                        }
                    }

                    // Add the items to the ListView.
                    lstvGames.Items.Add(lvitem);
                }
            }
            catch (Exception exception)
            {

            }

            lstvGames.Sorting = SortOrder.Ascending;

            #endregion
        }

        /// <summary>
        /// This method adds the sub items.
        /// </summary>
        private void LoadGamesSubs()
        {
            #region Add the subitems to the ListView

            // Check if an item is selected.
            if (lstvGames.SelectedItems.Count == 0)
            {
                return;
            }

            try
            {
                Console.WriteLine("Adding Subitems");
                // Clear the items collection to prevent double items.
                lstvwGamesSubs.Items.Clear();
                // Clear the imagelist to prevent double images.
                imglstGamesSubs.Images.Clear();

                // Scan through the collection of items.
                foreach (var game in Collections.ListGames)
                {
                    // Only add the items of the currently selected item.
                    if (game.Name == lstvGames.SelectedItems[0].Text)
                    {
                        // Only continue if there are subs, else cancel (saves time and errors).
                        if (game.Subs == null || game.Subs.Count == 0) continue;
                        // Scan through all the subs of the clicked game.
                        for (int index = 0; index < game.Subs.Count; index++)
                        {
                            // The sub we are adding.
                            Collections.Subs sub = game.Subs[index];
                            // Create the ListViewItem.
                            ListViewItem lvitem = new ListViewItem();

                            // Set the ListViewItem's text.
                            lvitem.Text = sub.Name;
                            // Add the ListViewItem's subitem.
                            lvitem.SubItems.Add(ByteCountFormatter.FormatBytes((long)sub.Size));
                            // Tell where to put the image.
                            lvitem.ImageIndex = index;

                            // Check if the sub contains an icon
                            if (!string.IsNullOrEmpty(sub.Icon))
                            {
                                // Download and add the image for the imagelist.
                                using (WebClient webClient = new WebClient())
                                {
                                    byte[] bitmapData = webClient.DownloadData(sub.Icon);

                                    // Bitmap data => bitmap => resized bitmap.
                                    using (MemoryStream memoryStream = new MemoryStream(bitmapData))
                                    using (Bitmap bitmap = new Bitmap(memoryStream))
                                    using (Bitmap resizedBitmap = new Bitmap(bitmap, 16, 16))
                                    {
                                        //Logic.Collections.LvGamesSubsCollection.Add(lvitem);
                                        imglstGamesSubs.Images.Add(resizedBitmap);
                                    }
                                }
                            }

                            // Add the items to the ListView.
                            lstvwGamesSubs.Items.Add(lvitem);
                        }
                    }
                }
            }
            catch (Exception exception)
            {

            }

            #endregion
        }

        private void menuGamesSubs_Opening(object sender, CancelEventArgs e)
        {
            // Only open if an item is selected.
            if (lstvwGamesSubs.SelectedItems.Count < 1)
            {
                e.Cancel = true;
            }
        }

        private void webBrowser1_FileDownload(object sender, EventArgs e)
        {

        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {

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
