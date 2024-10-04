﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTBeans
{
    internal abstract class Beverage
    {
        public double Price { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Description + " $" + Price;
        }
    }
}
