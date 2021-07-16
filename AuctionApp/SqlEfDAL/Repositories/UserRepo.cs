using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALInterfaces;
using Entities;
using Exceptions;

namespace SqlEfDAL.Repositories
{
    public class UserRepo : IUserRepo
    {
        public AuctionContext db;

        public UserRepo()
        {
            db = new AuctionContext();
        }

        public void CreateUser(User user)
        {
           
            if (GetUserByLogin(user.Login) == null)
            {
                var t = db.Users.Add(user);
                db.SaveChanges();
                user.Id = t.Id;
            }
            else
            {
                throw new ValueAlreadyExistsException();
            }
    
        }
        public User GetUserById(int userId)
        {
            //db = new AuctionContext();
            User user = db.Users.Find(userId); ;
            return user;
        }
        public User GetUserByLogin(string login)
        {
            if (login == null)
            {
                throw new InvalidValueException(nameof(login));
            }
            //db = new AuctionContext();
            var user = db.Users.FirstOrDefault(p => p.Login == login);
            return user;
        }
        public ICollection <Lot> GetSelledLots(int userId)
        {
            //db = new AuctionContext();
            var lots = db.Lots.Where(p=>p.SellingUserId == userId && p.ExpirationDate<=DateTime.Now).ToList();
            return lots;
        }
        public ICollection<Lot> GetPurchasedLots(int userId)
        {
            //db = new AuctionContext();
            List<Lot> lots = new List<Lot>();
            foreach (var lot in db.Lots.Where(p => p.ExpirationDate <= DateTime.Now))
            {
                var x = db.Orders.Where(p => p.LotId == lot.Id).OrderByDescending(p => p.Bet).FirstOrDefault().LotId;
                lots.Add(db.Lots.Find(x));
            }
            return lots;
        }
        public void UpdateUser(int userId, DateTime DateofBirth, string Login, string Name, string Pass, string Patronymic, string Surname)
        {
            //db = new AuctionContext();
            User user = db.Users.Find(userId); ;
            user.DateofBirth = DateofBirth;
           
            if (GetUserByLogin(Login) == null)
            {
                user.Login = Login;
            }
            else
            {
                throw new ValueAlreadyExistsException();
            }
            user.Name = Name;
            user.Pass = Pass;
            user.Patronymic = Patronymic;
            user.Surname = Surname;
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
