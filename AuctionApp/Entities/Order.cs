using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order
    {
        public int Id { get; set; }
        public double Bet { get; set; }
        public int LotId { get; set; }
        public int UserId { get; set; }
       
    }
}
