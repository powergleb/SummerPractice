using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SqlEfDAL
{
    public class AuctionContext : DbContext
    {
        //static AuctionContext()
        //{
        //    Database.SetInitializer<AuctionContext>(new AuctionContextIntializer());
        //}
        public AuctionContext()
            : base("AuctionDb")
        { Database.CreateIfNotExists();
            //Database.SetInitializer<AuctionContext>(new AuctionContextIntializer());
            var ensureDLLIsCopied =
                    System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Lot> Lots { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<SelledLot> SelledLots { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().ToTable("Users").HasKey(e => e.Id);
            modelBuilder.Entity<Lot>().ToTable("Lots").HasKey(e => e.Id);
            modelBuilder.Entity<Order>().ToTable("Orders").HasKey(e => e.Id);

    
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
