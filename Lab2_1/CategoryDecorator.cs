using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    internal class CategoryDecorator : DiscountDecorator
    {
        public CategoryDecorator(IDiscount discount) : base(discount) { }

        public override double ApplyDiscount(double originalPrice)
        {
            return discount.ApplyDiscount(originalPrice) * 0.95;
        }
    }
}
