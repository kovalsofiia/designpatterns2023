using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Customer
    {
        public string Name;
        public int PersonalDiscountPercentage;


        public Customer(string name) { Name = name;}

        public void SetPersonalDiscount(int personalDiscount)
        {
            PersonalDiscountPercentage = personalDiscount;
        }
    }
}
