using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace PPShoppingSpree.Items
{
    internal class Phone : ElectronicItem
    {
        public Phone(string name, int amount, decimal price, int insuranceYears = 2)
        {
            Name = name;
            Amount = amount;
            Price = price;
            InsuranceYears = insuranceYears;
        }
    }
}
