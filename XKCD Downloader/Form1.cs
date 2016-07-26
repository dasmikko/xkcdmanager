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

namespace XKCD_Downloader
{
    public partial class MainWindow : Form
    {
        private List<comic> comicList;
        private BackgroundWorker bw;
        private Boolean isRunning = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Setup a background worker
            this.bw = new BackgroundWorker();
            bw.WorkerSupportsCancellation = true;

            this.comicListBox.Items.Clear();

            this.bw.DoWork +=
                new DoWorkEventHandler(bw_DoWork);
            this.bw.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);


            // Start worker
            if (!this.isRunning) {
                this.bw.RunWorkerAsync();
            } else {
                MessageBox.Show("Already running!");
            }


        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
            //Console.WriteLine("Progress: " + e.ProgressPercentage);
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            isRunning = false;
        }


        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            isRunning = true;
            this.comicList = new List<comic>();

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

               

                this.progressBar1.Invoke(new MethodInvoker(delegate
                {
                        this.progressBar1.Value = (Int32)percentage;
                }));

                //worker.ReportProgress((Int32)percentage);

                //Console.WriteLine(item.InnerHtml);
                //Console.WriteLine(singleComic.comicId);
            }

            this.comicListBox.Invoke(new MethodInvoker(delegate
            {
                if (this.comicList != null)
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

        private void filterTextbox_MouseEnter(object sender, EventArgs e)
        {
            filterTooltip.Show("Enter the name of the comic, or the number of the comic.\nIf you want to search by comic number try using the # character.", filterTextbox);
        }

        private void filterTextbox_MouseLeave(object sender, EventArgs e)
        {
            filterTooltip.Hide(filterTextbox);
        }
    }
}
