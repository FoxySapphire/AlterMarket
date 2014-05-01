using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlterMarket.logic
{
    class Collections
    {
        /// <summary>
        /// This list contains all the applications and its contents.
        /// </summary>
        public static readonly List<Items> ListApplications = new List<Items>();
        /// <summary>
        /// This list contains all the applications and its contents.
        /// </summary>
        public static readonly List<Items> ListGames = new List<Items>();

        /// <summary>
        /// This class contains the items that will be put in the list.
        /// </summary>
        public class Items
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Icon { get; set; }    
            public string Description { get; set; }
            public List<Subs> Subs { get; set; }
        }

        /// <summary>
        /// This class contains all the information about the different versions that can be downloaded.
        /// </summary>
        public class Subs
        {
            public string game_id { get; set; }
            public string Name { get; set; }
            public string Icon { get; set; }
            public string Sub { get; set; }
            public string Description { get; set; }
            public string Download { get; set; }
            public decimal Size { get; set; }
        }
    }
}
