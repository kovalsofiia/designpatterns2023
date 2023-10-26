using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    interface IDiscount
    {
        double ApplyDiscount(double originalPrice);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter product details: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Category: ");
            string category = Console.ReadLine();

            Console.Write("Manufacter: ");
            string manufacter = Console.ReadLine();

            Console.Write("Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Console.Write("Payment Method: ");
            string paymentMethod = Console.ReadLine();

            Product product = new Product
            {
                Name = name,
                Category = category,
                Manufacter = manufacter,
                Price = price,
                Description = description,
                PurchaseTime = DateTime.Now,
                PaymentMethod = paymentMethod,
            };

            IDiscount discount = new BaseDiscount();

            if (IsNighttime())
            {
                discount = new NighttimePurchaseDecorator(discount);
            }

            discount = new CategoryDecorator(discount);

            if (paymentMethod.ToLower() == "card")
            {
                discount = new CardPaymentDecorator(discount);
            }

            discount = new PersonalDecorator(discount);

            double finalPrice = discount.ApplyDiscount(product.Price);

            ShowProductInfo(product);
            ShowAppliedDiscounts(product.Price, paymentMethod);
            Console.WriteLine($"\nFinal Price after personal discount and possibly if the card was used: {finalPrice}");
        }

        private static bool IsNighttime()
        {
            int currentHour = DateTime.Now.Hour;
            return currentHour >= 20 || currentHour < 6;
        }

        private static void ShowProductInfo(Product product)
        {
            Console.WriteLine("\nProduct Information:");
            Console.WriteLine($"Product Name: {product.Name}");
            Console.WriteLine($"Category: {product.Category}");
            Console.WriteLine($"Manufacturer: {product.Manufacter}");
            Console.WriteLine($"Price: {product.Price}");
            Console.WriteLine($"Description: {product.Description}");
            Console.WriteLine($"Purchase Time: {product.PurchaseTime}");
            Console.WriteLine($"Payment Method: {product.PaymentMethod}");
            Console.WriteLine($"Buyer: {product.Buyer}");
        }

        private static void ShowAppliedDiscounts(double price, string paymentMethod)
        {
            Console.WriteLine("\nDifferent possible applied Discounts:");
            if (IsNighttime())
            {
                Console.WriteLine($"Nighttime Purchase Discount (-10%): {price * 0.9}");
            }
            Console.WriteLine($"Category Discount (-20%): {price * 0.8}");
            if (paymentMethod.ToLower() == "card")
            {
                Console.WriteLine($"Card Payment Discount (-3%): {price * 0.97}");
            }
            Console.WriteLine($"Personal Discount (-5%): {price * 0.95}");
        }

    }
}
