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
        public DateTime? DateofBirth { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public User()
        {
            Orders = new List<Order>();
        }
    }   
}
