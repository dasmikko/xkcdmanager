using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace XKCD_Downloader.Tools
{
    public class ComicDownloader
    {
        /// <summary>
        /// Downloads a comic and saves it
        /// </summary>
        /// <param name="ComicId"></param>
        public static bool DownloadAndSaveComic(int ComicId, String path)
        {
            var client = new WebClient();

            Console.WriteLine(path);

            String json = client.DownloadString("http://xkcd.com/" + ComicId + "/info.0.json");
            comicJson deserializedcomicJson = JsonConvert.DeserializeObject<comicJson>(json);
            string filename = System.IO.Path.GetFileName(deserializedcomicJson.img);

            // Create directory if it doesn't exist
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            try
            {
                client.DownloadFile(deserializedcomicJson.img, path + deserializedcomicJson.num + "-" + filename);
                Console.WriteLine(path + deserializedcomicJson.num + "-" + filename);
            } catch (WebException e)
            {
                Console.WriteLine(e);
                return false;
            }

            return true;
            
        }
    }
}
