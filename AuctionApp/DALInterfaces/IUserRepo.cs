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
        Task<User> GetUserById(int userId);
        Task<User> GetUserByLogin(string login);
        Task CreateUser(User user);
        Task DeleteUser(int userId);
        Task UpdateUser(int userId);

    }
}
