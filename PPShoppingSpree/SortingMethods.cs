using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPShoppingSpree
{
    internal static class SortingMethods
    {
        public static List<ISellable> SortType(List<ISellable> list)
        {
            list.Sort();
            return list;
        }  //må få denne til å funke
    }
}
