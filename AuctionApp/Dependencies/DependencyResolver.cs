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
    public class DependencyResolver
    {
        //private static DependencyResolver _instance;
        //public static DependencyResolver Instance => _instance ?? new DependencyResolver();

        // public IUserRepo UserRepo => new UserRepo();

        // public IOrderRepo OrderRepo => new OrderRepo();

        // public ILotRepo LotRepo => new LotRepo();

        // public IUserLogic UserLogic => new UserLogic(UserRepo);

        // public IOrderLogic OrderLogic => new OrderLogic(OrderRepo);

        // public ILotLogic LotLogic => new LotLogic(LotRepo);



        private static IUserRepo _userRepo;
        public static IUserRepo UserRepo => _userRepo ?? (_userRepo = new UserRepo());

        private static IUserLogic _userLogic;
        public static IUserLogic UserLogic => _userLogic ?? (_userLogic = new UserLogic(UserRepo));


        private static IOrderRepo _orderRepo;
        public static IOrderRepo OrderRepo => _orderRepo ?? (_orderRepo = new OrderRepo());

        private static IOrderLogic _orderLogic;
        public static IOrderLogic OrderLogic => _orderLogic ?? (_orderLogic = new OrderLogic(OrderRepo));

        private static ILotRepo _lotRepo;
        public static ILotRepo LotRepo => _lotRepo ?? (_lotRepo = new LotRepo());

        private static ILotLogic _lotLogic;
        public static ILotLogic LotLogic => _lotLogic ?? (_lotLogic = new LotLogic(LotRepo));
    }
}
