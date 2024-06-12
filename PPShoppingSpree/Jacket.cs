using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PPShoppingSpree
{
    internal class Jacket : ClothingItem
    {
        public Jacket(string name, int amount, decimal price, string size)
        {
            Name = name;
            Amount = amount;
            Price = price;
            Size = size; 
        }
    }
}
