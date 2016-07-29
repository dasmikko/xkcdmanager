using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XKCD_Downloader.Notifications
{
    public class Notifications
    {
        static bool timerRunning = false;

        public static bool CheckForUpdates()
        {
            Properties.Settings.Default["check_for_new_comics_last_check"] = DateTime.Now;
            Properties.Settings.Default.Save();

            HtmlAgilityPack.HtmlDocument archivePage = new HtmlAgilityPack.HtmlDocument();
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            archivePage = web.Load("http://xkcd.com/archive/");
            HtmlAgilityPack.HtmlNodeCollection items = archivePage.DocumentNode.SelectNodes("//*[@id='middleContainer']/a");

            if(MainWindow.getComicCount() < items.Count)
            {
                MainWindow.ShowNotification("New comics available!");
                return true;
            }
            return false;


            //Console.WriteLine(Properties.Settings.Default["check_for_new_comics_last_check"]);

            return true;
        }

        static Timer updatetimer;
        public static void StartUpdateCheckingTimer(int minutes)
        {
            if (!timerRunning)
            {
                Console.WriteLine("TIMER IS RUNNING. Minutes: " + minutes);
                timerRunning = true;
                updatetimer = new Timer();
                updatetimer.Tick += new EventHandler(StartUpdateCheckingTimer_tick);
                updatetimer.Interval = (minutes * 60) * 1000; // in miliseconds
                updatetimer.Start();
            }
        }

        static void StartUpdateCheckingTimer_tick(object sender, EventArgs e)
        {
            CheckForUpdates();
        }
    }
}
