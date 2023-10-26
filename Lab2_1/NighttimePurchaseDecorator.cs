using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    internal class NighttimePurchaseDecorator : DiscountDecorator
    {
        public NighttimePurchaseDecorator(IDiscount discount) : base(discount) { }

        public override double ApplyDiscount(double originalPrice)
        {
            if (IsNighttime())
            {
                return discount.ApplyDiscount(originalPrice) * 0.95;
            }
            return discount.ApplyDiscount(originalPrice);
        }

        private bool IsNighttime()
        {
            int currentHour = DateTime.Now.Hour;
            return currentHour >= 20 || currentHour < 6;
        }
    }
}
