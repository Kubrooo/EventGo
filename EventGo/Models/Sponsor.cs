using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGo.Models
{
    class Sponsor
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Pic_name { get; set; }
        public string Pic_number { get; set; }
        public string Budget { get; set; }
        public Event Event { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime deleted_at { get; set; }
    }
}
