using BLLCLasses;
using BLLInterfaces;
using DALInterfaces;
using SqlEfDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencies
{
    class DependencyResolver
    {
        private static DependencyResolver _instance;
        public static DependencyResolver Instance => _instance ?? new DependencyResolver();

        public IUserRepo UserRepo => new UserRepo();

        public IOrderRepo OrderRepo => new OrderRepo();

        public ILotRepo LotRepo => new LotRepo();

        public IUserLogic UserLogic => new UserLogic(UserRepo);

        public IOrderLogic OrderLogic => new OrderLogic(OrderRepo);

        public ILotLogic LotLogic => new LotLogic(LotRepo);
    }
}
