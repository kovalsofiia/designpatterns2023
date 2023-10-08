using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class DiscountCalculator
    {
        public double CalculateFinalPrice(Purchase purchase, double NighttimeDiscountPercentage, double CategoryDiscountPercentage, double CardPaymentDiscountPercentage)
        {
            double finalPrice = purchase.Price;
            
            // The price with the personal discount(pretend to use a personal card to define whether a customer has or has not a personal discount)
            finalPrice -= (purchase.Price * purchase.Customer.PersonalDiscountPercentage / 100);
            
            if (IsNighttime(purchase.PurchaseTime))
            {
                finalPrice -= (purchase.Price * NighttimeDiscountPercentage / 100);
            }
            
            if (purchase.Category == "Electronics")
            {
                finalPrice -= (purchase.Price * CategoryDiscountPercentage / 100);
            }

            if (purchase.PaymentMethod == "Card")
            {
                finalPrice -= (purchase.Price * CardPaymentDiscountPercentage / 100);
            }

            return finalPrice;
        }

        private bool IsNighttime(DateTime purchaseTime)
        {
            int hour = purchaseTime.Hour;
            return hour >= 21 || hour < 6;
        }
    }
}
