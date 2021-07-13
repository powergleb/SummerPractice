using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlEfDAL
{
    public class AuctionContextIntializer : CreateDatabaseIfNotExists<AuctionContext>
    {
        protected override void Seed(AuctionContext db)
        {
            db.SaveChanges();
        }



    }
}
