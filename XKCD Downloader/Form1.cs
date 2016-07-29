using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.IO;
using System.Xml;
using System.Net;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using XKCD_Downloader.Notifications;

namespace XKCD_Downloader
{
    public partial class MainWindow : Form
    {
        static List<comic> comicList = new List<comic>();
        private BackgroundWorker bw;
        private Boolean isRunning = false;

        private int selectedTotalCount;
        private int failedCount = 0;

        private string saveLocation = Properties.Settings.Default["download_location"].ToString();

        private Boolean allowClosing = false;

        static NotifyIcon notifyicon;

        private BackgroundWorker comicDownloadingBackgroundWorker;

        public MainWindow()
        {
            InitializeComponent();

            refreshComicList();

            notifyicon = notifyIcon1;


            if((bool)Properties.Settings.Default["check_for_new_comics"])
            {
                Notifications.Notifications.StartUpdateCheckingTimer((int)Properties.Settings.Default["update_check_interval"]);
            }

            if ((bool)Properties.Settings.Default["check_for_new_comics_on_app_start"])
            {
                Notifications.Notifications.CheckForUpdates();
            }

            
        }

        public static int getComicCount()
        {
            return comicList.Count;
        }

         

        private void button1_Click(object sender, EventArgs e)
        {
            // Setup a background worker
            this.bw = new BackgroundWorker();
            bw.WorkerSupportsCancellation = true;

            this.bw.DoWork +=
                new DoWorkEventHandler(bw_DoWork);
            this.bw.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);


            // Start worker
            if (!this.isRunning) {
                this.bw.RunWorkerAsync();
            }

           

            //notifyIcon1.ShowBalloonTip(1, "XKCD Manager", "XKCD Manager is running", ToolTipIcon.Info);
        }

        
        public static void ShowNotification(String message)
        {
            notifyicon.ShowBalloonTip(1, "XKCD Manager", message, ToolTipIcon.Info);
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            isRunning = false;

            // Serialize the list to a file
            var serializer = new BinaryFormatter();
            using (var stream = File.OpenWrite("comic_cache.dat"))
            {
                serializer.Serialize(stream, comicList);
            }

            Properties.Settings.Default["list_last_update"] = DateTime.Now.ToString("d/MM/yyyy");
            Properties.Settings.Default.Save();


        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            isRunning = true;
            comicList = new List<comic>();

            HtmlAgilityPack.HtmlDocument archivePage = new HtmlAgilityPack.HtmlDocument();
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            archivePage = web.Load("http://xkcd.com/archive/");
            HtmlAgilityPack.HtmlNodeCollection items = archivePage.DocumentNode.SelectNodes("//*[@id='middleContainer']/a");

            Console.WriteLine("Items total = " + items.Count);

            int itemsTotal = items.Count;
            Int32 index = 0;
            foreach (HtmlNode item in items)
            {
                index++;
                
                double percentage = (double)index / items.Count() * 100;
                Console.WriteLine(percentage);

                comic singleComic = new comic();
                singleComic.comicName = item.InnerText;
                singleComic.comicId = int.Parse(item.GetAttributeValue("href", "").Replace("/", ""));
                comicList.Add(singleComic);

               
                // Update progress bar
                this.progressBar1.Invoke(new MethodInvoker(delegate
                {
                        this.progressBar1.Value = (Int32)percentage;
                }));
            }

            this.comicListBox.Invoke(new MethodInvoker(delegate
            {
                if (comicList != null)
                {
                    this.comicListBox.DataSource = comicList;
                    this.comicListBox.DisplayMember = "comicName";
                    this.comicListBox.ValueMember = "comicId";
                }
            }));
        }

        private void filterTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                filterTooltip.Hide(filterTextbox);
                if (comicList != null)
                {
                    int textboxInt;
                    String textboxContent = filterTextbox.Text;

                    if (textboxContent.StartsWith("#") && textboxContent.Replace("#", "") != "" && int.TryParse(textboxContent.Replace("#", ""), out textboxInt)) // Strict id search 
                    {
                        String strippedSearch = textboxContent.Replace("#", "");
                        comicListBox.DataSource = comicList.Where(x => x.comicId == int.Parse(textboxContent.Replace("#", ""))).ToList();             
                    }
                    else if (int.TryParse(textboxContent, out textboxInt) )
                    {
                        comicListBox.DataSource = comicList.Where(x => x.comicId == int.Parse(textboxContent) ||
                                                                     x.comicName.Contains(textboxContent)).ToList();
                    }
                    else
                    {
                        comicListBox.DataSource = comicList.Where(x => x.comicName.Contains(textboxContent) ||
                                                                    x.comicName.ToLower().Contains(textboxContent) ).ToList();
                    }
                    
                    comicListBox.DisplayMember = "comicName";
                    comicListBox.ValueMember = "comicId";
                }
            }
        }

        private void refreshComicList()
        {
            if (File.Exists("comic_cache.dat"))
            {
                // Deserialize the list from a file
                var serializer = new BinaryFormatter();

                using (var stream = File.OpenRead("comic_cache.dat"))
                {
                    comicList = (List<comic>)serializer.Deserialize(stream);
                }

                comicListBox.DataSource = comicList;
                comicListBox.DisplayMember = "comicName";
                comicListBox.ValueMember = "comicId";               
            }

            toolStripStatusLabel1.Text = "Loaded list from: " + Properties.Settings.Default["list_last_update"].ToString();
        }

        private void filterTextbox_MouseEnter(object sender, EventArgs e)
        {
            filterTooltip.Show("Enter the name of the comic, or the number of the comic.\nIf you want to search by comic number try using the # character.", filterTextbox);
        }

        private void filterTextbox_MouseLeave(object sender, EventArgs e)
        {
            filterTooltip.Hide(filterTextbox);
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the notification");
        }

        private void viewComicButton_Click(object sender, EventArgs e)
        {
            comic selectedItem = (comic)comicListBox.SelectedItem;
            var client = new WebClient();
            String json = client.DownloadString("http://xkcd.com/" + selectedItem.comicId + "/info.0.json");
            comicJson deserializedcomicJson = JsonConvert.DeserializeObject<comicJson>(json);
            Console.WriteLine(deserializedcomicJson.alt);
            ViewComic vcForm = new ViewComic(deserializedcomicJson.img, deserializedcomicJson.alt);
            vcForm.Show();
        }

        private void downloadSelectedButton_Click(object sender, EventArgs e)
        {
            comicDownloadingBackgroundWorker = new BackgroundWorker();
            comicDownloadingBackgroundWorker.WorkerSupportsCancellation = true;
            comicDownloadingBackgroundWorker.WorkerReportsProgress = true;

            comicDownloadingBackgroundWorker.DoWork +=
                new DoWorkEventHandler(comicDownloadingBackgroundWorker_DoWork);
            comicDownloadingBackgroundWorker.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(comicDownloadingBackgroundWorker_OnCompleted);
            comicDownloadingBackgroundWorker.ProgressChanged +=
                new ProgressChangedEventHandler(comicDownloadingBackgroundWorker_ProgressChanged);

            var selectedItems = this.comicListBox.SelectedItems;
            this.selectedTotalCount = selectedItems.Count;
            Console.WriteLine(this.selectedTotalCount);

            comicDownloadingBackgroundWorker.RunWorkerAsync();
            
        }

        private void comicDownloadingBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker comicworker = sender as BackgroundWorker;

            var selectedItems = this.comicListBox.SelectedItems;

            

            Int32 index = 0;
            failedCount = 0;
            foreach (comic item in selectedItems)
            {
                index++;
                if (!Tools.ComicDownloader.DownloadAndSaveComic(item.comicId, saveLocation))
                {
                    failedCount++;
                }
                

                double percentage = (double)index / this.selectedTotalCount * 100;
                comicworker.ReportProgress(Convert.ToInt32(percentage));

                // Update status bar text
                statusStrip1.Invoke(new MethodInvoker(delegate
                {
                    toolStripStatusLabel1.Text = "Downloading comic: " + index + "/" + selectedItems.Count;
                }));

                

                
            }
        }

        private void comicDownloadingBackgroundWorker_OnCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Comics downloaded!";
            toolStripProgressBar1.Visible = false;
            if(failedCount > 0)
            {
                notifyIcon1.ShowBalloonTip(1, "XKCD Manager,", (selectedTotalCount-failedCount) + " comics finished downloading. \n" + failedCount + " Failed", ToolTipIcon.Info);
            } else
            {
                notifyIcon1.ShowBalloonTip(1, "XKCD Manager,", selectedTotalCount + " comics finished downloading", ToolTipIcon.Info);
            }
            
        }

        private void comicDownloadingBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(!this.toolStripProgressBar1.Visible) this.toolStripProgressBar1.Visible = true;
            this.toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm sForm = new SettingsForm();
            sForm.ShowDialog();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !allowClosing && !(bool)Properties.Settings.Default["close_on_window_close"])
            {
                if((bool)Properties.Settings.Default["show_minimize_notification"])
                    notifyIcon1.ShowBalloonTip(1, "XKCD Manager", "XKCD Manager is still running in the background", ToolTipIcon.Info);

                Hide();
                e.Cancel = true;
            }
        }

        private void nimenustripClose_Click(object sender, EventArgs e)
        {
            allowClosing = true;
            Close();
        }

        private void nimenustripOpen_Click(object sender, EventArgs e)
        {
            Show();
        }
    }
}
