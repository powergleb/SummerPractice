using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities;

namespace SqlEfDAL
{
    class AuctionContext : DbContext
    {
        static AuctionContext()
        {
            Database.SetInitializer<AuctionContext>(new AuctionContextIntializer());
        }
        public AuctionContext()
            : base("AuctionDb")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Lot> Lots { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
