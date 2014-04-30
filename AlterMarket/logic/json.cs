using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AlterMarket.logic
{
    class Json
    {

        public static class GetApplications
        {
            public static void Names()
            {
                var bgwrkrGetJson = new BackgroundWorker();
                var bgwrkrFilterItems = new BackgroundWorker();

                #region - Work -

                bgwrkrGetJson.DoWork += (o, args) =>
                {
                    Console.WriteLine("Retrieving JSON");
                    try
                    {

                        // Set the proxy to null to reduce a lot of time.
                        WebClient wc = new WebClient { Proxy = null };
                        // Download and save the json.
                        string downloadLink = wc.DownloadString("http://darkshadw.com/game_patcher/index.php");
                        // Deserialize the JSON and put it in a list for later use.
                        args.Result = JsonConvert.DeserializeObject<List<Collections.Items>>(downloadLink);
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
                };

                #endregion

                #region - Completed -

                bgwrkrGetJson.RunWorkerCompleted += (o, args) =>
                {
                    try
                    {
                        // Make <Items> "searchable"
                        Collections.ListApplications.Clear();
                        if (args.Result != null)
                        {
                            // Put the stuff in a enumerable (searchable) list.
                            Collections.ListApplications.AddRange((IEnumerable<Collections.Items>)args.Result);
                        }
                    }
                    catch (Exception)
                    {

                    }

                    // Start the next backgroundworker to filter the items.
                    bgwrkrFilterItems.RunWorkerAsync();
                };

                #endregion

                bgwrkrGetJson.RunWorkerAsync();
            }
            public static void Icons()
            {

            }
        }
        public static class GetApplicationsVersions
        {
            public static void Names()
            {

            }
            public static void Icons()
            {

            }
        }
    }
}
