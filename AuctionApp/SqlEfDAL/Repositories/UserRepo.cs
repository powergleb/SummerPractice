using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALInterfaces;
using Entities;

namespace SqlEfDAL.Implementations
{
    class UserRepo : IUserRepo
    {
        AuctionContext db;
        public void CreateUser(User user)
        {
            db = new AuctionContext();
            if (GetUserByLogin(user.Login) == null)
            {
                db.Users.Add(user);

            }

        }
        public User GetUserById(int userId)
        {
            db = new AuctionContext();
            User user = db.Users.Find(userId); ;
            return user;
        }
        public User GetUserByLogin(string login)
        {
            db = new AuctionContext();
            var user = db.Users.FirstOrDefault(p => p.Login == login);

            return user;
        }
    
        public void UpdateUser(int userId, int Age, string Login, string Name, string Pass, string Patronymic, string Surname)
        {
            db = new AuctionContext();
            User user = db.Users.Find(userId); ;
            user.Age = Age;
            user.Login = Login;
            user.Name = Name;
            user.Pass = Pass;
            user.Patronymic = Patronymic;
            user.Surname = Surname;
            db.SaveChanges();
        }
    }
}
