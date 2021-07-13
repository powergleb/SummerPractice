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
        void CreateOrder(Order order);
        void DeleteOrder(int orderId);

    }
}
