﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model
{
    public class Order
    {
        public Order()
        {
            Products = new List<Product>();
        }
        public int ID { get; set; }
        public List<Product> Products { get; set; }
        

    }
}
