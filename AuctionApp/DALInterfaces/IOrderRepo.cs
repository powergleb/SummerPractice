using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALInterfaces
{
    public interface IOrderRepo
    {
        Order GetLotById(int orderId);
        void CreateOrder(Order order);
        void DeleteOrder(int orderId);
        void UpdateOrder(int orderId);
        ICollection<Order> GetLotsByUserId(int userId);

    }
}
