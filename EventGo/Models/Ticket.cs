using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGo.Models
{
    class Ticket
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int Total_stock { get; set; }

        public int EventId { get; set; }
        public int CategoryId { get; set; }

        public Event Event { get; set; }
        public Category Category { get; set; }
    }
}
