using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGo.Models
{
    class DetailTransaction
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }

        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
