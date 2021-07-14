using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLInterfaces
{
    public interface IUserLogic
    {
        User GetUserById(int userId);
        void CreateUser(User user);
        void UpdateUser(int userId, DateTime DateofBirth, string Login, string Name, string Pass, string Patronymic, string Surname);
        ICollection<Lot> GetSelledLots(int userId);
        ICollection<Lot> GetPurchasedLots(int userId);
        User GetUserByLoginWithPassword(string login, string password);
    }
}
