using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class DiscountCalculator
    {
        //    Purchase Purchase { get; set; }
        //    double NighttimeDiscountPercentage { get; set; }
        //    double CategoryDiscountPercentage { get; set; }
        //    double CardPaymentDiscountPercentage { get; set; }

        //    public DiscountCalculator(Purchase purchase, double NighttimeDiscountPercentage, double CategoryDiscountPercentage, double CardPaymentDiscountPercentage)
        //    {
        //        this.Purchase = purchase;
        //        this.NighttimeDiscountPercentage = NighttimeDiscountPercentage;
        //        this.CategoryDiscountPercentage = CategoryDiscountPercentage;
        //        this.CardPaymentDiscountPercentage = CardPaymentDiscountPercentage;
        //    }
        //    public double CalculateFinalPrice()
        //    {
        //        double finalPrice = Purchase.Price;

        //        // The price with the personal discount(pretend to use a personal card to define whether a customer has or has not a personal discount)
        //        finalPrice -= (Purchase.Price * Purchase.Customer.PersonalDiscountPercentage / 100);

        //        if (IsNighttime(Purchase.PurchaseTime))
        //        {
        //            finalPrice -= (Purchase.Price * NighttimeDiscountPercentage / 100);
        //        }

        //        if (Purchase.Category == "Electronics")
        //        {
        //            finalPrice -= (Purchase.Price * CategoryDiscountPercentage / 100);
        //        }

        //        if (Purchase.PaymentMethod == "Card")
        //        {
        //            finalPrice -= (Purchase.Price * CardPaymentDiscountPercentage / 100);
        //        }

        //        return finalPrice;
        //    }

        //    private bool IsNighttime(DateTime purchaseTime)
        //    {
        //        int hour = purchaseTime.Hour;
        //        return hour >= 21 || hour < 6;
        //    }
    }
}
