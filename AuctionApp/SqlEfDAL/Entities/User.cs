using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlEfDAL
{
    public class User
    {
        [Key]
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
