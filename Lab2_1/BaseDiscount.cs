﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    internal class BaseDiscount : IDiscount
    {
        public double ApplyDiscount(double originalPrice)
        {
            return originalPrice;
        }
    }
}
