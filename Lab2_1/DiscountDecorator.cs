using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    abstract class DiscountDecorator : IDiscount
    {
        protected IDiscount discount;

        public DiscountDecorator(IDiscount discount)
        {
            this.discount = discount;
        }

        public abstract double ApplyDiscount(double originalPrice);
    }
}
