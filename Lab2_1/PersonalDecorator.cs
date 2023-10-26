using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    internal class PersonalDecorator : DiscountDecorator
    {
        private double discountPercentage;

        public PersonalDecorator(IDiscount discount) : base(discount)
        {
        }

        public PersonalDecorator(IDiscount discount, double discountPercentage) : base(discount)
        {
            this.discountPercentage = discountPercentage;
        }

        public override double ApplyDiscount(double originalPrice)
        {
            return discount.ApplyDiscount(originalPrice) * (1 - discountPercentage / 100);
        }
    }
}
