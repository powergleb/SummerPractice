using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Lot
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double StartingPrice { get; set; }
        public double CurrentPrice { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int SellingUserId { get; set; }
        public virtual User SellingUser { get; set; }
        public int? BuyingUserId { get; set; }
        public User BuyingUser { get; set; }

    }
}
