using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Item
    {
        //Варіант 1. Дано покупка(Назва товару, Категорія, Виробник, Ціна, Опис, Час покупки, Спосіб оплати, Покупець).
        public string ItemName { get; set; }
        public string ItemCategory { get; set; }
        public string ItemProducer { get; set; }
        public double ItemPrice { get; set; }
        public string ItemDescription { get; set; }
        public DateTime ItemSellTime { get; set; }
        public string ItemPaymentMethod { get; set; }
        public string ItemBuyer { get; set; }
    }
}
