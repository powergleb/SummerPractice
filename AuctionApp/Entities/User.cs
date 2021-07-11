using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public int Age { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Lot> PurchasedLots { get; set; }
        public ICollection<Lot> SelledLots { get; set; }

        public User()
        {
            Orders = new List<Order>();
            PurchasedLots = new List<Lot>();
            SelledLots = new List<Lot>();
        }
    }   
}
