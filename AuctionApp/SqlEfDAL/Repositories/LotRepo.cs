using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALInterfaces;
using Entities;

namespace SqlEfDAL.Repositories
{
    public class LotRepo : ILotRepo
    {
        public AuctionContext db;

        public LotRepo()
        {
            db = new AuctionContext();
        }

        public void CreateLot(Lot lot)
        {
            //db = new AuctionContext();
            var t = db.Lots.Add(lot);
            db.SaveChanges();
            lot.Id = t.Id;
        }

        public void DeleteLot(int lotId)
        {
            //db = new AuctionContext();
            var p1 = db.Lots.Find(lotId);
            if (p1 != null)
            {
                db.Entry(p1).State = EntityState.Deleted;
                db.SaveChanges();
            }
            var t = db.Lots.Remove(p1);
            db.SaveChanges();
        }

        public Lot GetLotById(int lotId)
        {
            //db = new AuctionContext();
            Lot lot = db.Lots.Find(lotId); ;
            return lot;
        }


        public void UpdateLot(int lotId, string description, double startingPrice, DateTime expirationDate)
        {
            //db = new AuctionContext();
            Lot lot = db.Lots.Find(lotId); ;
            lot.Description = description;
            lot.StartingPrice = startingPrice;
            lot.ExpirationDate = expirationDate;
            db.Entry(lot).State = EntityState.Modified;
            db.SaveChanges();
        }


        public ICollection<Lot> GetLotsByBet(Double bet)
        {
            //db = new AuctionContext();
            List<Lot> lots = new List<Lot>();

            foreach (var lot in db.Lots.Where(p => p.ExpirationDate <= DateTime.Now))
            {
                var x = db.Orders.Where(p => p.LotId == lot.Id).OrderByDescending(p => p.Bet).FirstOrDefault();
                if (x.Bet >= bet)
                {
                    lots.Add(db.Lots.Find(x.Id));
                }
            }
            return lots;
        }
    }
}
