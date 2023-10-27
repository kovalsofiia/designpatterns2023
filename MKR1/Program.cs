using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKR1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Я використала шаблон Сінглтон
            GetInfoFromUser();
        }

        public static void GetInfoFromUser()
        {
            double user_amount;
            DateTime user_date;
            Console.WriteLine("The program has started");
            Console.Write("How many payments you want to add? ");
            int n = Convert.ToInt32(Console.ReadLine());

            PaymentLog payment_log = PaymentLog.Instance();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"What is Amount of your {i+1} payment? ");
                user_amount = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Write the date (YYYY-MM-DD) or press Enter for the current date: \"");
                string date_string = Console.ReadLine();
                if (string.IsNullOrEmpty(date_string))
                {
                    user_date = DateTime.Now;
                    payment_log.AddOnePayment(user_amount, user_date);
                }
                else
                {
                    Console.Write("Year ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Month ");
                    int month = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Day ");
                    int day = Convert.ToInt32(Console.ReadLine());
                    user_date = new DateTime(year, month, day);
                    payment_log.AddOnePayment(user_amount, user_date);
                }
                
                
            }

            payment_log.ShowAllPayments();
            Console.Write($"Total amount is: {payment_log.GetTotalAmount()}");
            Console.WriteLine();
        }
    }
}
