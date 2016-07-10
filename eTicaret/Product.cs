﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicaret
{
    public class Product
    {

        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public int Stock { get; set; }
        public string Description { get; set; }
        public Categori Category { get; set; }

        public override string ToString()
        {
            return this.ProductName;
        }
    }
}
