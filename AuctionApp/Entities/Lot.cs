using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    class Lot
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int StrtingPrice { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int? BuyingUserId { get; set; }
        public int SellingUserId { get; set; }

    }
}
