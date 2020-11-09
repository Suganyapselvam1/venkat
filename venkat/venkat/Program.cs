using System;

namespace venkat
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu foodmenu = new FoodMenu();
            foodmenu.AddMenuItem("MuttonBriyani", "Mutton with Rice", 200);
            foodmenu.AddMenuItem("ChickenBriyani", "Chicken with Rice", 100);
            foodmenu.Name = "suganyaDiner";
            foodmenu.HospitaDirection = "Goverment Hospital is near to Bus stand";

            DrinkMenu drinkmenu = new DrinkMenu();
            drinkmenu.AddMenuItem("Fanata", "fanta", 50);
            drinkmenu.AddMenuItem("Mango", "mango", 50);
            drinkmenu.Name = "SuganyaDrink Menu";
            drinkmenu.Disclaimer = "if you drink juice,you will get cold";

            Order venkatorder = new Order();
            foreach (var item in foodmenu.menuitems)
            {
                venkatorder.menuitem.Add(item);
            }
            for (int i = 0; i < drinkmenu.menuitems.Count; i++)
            {
                venkatorder.menuitem.Add(drinkmenu.menuitems[i]);
            }
            Console.WriteLine(venkatorder.Total);
        }
    }
}
