using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPShoppingSpree
{
    internal abstract class InventoryItem : ISellable
    {
        protected string Name { get; set; }
        protected int Amount { get; set; }
        protected decimal Price { get; set; }

        public void CalcPrice(bool isOnSale =false, int precentage = 0)
        {
            decimal baseDecimal = (int)Convert.ToDecimal(Price);
            decimal discountDecimal = (int)Convert.ToDecimal(precentage);

            decimal discountAmount = baseDecimal * (discountDecimal / 100);

            if (isOnSale) Price -= discountAmount;
            else Price += discountAmount;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Info for item {Name}");
            Console.WriteLine($"{Amount} in stock.");
            Console.WriteLine($"Price: {Price}kr");
        }
    }
}
