using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGo.Models
{
    class KeranjangViewModel
    {
        public string NamaTiket { get; set; }
        public string Kategori { get; set; }
        public int Harga { get; set; }
        public int Jumlah { get; set; }
        public int Total { get; set; }
    }
}
