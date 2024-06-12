using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPShoppingSpree.Items
{
    internal class Laptop : ElectronicItem
    {
        public Laptop(string name, int amount, decimal price, int insuranceYears = 5)
        {
            Name = name;
            Amount = amount;
            Price = price;
            InsuranceYears = insuranceYears;
        }
    }
}
