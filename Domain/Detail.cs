﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Detail : EntityBase
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Product ProductD { get; set; }
    }
}
