using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hotel_Philoxenia.Models;
using System.Configuration;

namespace Hotel_Philoxenia
{
    public class HotelContext : DbContext
    {
        
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connString = ConfigurationManager.ConnectionStrings["LocalHost"].ConnectionString;

            optionsBuilder.UseMySql(connString, ServerVersion.AutoDetect(connString))
                .LogTo(s => System.Diagnostics.Debug.WriteLine("[EF Query] " + s));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}

