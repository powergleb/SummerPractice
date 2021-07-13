using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Lot
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double StartingPrice { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int SellingUserId { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public Lot()
        {
            Orders = new List<Order>();
        }
    }
}
