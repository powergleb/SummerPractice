﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Price { get; set; }
        public int LotId { get; set; }

    }
}
