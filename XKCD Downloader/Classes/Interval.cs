using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XKCD_Downloader
{
    class Interval
    {
        public int minute { get; set; }
        public String name { get; set; }

        public Interval (String Cname, int Cminute)
        {
            this.minute = Cminute;
            this.name = Cname;
        }
    }
}
