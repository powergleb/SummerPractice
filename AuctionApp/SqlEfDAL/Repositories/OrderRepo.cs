using DALInterfaces;
using Entities;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlEfDAL.Repositories
{
    public class OrderRepo : IOrderRepo
    {
        AuctionContext db;

        public OrderRepo()
        {
            db = new AuctionContext();
        }

        public void CreateOrder(Order order)
        {
            //db = new AuctionContext();
            if ((order.Bet < db.Lots.Find(order.LotId).StartingPrice) ||
                (order.Bet < db.Orders.Where(p=> p.LotId == order.LotId).OrderByDescending(p=>p.Bet).FirstOrDefault().Bet))
            {
                throw new InvalidValueException();
            }
            else
            {
                var t = db.Orders.Add(order);
                db.SaveChanges();
                order.Id = t.Id;
            }
            
        }

        public void DeleteOrder(int orderId)
        {
            //db = new AuctionContext();
            var p1 = db.Orders.Find(orderId);
            if (p1 != null)
            {
                db.Entry(p1).State = EntityState.Deleted;
                db.SaveChanges();
            }
            var t = db.Orders.Remove(p1);
            db.SaveChanges();
        }

       
    }
}
