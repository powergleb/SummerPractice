using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SqlEfDAL
{
    public class Lot
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public int StartingPrice { get; set; }
        public double CurrentPrice { get; set; }
        public DateTime ExpirationDate { get; set; }

        public int SellingUserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User SellingUser { get; set; }
        public int? BuyingUserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User BuyingUser { get; set; }

    }
}
