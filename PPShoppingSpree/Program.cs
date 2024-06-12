//Shoppingspree
//Lag en base klasse som heter “InventoryItem” hvor du har info om itemets navn, 
//    antall og pris. Lag to klasser til, ClothingItem og ElectronicItem. 
//    Disse skal ha informasjon om størrelse og farge f.eks på klær og f.eks
// forsikringsinformasjon og spenning på det elektriske.
//    La disse klassene arve av baseklassen, slik at de også får bruke navn, antall og pris.
// Lag et interface ISellable som har en funksjon som kalkulerer pris, 
//    kanskje nettbutikken har black friday salg og det er 30% rabatt på alle varer?
// Eller man må legge på skatt for varene?. Implementer dette interfacet i ClothingItem og ElectronicItem
//Lag noen forskjellige items for å sjekke at det fungerer som tenkt.


using System.Diagnostics;
using PPShoppingSpree;

List<ClothingItem> Clothing = new List<ClothingItem>()
{
    new Jacket("Denim Jacket", 3, 599, "L"),
    new Jacket("Blazer", 4, 699, "S"),
    new Jacket("Leather Jacket", 2, 499, "M"),
};

List<ElectronicItem> Electronics = new List<ElectronicItem>()
{
    new Phone("Iphone 14", 5, 13999, 2),
    new Phone("Iphone 5", 5, 2999, 2),
    new Phone("Iphone 12", 5, 7999, 2),
    new Phone("Iphone 13", 5, 9999, 2),
    new Phone("Iphone 15", 5, 15999, 2),
};
Run();
void Run()
{

    foreach(ClothingItem c in Clothing)
    {
        c.CalcPrice(25);
        c.PrintInfo();
    }

    foreach (ElectronicItem e in Electronics)
    {
        e.CalcPrice(25);
        e.PrintInfo();
    }
    

}


