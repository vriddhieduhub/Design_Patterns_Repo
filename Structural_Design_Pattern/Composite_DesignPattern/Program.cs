using System;
using System.Threading.Tasks;

namespace Composite_DesignPattern
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            var mainMenu = new Menu("Main Menu");

            var burgers = new Menu("Burgers");
            burgers.Add(new MenuItem("Chicken Burger", 120));
            burgers.Add(new MenuItem("Veg Burger", 100));

            var beverages = new Menu("Beverages");
            beverages.Add(new MenuItem("Coke", 40));
            beverages.Add(new MenuItem("Lemon Juice", 30));

            var desserts = new Menu("Desserts");
            desserts.Add(new MenuItem("Ice Cream", 60));

            mainMenu.Add(burgers);
            mainMenu.Add(beverages);
            mainMenu.Add(desserts);

            mainMenu.Display();

            Console.WriteLine("-----------End of Composite_DesignPattern!------------");
        }
    }
}

/*  ------------
✨ Scenario

You want to represent a restaurant menu where:

MenuItem → Leaf
Menu → Composite (contains MenuItems and other Menus)

Example hierarchy:

Main Menu
 ├── Burgers
 │     ├── Chicken Burger
 │     └── Veg Burger
 ├── Beverages
 │     ├── Coke
 │     └── Lemon Juice
 └── Desserts
       └── Ice Cream

*/