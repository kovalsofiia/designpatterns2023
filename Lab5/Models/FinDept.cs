using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public class FinDept : IHandler
    {
        public void ProcessExpense(Expense expense)
        {
            Console.WriteLine($"Fin dept allows an expense {expense.ExpNumber}.");
        }
    }
}
