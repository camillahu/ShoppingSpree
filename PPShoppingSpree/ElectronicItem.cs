using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPShoppingSpree
{
    internal class ElectronicItem : InventoryItem, ISellable
    {
        public int InsuranceYears { get; set; }
        public void CalcPrice(int precentage)
        {
            decimal baseDecimal = (int)Convert.ToDecimal(Price);
            decimal discountDecimal = (int)Convert.ToDecimal(precentage);

            decimal discountAmount = baseDecimal * (discountDecimal/100);
            decimal finalPrice = Price - discountAmount;

            Price = finalPrice;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Info for item {Name}");
            Console.WriteLine($"{Amount} in stock.");
            Console.WriteLine($"Price: {Price}kr");
            Console.WriteLine($"Insurance valid for {InsuranceYears} years");
        }
    }
}
