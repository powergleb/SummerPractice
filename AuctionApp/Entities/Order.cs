using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order
    {
        public int Id { get; set; }
        public double Price { get; set; }

        public int LotId { get; set; }
        public virtual Lot Lot { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
