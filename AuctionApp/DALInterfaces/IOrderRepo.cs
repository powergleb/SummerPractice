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
        Task<Order> GetLotById(int orderId);
        Task CreateOrder(Order order);
        Task DeleteOrder(int orderId);
        Task UpdateOrder(int orderId);

    }
}
