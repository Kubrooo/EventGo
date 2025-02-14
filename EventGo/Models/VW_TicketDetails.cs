using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGo.Models
{
    class VW_TicketDetails
    {
        [Key]
        public int TicketID { get; set; }
        public int Price { get; set; }
        public int Total_stock { get; set; }
        public string EventName { get; set; }
        public string CategoryName { get; set; }
    }
}
