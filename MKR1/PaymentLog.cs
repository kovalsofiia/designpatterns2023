using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKR1
{
    internal class PaymentLog
    {
        //приватні поля потрібні для повноцінної реалізація синглтону. їх використовую тільки всередині класу пеймент лог.
        private static PaymentLog instance;
        private static List<Payment> payments = new List<Payment>();


        //приватний конструктор потрібний для створення об*єкту якщо він ще не був створений. але це можливо тільки один раз.
        private PaymentLog() { }

        //перевіряю чи вже існує екземпляр. якщо ні то створюю і повертаю його.
        public static PaymentLog Instance()
        {
            if (instance == null)
            {
                instance = new PaymentLog();
            }
            return instance;
        }

        //метод для додавання пейменту у приватний (внутрішній )список всередині цього класу. із використанням конструктора класу пеймент.
        public void AddOnePayment(double amount, DateTime date)
        {
            payments.Add(
                new Payment { 
                    Amount = amount, 
                    Date = date 
                }
                );
        }


        //повертає приватний(внутрішній) список із обєктами типу пеймент, які були додані користувачем.
        public List<Payment> GetPayments()
        {
            return payments;
        }


        //метод для виведення даних про всі наявні у списку платежі.
        public void ShowAllPayments()
        {
            Console.WriteLine("(Each log is an object of class Payment.cs)");
            foreach ( var payment in payments )
            {
                Console.WriteLine($"Info for the payment: \n Amount = {payment.Amount}, Date: {payment.Date}");
            }
        }


        //метод для знаходження суми усіх платежів.бере поелементо зі списку і шукає суму шляхом додавання значення поля Amount кожного об*єкту
        public double GetTotalAmount() 
        {
            return payments.Sum(a => a.Amount );
        }
    }
}
