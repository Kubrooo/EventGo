using EventGo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGo
{
    class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=. \\SQLEXPRESS;database=eventDb;Trusted_Connection=true;TrustServerCertificate=true");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<DetailTransaction> DetailTransactions { get; set; }
    }
}
