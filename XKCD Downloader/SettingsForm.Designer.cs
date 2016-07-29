namespace XKCD_Downloader
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resetLocationButton = new System.Windows.Forms.Button();
            this.changeDownloadLocationButon = new System.Windows.Forms.Button();
            this.downloadLocationLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.OkButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkUpdatesOnAppStartCheckbox = new System.Windows.Forms.CheckBox();
            this.closeOnWindowCloseCheckbox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.intervalComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NotifyWhenNewComicsCheckbox = new System.Windows.Forms.CheckBox();
            this.settingsCheckForUpdatesButton = new System.Windows.Forms.Button();
            this.lastCheckedLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.settingsVersionLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.githublinkLabel = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.resetLocationButton);
            this.groupBox1.Controls.Add(this.changeDownloadLocationButon);
            this.groupBox1.Controls.Add(this.downloadLocationLabel);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(6, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current download location";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // resetLocationButton
            // 
            this.resetLocationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetLocationButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.resetLocationButton.Location = new System.Drawing.Point(421, 42);
            this.resetLocationButton.Name = "resetLocationButton";
            this.resetLocationButton.Size = new System.Drawing.Size(85, 23);
            this.resetLocationButton.TabIndex = 2;
            this.resetLocationButton.Text = "Set to default";
            this.resetLocationButton.UseVisualStyleBackColor = true;
            this.resetLocationButton.Click += new System.EventHandler(this.resetLocationButton_Click);
            // 
            // changeDownloadLocationButon
            // 
            this.changeDownloadLocationButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeDownloadLocationButon.Location = new System.Drawing.Point(512, 42);
            this.changeDownloadLocationButon.Name = "changeDownloadLocationButon";
            this.changeDownloadLocationButon.Size = new System.Drawing.Size(102, 23);
            this.changeDownloadLocationButon.TabIndex = 1;
            this.changeDownloadLocationButon.Text = "Change location";
            this.changeDownloadLocationButon.UseVisualStyleBackColor = true;
            this.changeDownloadLocationButon.Click += new System.EventHandler(this.changeDownloadLocationButon_Click);
            // 
            // downloadLocationLabel
            // 
            this.downloadLocationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadLocationLabel.AutoSize = true;
            this.downloadLocationLabel.BackColor = System.Drawing.Color.Transparent;
            this.downloadLocationLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.downloadLocationLabel.Location = new System.Drawing.Point(7, 20);
            this.downloadLocationLabel.Name = "downloadLocationLabel";
            this.downloadLocationLabel.Size = new System.Drawing.Size(80, 13);
            this.downloadLocationLabel.TabIndex = 0;
            this.downloadLocationLabel.Text = "CHANGE ME!!!";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select where the comics should be saved";
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.OkButton.Location = new System.Drawing.Point(577, 186);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "Close";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 168);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkUpdatesOnAppStartCheckbox);
            this.tabPage1.Controls.Add(this.closeOnWindowCloseCheckbox);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 142);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkUpdatesOnAppStartCheckbox
            // 
            this.checkUpdatesOnAppStartCheckbox.AutoSize = true;
            this.checkUpdatesOnAppStartCheckbox.Location = new System.Drawing.Point(7, 30);
            this.checkUpdatesOnAppStartCheckbox.Name = "checkUpdatesOnAppStartCheckbox";
            this.checkUpdatesOnAppStartCheckbox.Size = new System.Drawing.Size(205, 17);
            this.checkUpdatesOnAppStartCheckbox.TabIndex = 2;
            this.checkUpdatesOnAppStartCheckbox.Text = "Check for updates on application start";
            this.checkUpdatesOnAppStartCheckbox.UseVisualStyleBackColor = true;
            this.checkUpdatesOnAppStartCheckbox.CheckedChanged += new System.EventHandler(this.checkUpdatesOnAppStartCheckbox_CheckedChanged);
            // 
            // closeOnWindowCloseCheckbox
            // 
            this.closeOnWindowCloseCheckbox.AutoSize = true;
            this.closeOnWindowCloseCheckbox.Location = new System.Drawing.Point(7, 7);
            this.closeOnWindowCloseCheckbox.Name = "closeOnWindowCloseCheckbox";
            this.closeOnWindowCloseCheckbox.Size = new System.Drawing.Size(210, 17);
            this.closeOnWindowCloseCheckbox.TabIndex = 1;
            this.closeOnWindowCloseCheckbox.Text = "Don\'t minimize to tray on window close.";
            this.closeOnWindowCloseCheckbox.UseVisualStyleBackColor = true;
            this.closeOnWindowCloseCheckbox.CheckedChanged += new System.EventHandler(this.closeOnWindowCloseCheckbox_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.settingsCheckForUpdatesButton);
            this.tabPage2.Controls.Add(this.lastCheckedLabel);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(632, 142);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Notification";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.intervalComboBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.NotifyWhenNewComicsCheckbox);
            this.groupBox2.Location = new System.Drawing.Point(7, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 76);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notification Settings";
            // 
            // intervalComboBox
            // 
            this.intervalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.intervalComboBox.FormattingEnabled = true;
            this.intervalComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.intervalComboBox.Location = new System.Drawing.Point(84, 44);
            this.intervalComboBox.Name = "intervalComboBox";
            this.intervalComboBox.Size = new System.Drawing.Size(121, 21);
            this.intervalComboBox.TabIndex = 2;
            this.intervalComboBox.SelectedIndexChanged += new System.EventHandler(this.intervalComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Check every:";
            // 
            // NotifyWhenNewComicsCheckbox
            // 
            this.NotifyWhenNewComicsCheckbox.AutoSize = true;
            this.NotifyWhenNewComicsCheckbox.Location = new System.Drawing.Point(7, 20);
            this.NotifyWhenNewComicsCheckbox.Name = "NotifyWhenNewComicsCheckbox";
            this.NotifyWhenNewComicsCheckbox.Size = new System.Drawing.Size(239, 17);
            this.NotifyWhenNewComicsCheckbox.TabIndex = 0;
            this.NotifyWhenNewComicsCheckbox.Text = "Notify me when there a new comics available";
            this.NotifyWhenNewComicsCheckbox.UseVisualStyleBackColor = true;
            this.NotifyWhenNewComicsCheckbox.CheckedChanged += new System.EventHandler(this.NotifyWhenNewComicsCheckbox_CheckedChanged);
            // 
            // settingsCheckForUpdatesButton
            // 
            this.settingsCheckForUpdatesButton.Location = new System.Drawing.Point(193, 8);
            this.settingsCheckForUpdatesButton.Name = "settingsCheckForUpdatesButton";
            this.settingsCheckForUpdatesButton.Size = new System.Drawing.Size(120, 23);
            this.settingsCheckForUpdatesButton.TabIndex = 2;
            this.settingsCheckForUpdatesButton.Text = "Check for updates";
            this.settingsCheckForUpdatesButton.UseVisualStyleBackColor = true;
            this.settingsCheckForUpdatesButton.Click += new System.EventHandler(this.settingsCheckForUpdatesButton_Click);
            // 
            // lastCheckedLabel
            // 
            this.lastCheckedLabel.AutoSize = true;
            this.lastCheckedLabel.Location = new System.Drawing.Point(81, 12);
            this.lastCheckedLabel.Name = "lastCheckedLabel";
            this.lastCheckedLabel.Size = new System.Drawing.Size(106, 13);
            this.lastCheckedLabel.TabIndex = 1;
            this.lastCheckedLabel.Text = "01-01-1997 00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last checked:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(632, 142);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Controls.Add(this.settingsVersionLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.githublinkLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(620, 100);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // settingsVersionLabel
            // 
            this.settingsVersionLabel.AutoSize = true;
            this.settingsVersionLabel.Location = new System.Drawing.Point(65, 0);
            this.settingsVersionLabel.Name = "settingsVersionLabel";
            this.settingsVersionLabel.Size = new System.Drawing.Size(74, 13);
            this.settingsVersionLabel.TabIndex = 2;
            this.settingsVersionLabel.Text = "CHANGE ME!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Version:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Github";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "XKCD Manager";
            // 
            // githublinkLabel
            // 
            this.githublinkLabel.AutoSize = true;
            this.githublinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.githublinkLabel.Location = new System.Drawing.Point(65, 13);
            this.githublinkLabel.Name = "githublinkLabel";
            this.githublinkLabel.Size = new System.Drawing.Size(214, 13);
            this.githublinkLabel.TabIndex = 4;
            this.githublinkLabel.TabStop = true;
            this.githublinkLabel.Text = "https://github.com/dasmikko/xkcdmanager";
            this.githublinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githublinkLabel_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Author";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mikkel Andersen";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 221);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.OkButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinimumSize = new System.Drawing.Size(385, 167);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button changeDownloadLocationButon;
        private System.Windows.Forms.Label downloadLocationLabel;
        private System.Windows.Forms.Button resetLocationButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox closeOnWindowCloseCheckbox;
        private System.Windows.Forms.Label lastCheckedLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button settingsCheckForUpdatesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox NotifyWhenNewComicsCheckbox;
        private System.Windows.Forms.ComboBox intervalComboBox;
        private System.Windows.Forms.CheckBox checkUpdatesOnAppStartCheckbox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label settingsVersionLabel;
        private System.Windows.Forms.LinkLabel githublinkLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}