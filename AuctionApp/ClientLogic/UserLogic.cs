using BLLInterfaces;
using DALInterfaces;
using Entities;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLCLasses
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserRepo _userRepository;
        public UserLogic(IUserRepo userRepository)
        {
            _userRepository = userRepository;
        }
        public void CreateUser(User User)
        {
            if (string.IsNullOrEmpty(User.Name))
            {
                throw new InvalidValueException($"{nameof(User.Login)}");
            }

            if (string.IsNullOrEmpty(User.Login))
            {
                throw new InvalidValueException($"{nameof(User.Name)}");
            }

            if (string.IsNullOrEmpty(User.Pass))
            {
                throw new InvalidValueException($"{nameof(User.Pass)}");
            }
            _userRepository.CreateUser(User);
        }

        public ICollection<Lot> GetPurchasedLots(int userId)
        {
            List<Lot> lots = _userRepository.GetPurchasedLots(userId).ToList();
            return lots;
        }

        public ICollection<Lot> GetSelledLots(int userId)
        {
            List<Lot> lots = _userRepository.GetSelledLots(userId).ToList();
            return lots;
        }

        public User GetUserById(int userId)
        {
            User user = _userRepository.GetUserById(userId);
            return user;
        }


        public User GetUserByLoginWithPassword(string login, string password)
        {
            if (string.IsNullOrEmpty(login))
            {
                throw new InvalidValueException(nameof(login));
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new InvalidValueException(nameof(password));
            }

            var user = _userRepository.GetUserByLogin(login);

            if (user is null)
            {
                throw new NoValueException();
            }

            if (user.Pass != password)
            {
                throw new IncorrectPasswordException();
            }
            return user;
        }

        public void UpdateUser(int userId, DateTime DateofBirth, string Login, string Name, string Pass, string Patronymic, string Surname)
        {
            _userRepository.UpdateUser(userId, DateofBirth, Login, Name, Pass, Patronymic, Surname);
        }
    }
}
