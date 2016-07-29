using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XKCD_Downloader
{
    class comicJson
    {
        /// <summary>
        /// Comic number
        /// </summary>
        public int num { get; set; }

        /// <summary>
        /// Safe title for the comic
        /// </summary>
        public String safe_title { get; set; }

        /// <summary>
        /// Alt text for the comic
        /// </summary>
        public String alt { get; set; }

        /// <summary>
        /// Image url for the comic
        /// </summary>
        public string img { get; set; }
    }
}
