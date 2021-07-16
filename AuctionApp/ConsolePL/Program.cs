using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using SqlEfDAL.Repositories;

namespace ConsolePL
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Id = 1,
                Name = "Иван",
                Surname = "Иванов",
            Patronymic = "Иванович",
            Login = "vano",
            Pass = "11",
            };
            Lot lot = new Lot()
            {
                Id = 1,
                Description = "антикрварная ваза",
                StartingPrice = 10000,

                ExpirationDate = new DateTime(2021, 7, 11, 13, 10, 1),
                SellingUserId = user.Id,

            };

            UserRepo userRepo = new UserRepo();

            userRepo.CreateUser(user);

            //LotRepo lotRepo = new LotRepo();
            //lotRepo.CreateLot(lot);

            Console.WriteLine("Нажмите");
            Console.ReadKey();
        }
    }
}
