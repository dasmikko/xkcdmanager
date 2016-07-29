using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XKCD_Downloader
{
    public partial class ViewComic : Form
    {
        String altText;
        public ViewComic(String imageUrl, String altText)
        {
            InitializeComponent();
            pictureBox1.Load(imageUrl);
            this.altText = altText;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            altTooltip.Show(altText, pictureBox1);
        }
    }
}
