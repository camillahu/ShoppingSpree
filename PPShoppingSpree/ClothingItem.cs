using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPShoppingSpree
{
    internal class ClothingItem : InventoryItem, ISellable 
    {
        public string Size {  get; set; }

        public void CalcPrice(int precentage)
        {
            decimal baseDecimal = (int)Convert.ToDecimal(Price);
            decimal taxDecimal = (int)Convert.ToDecimal(precentage);

            decimal taxAmount = baseDecimal * (taxDecimal / 100);
            decimal finalPrice = Price + taxAmount;

            Price = finalPrice;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Info for item {Name}");
            Console.WriteLine($"{Amount} in stock.");
            Console.WriteLine($"Price: {Price}kr");
            Console.WriteLine($"Size: {Size}");
        }
    }
}
