using DALInterfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlEfDAL.Repositories
{
    class OrderRepo : IOrderRepo
    {
        AuctionContext db;
        public void CreateOrder(Order order)
        {
            db = new AuctionContext();

            db.Orders.Add(order);
        }

        public void DeleteOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public Order GetLotById(int orderId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Entities.Order> GetLotsByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}
