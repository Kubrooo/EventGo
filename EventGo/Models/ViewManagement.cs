using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGo.Models
{
    class ViewManagement
    {
        [Key]
        public int TicketId { get; set; }
        public int Total_stock { get; set; }
        public string CategoryName { get; set; }
        public int EventId { get; set; }
        public string EventStatus { get; set; }
        public string EventDescription { get; set; }
        public DateTime Open_date { get; set; }
        public DateTime? Closed_date { get; set; }
    }
}
