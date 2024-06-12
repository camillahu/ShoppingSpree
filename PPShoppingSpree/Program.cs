
using System.Diagnostics;
using PPShoppingSpree;
using PPShoppingSpree.Items;


List<ISellable> Inventory = new List<ISellable>()
{
    new Jacket("Denim Jacket", 3, 599, "L"),
    new Jacket("Blazer", 4, 699, "S"),
    new Jacket("Leather Jacket", 2, 499),

    new Phone("Iphone 14", 5, 13999),
    new Phone("Iphone 5", 5, 2999),
    new Phone("Iphone 12", 5, 7999),
    new Phone("Iphone 13", 5, 9999),
    new Phone("Iphone 15", 5, 15999),

    new Pants("Mom Jeans", 3, 399, "M"),
    new Pants("Skinny Jeans", 1, 299, "XL"),

    new Laptop("Lenovo", 1, 3799),
    new Laptop("MacBook", 15, 15899, 3)
};
Run();
void Run()
{
    List<ISellable> fullSortedList = SortingMethods.SortType(Inventory);
    foreach(var sellable in fullSortedList)
    {
        sellable.CalcPrice(true,25);
        sellable.PrintInfo();
    }
}


