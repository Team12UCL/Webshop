﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{
    public class OrderLine
    {
        public int OrderLineID { get; set; }
        public int OrderID { get; set; }
        public int PruductID { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }
    }
}
