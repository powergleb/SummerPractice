using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLInterfaces
{
    public interface IOrderLogic
    {
        void CreateOrder(Order order);
        void DeleteOrder(int orderId);
    }
}
