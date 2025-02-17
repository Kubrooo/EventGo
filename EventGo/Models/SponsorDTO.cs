using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGo.Models
{
    public class SponsorDTO
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Pic_name { get; set; }
        public string Pic_number { get; set; }
        public string Budget { get; set; }
        public string EventName { get; set; } // Menampilkan nama event
    }

}
