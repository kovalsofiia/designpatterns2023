using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        //Розробити систему знижок яка розраховує кінцеву ціну товару для покупця враховуючи такі види знижок:
        //a.Персональна знижка покупця N відсотків
        //b.Знижка на покупку в нічний час X відсотків
        //c.Знижка У відсотків на категорію товарів.
        //d.Знижка Z відсотків при оплаті карткою.
        //Врахувати всі можливі комбінації знижки.

        static void Main(string[] args)
        {
            var customer = new Customer
            {
                Name = "Buyer 1"
            };

            var purchase = new Purchase
            {
                ProductName = "Smartphone",
                Category = "Electronics",
                Manufacturer = "Apple",
                Price = 1000,
                Description = "High-end smartphone",
                PurchaseTime = DateTime.Now,
                PaymentMethod = "Card",
                Customer = customer
            };

            Console.Write("Enter Personal Discount Percentage: ");
            customer.PersonalDiscountPercentage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter X = Nighttime Discount Percentage: ");
            double NighttimeDiscountPercentage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Y = Category Discount Percentage: ");
            double CategoryDiscountPercentage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Z = Card Payment Discount Percentage: ");
            double CardPaymentDiscountPercentage = Convert.ToDouble(Console.ReadLine());

            var discountCalculator = new DiscountCalculator();
            double finalPrice = discountCalculator.CalculateFinalPrice(purchase, NighttimeDiscountPercentage, CategoryDiscountPercentage, CardPaymentDiscountPercentage);

            Console.WriteLine($"Original Price: ${purchase.Price}");
            Console.WriteLine($"Final Price: ${finalPrice}");
        }
    }
}
