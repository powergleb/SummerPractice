using BLLInterfaces;
using DALInterfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLCLasses
{
    public class OrderLogic : IOrderLogic
    {
        private readonly IOrderRepo _orderRepository;
        public OrderLogic(IOrderRepo orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void CreateOrder(Order order)
        {
            _orderRepository.CreateOrder(order);
        }

        public void DeleteOrder(int orderId)
        {
            _orderRepository.DeleteOrder(orderId);
        }
    }
}
