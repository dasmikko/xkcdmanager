using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XKCD_Downloader
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            refreshAllFields();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void changeDownloadLocationButon_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                Properties.Settings.Default["download_location"] = folderBrowserDialog1.SelectedPath + @"\";
                Properties.Settings.Default.Save();
                downloadLocationLabel.Text = Properties.Settings.Default["download_location"].ToString();
            }


            
        }

        private void resetLocationButton_Click(object sender, EventArgs e)
        {
            String defaultPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            Properties.Settings.Default["download_location"] = defaultPath + @"\xkcd\";
            Properties.Settings.Default.Save();
            downloadLocationLabel.Text = Properties.Settings.Default["download_location"].ToString();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeOnWindowCloseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["close_on_window_close"] = closeOnWindowCloseCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void settingsCheckForUpdatesButton_Click(object sender, EventArgs e)
        {
            Notifications.Notifications.CheckForUpdates();
            refreshAllFields();
        }


        private void refreshAllFields()
        {
            // General tab
            downloadLocationLabel.Text = Properties.Settings.Default["download_location"].ToString();
            closeOnWindowCloseCheckbox.Checked = (bool)Properties.Settings.Default["close_on_window_close"];
            checkUpdatesOnAppStartCheckbox.Checked = (bool)Properties.Settings.Default["check_for_new_comics_on_app_start"];


            // Notification tab
            if (Properties.Settings.Default["check_for_new_comics_last_check"] == null)
            {
                lastCheckedLabel.Text = "Never";
            }
            else
            {
                lastCheckedLabel.Text = Properties.Settings.Default["check_for_new_comics_last_check"].ToString();
            }

            NotifyWhenNewComicsCheckbox.Checked = (bool)Properties.Settings.Default["check_for_new_comics"];
            intervalComboBox.Enabled = NotifyWhenNewComicsCheckbox.Checked;

            List<Interval> intervals = new List<Interval>();
            intervals.Add(new Interval("1 minute", 1));
            intervals.Add(new Interval("10 minutes", 10));
            intervals.Add(new Interval("30 minutes", 30));
            intervals.Add(new Interval("1 hour", 60));

            intervalComboBox.DataSource = intervals;
            intervalComboBox.DisplayMember = "name";
            intervalComboBox.ValueMember = "minute";

            // Set the correct index for the combobox
            for (int i = 0; i < intervalComboBox.Items.Count; i++)
            {
                Console.WriteLine(intervals[i].minute);
                Console.WriteLine(Properties.Settings.Default["update_check_interval"]);
                if (intervals[i].minute == (int)Properties.Settings.Default["update_check_interval"])
                {
                    intervalComboBox.SelectedIndex = i;
                }
            }


            // About tab
            if (ApplicationDeployment.IsNetworkDeployed)
            { 
                settingsVersionLabel.Text = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4);
            } else
            {
                settingsVersionLabel.Text = "Debug version";
            }

        }

        private void NotifyWhenNewComicsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["check_for_new_comics"] = NotifyWhenNewComicsCheckbox.Checked;
            Properties.Settings.Default.Save();

            refreshAllFields();
        }

        private void checkUpdatesOnAppStartCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["check_for_new_comics_on_app_start"] = checkUpdatesOnAppStartCheckbox.Checked;
            Properties.Settings.Default.Save();

            refreshAllFields();
        }

        private void githublinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/dasmikko/xkcdmanager");
        }

        private void intervalComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Interval selectedItem = (Interval)intervalComboBox.SelectedItem;
            Properties.Settings.Default["update_check_interval"] = selectedItem.minute;
            Properties.Settings.Default.Save();
            Console.WriteLine("Saved interval! " + selectedItem.minute);



            Notifications.Notifications.StartUpdateCheckingTimer(selectedItem.minute);

            refreshAllFields();
        }
    }
}
