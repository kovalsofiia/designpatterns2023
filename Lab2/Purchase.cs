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
    }
}
