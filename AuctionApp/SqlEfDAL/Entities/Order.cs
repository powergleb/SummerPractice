using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SqlEfDAL
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public double Price { get; set; }
        public int LotId { get; set; }
        [ForeignKey("LotId")]
        public virtual Lot Lot { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

    }
}
