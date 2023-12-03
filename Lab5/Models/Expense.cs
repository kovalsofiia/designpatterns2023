using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public class Expense
    {
        public int ExpNumber { get; set; }
        public double Amount { get; set; }

        public Expense(int expnum, double amount)
        {
            ExpNumber = expnum;
            Amount = amount;
        }
    }
}
