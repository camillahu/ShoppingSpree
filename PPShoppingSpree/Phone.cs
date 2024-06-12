using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPShoppingSpree
{
    internal class Phone : ElectronicItem
    {
        public Phone(string name, int amount, decimal price, int insuranceYears)
        {
            Name = name;
            Amount = amount;
            Price = price;
            InsuranceYears = insuranceYears;
        }
    }
}
