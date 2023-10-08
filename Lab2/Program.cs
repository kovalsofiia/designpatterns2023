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


        //static List<Item> GenerateUniqueItems()
        //{
        //    Console.WriteLine("How many items you want to generate?");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    List<Item> items = new List<Item>();

        //    Random random = new Random();

        //    string[] itemNames = { "Ruler", "Pen", "Notebook", "Calculator", "Backpack" };
        //    string[] categories = { "Office Supplies", "Stationery" };
        //    string[] brands = { "Bic", "Pilot", "IKEA" };
        //    string[] paymentMethods = { "Card", "Cash", "Online Payment" };
        //    string[] buyers = { "buyer1", "buyer2", "buyer3" };

        //    for (int i = 0; i < n; i++)
        //    {
        //        string itemName = itemNames[i];
        //        string itemCategory = categories[random.Next(categories.Length)];
        //        string itemProducer = brands[random.Next(brands.Length)];
        //        int itemPrice = random.Next(10, 999);
        //        string itemDescription = $"Description for {itemName}";
        //        DateTime itemSellTime = DateTime.Now.AddDays(-random.Next(1, 365));
        //        string itemPaymentMethod = paymentMethods[random.Next(paymentMethods.Length)];
        //        string itemBuyer = buyers[random.Next(buyers.Length)];

        //        Item item = new Item(itemName, itemCategory, itemProducer, itemPrice, itemDescription, itemSellTime, itemPaymentMethod, itemBuyer);
        //        items.Add(item);
        //        Console.WriteLine($"\n\n{item.ToString()}");
        //    }

        //    return items;

        //}
    }
}
