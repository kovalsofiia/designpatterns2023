using Lab5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            lab5();
        }

        public static void lab5()
        {
            var teamLead = new TeamLead();

            var expense1 = new Expense(1, 300);
            var expense2 = new Expense(2, 1500);
            var expense3 = new Expense(3, 5000);

            teamLead.ProcessExpense(expense1);
            teamLead.ProcessExpense(expense2);
            teamLead.ProcessExpense(expense3);
        }
    }
}
