using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public class Manager : IHandler
    {
        public void ProcessExpense(Expense expense)
        {
            if (expense.Amount <= 2000)
            {
                Console.WriteLine($"Manager allows an expense {expense.ExpNumber}.");
            }
            else
            {
                Console.WriteLine($"Manager is not able to allow an expense {expense.ExpNumber}. Forwarding to Fin Dept.");
                new FinDept().ProcessExpense(expense);
            }
        }
    }
}
