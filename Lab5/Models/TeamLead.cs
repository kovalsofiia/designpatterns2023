using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public class TeamLead : IHandler
    {
        public void ProcessExpense(Expense expense)
        {
            if(expense.Amount <= 500)
            {
                Console.WriteLine($"Team Lead allows an expense {expense.ExpNumber}.");
            }
            else
            {
                Console.WriteLine($"Team lead is not able to allow an expense {expense.ExpNumber}. Forwarding to Manager ");
                new Manager().ProcessExpense(expense);
            }
        }
    }
}
