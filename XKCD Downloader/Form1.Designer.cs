namespace XKCD_Downloader
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comicListBox = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.filterTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.filterTooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(12, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get comics";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(213, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Download selected";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comicListBox
            // 
            this.comicListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comicListBox.FormattingEnabled = true;
            this.comicListBox.Location = new System.Drawing.Point(13, 39);
            this.comicListBox.Name = "comicListBox";
            this.comicListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.comicListBox.Size = new System.Drawing.Size(308, 329);
            this.comicListBox.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(13, 373);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(308, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            // 
            // filterTextbox
            // 
            this.filterTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterTextbox.Location = new System.Drawing.Point(48, 12);
            this.filterTextbox.Name = "filterTextbox";
            this.filterTextbox.Size = new System.Drawing.Size(273, 20);
            this.filterTextbox.TabIndex = 5;
            this.filterTextbox.TextChanged += new System.EventHandler(this.filterTextbox_TextChanged);
            this.filterTextbox.MouseEnter += new System.EventHandler(this.filterTextbox_MouseEnter);
            this.filterTextbox.MouseLeave += new System.EventHandler(this.filterTextbox_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filter";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // filterTooltip
            // 
            this.filterTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.filterTooltip.ToolTipTitle = "Comic filter";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterTextbox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comicListBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XKCD Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox comicListBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox filterTextbox;
        private System.Windows.Forms.Label label1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.ToolTip filterTooltip;
    }
}

