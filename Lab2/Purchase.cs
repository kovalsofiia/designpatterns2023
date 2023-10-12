using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Purchase
    {
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public DateTime PurchaseTime { get; set; }
        public string PaymentMethod { get; set; }
        public Customer Customer { get; set; }

        public Purchase(string productName, string category, string manufacturer, double price, string description, DateTime purchaseTime, string paymentMethod, Customer customer)
        {
            ProductName = productName;
            Category = category;
            Manufacturer = manufacturer;
            Price = price;
            Description = description;
            PurchaseTime = purchaseTime;
            PaymentMethod = paymentMethod;
            Customer = customer;
        }

        public override string ToString()
        {
            return $"{ProductName}, {Category}, {Price}";
        }
    }
}
