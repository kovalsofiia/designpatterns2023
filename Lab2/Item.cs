using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Item
    {
        //Варіант 1. Дано покупка(Назва товару, Категорія, Виробник, Ціна, Опис, Час покупки, Спосіб оплати, Покупець).
        public string ItemName;
        public string ItemCategory;
        public string ItemProducer;
        public double ItemPrice;
        public string ItemDescription;
        public DateTime ItemSellTime;
        public string ItemPaymentMethod;
        public string ItemBuyer;

        public Item(string itemName, double itemPrice)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
        }

        public Item(string itemName, string itemCategory, string itemProducer, double itemPrice, string itemDescription, DateTime itemSellTime, string itemPaymentMethod, string itemBuyer)
        {
            ItemName = itemName;
            ItemCategory = itemCategory;
            ItemProducer = itemProducer;
            ItemPrice = itemPrice;
            ItemDescription = itemDescription;
            ItemSellTime = itemSellTime;
            ItemPaymentMethod = itemPaymentMethod;
            ItemBuyer = itemBuyer;
        }

        public override string ToString()
        {
            return $"Name: {ItemName},\nCategory: {ItemCategory},\nProducer: {ItemProducer},\nPrice: {ItemPrice},\nDescription: {ItemDescription},\nSell Time: {ItemSellTime},\nPayment Method: {ItemPaymentMethod},\nBuyer: {ItemBuyer}";
        }

        

        
    }
}
