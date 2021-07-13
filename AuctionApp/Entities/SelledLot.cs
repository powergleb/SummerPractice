using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SelledLot
    {

        public int Id { get; set; }
        public int? SellingUserId { get; set; }

        public int? LotId { get; set; }
    }
}
