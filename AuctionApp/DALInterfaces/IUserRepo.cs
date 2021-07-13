using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALInterfaces
{
    public interface IUserRepo
    {
        User GetUserById(int userId);
        void CreateUser(User user);
        void UpdateUser(int userId, DateTime DateofBirth, string Login, string Name, string Pass, string Patronymic, string Surname);
    }
}
