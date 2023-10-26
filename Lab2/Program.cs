using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        //Розробити систему знижок яка розраховує кінцеву ціну товару для покупця враховуючи такі види знижок:
        //a.Персональна знижка покупця N відсотків
        //b.Знижка на покупку в нічний час X відсотків
        //c.Знижка У відсотків на категорію товарів.
        //d.Знижка Z відсотків при оплаті карткою.
        //Врахувати всі можливі комбінації знижки.

















        // Step 1: Create an interface that defines the component interface.
        public interface IComponent
        {
            void Operation();
        }

        // Step 2: Create a concrete component that implements the component interface.
        public class ConcreteComponent : IComponent
        {
            public void Operation()
            {
                Console.WriteLine("ConcreteComponent operation");
            }
        }

        // Step 3: Create an abstract decorator class that also implements the component interface.
        public abstract class Decorator : IComponent
        {
            private IComponent _component;

            public Decorator(IComponent component)
            {
                _component = component;
            }

            // The Decorator delegates the Operation to the wrapped component.
            public virtual void Operation()
            {
                _component.Operation();
            }
        }

        // Step 4: Create concrete decorators that extend the functionality of the component.
        public class ConcreteDecoratorA : Decorator
        {
            public ConcreteDecoratorA(IComponent component) : base(component)
            {
            }

            public override void Operation()
            {
                base.Operation();
                Console.WriteLine("ConcreteDecoratorA operation");
            }
        }

        public class ConcreteDecoratorB : Decorator
        {
            public ConcreteDecoratorB(IComponent component) : base(component)
            {
            }

            public override void Operation()
            {
                base.Operation();
                Console.WriteLine("ConcreteDecoratorB operation");
            }
        }










































        static void Main(string[] args)
        {

            var customer = new Customer("Buyer1");
            Purchase MyPurchase1 = new Purchase("Smartphone", "Electronics", "Apple", 1000, "High-end smartphones", DateTime.Now, "Card", customer);
            Console.WriteLine(MyPurchase1.ToString());


            Console.Write("Enter Personal Discount Percentage: ");
            customer.SetPersonalDiscount(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Enter X = Nighttime Discount Percentage: ");
            int NighttimeDiscountPercentage = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Y = Category Discount Percentage: ");
            int CategoryDiscountPercentage = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Z = Card Payment Discount Percentage: ");
            int CardPaymentDiscountPercentage = Convert.ToInt32(Console.ReadLine());

            var calc = new CalculatedPurchase(MyPurchase1, NighttimeDiscountPercentage, CategoryDiscountPercentage, CardPaymentDiscountPercentage);
            Console.WriteLine(MyPurchase1.Price);

        }


        class CalculatedPurchase
        {
            public int DDiscount;

            private int nighttimeDiscount;
            private int categoryDiscount;
            private int cardPaymentDiscount;
            protected Purchase _purchase;

            public CalculatedPurchase(Purchase purchase, int nighttimeDiscountPercentage, int categoryDiscountPercentage, int cardPaymentDiscountPercentage)
            {
                _purchase = purchase;
                nighttimeDiscount = nighttimeDiscountPercentage;
                categoryDiscount = categoryDiscountPercentage;
                cardPaymentDiscount = cardPaymentDiscountPercentage;
                CalculateDiscount();
            }

            
            public void getSumOfDiscounts()
            {
                DDiscount = _purchase.Customer.PersonalDiscountPercentage + nighttimeDiscount + categoryDiscount + cardPaymentDiscount;
            }

            public void CalculateDiscount()
            {
                getSumOfDiscounts();
                if (_purchase != null)
                {
                    _purchase.Price -= (_purchase.Price * DDiscount / 100);
                }
            }
        }
    }
}
