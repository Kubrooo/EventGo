using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGo.Models
{
    class Transaction
    {
        public int Id { get; set; }
        public string Customer_name { get; set; }
        public string Customer_phone { get; set; }
        public Event Event { get; set; }
        public DateTime Buying_at { get; set; }
    }
}
