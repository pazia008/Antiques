using System;
using System.Collections.Generic;

namespace AntiqueShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Antique Shop!");

            AntigueItem chair = new AntigueItem()
            {
                Name = "An old Chair",
                Price = 45.50m,
            };

            AntigueItem vase = new AntigueItem()
            {
                Name = "cool looking vase",
                Price = 1.00m,
            };

            AntigueItem painting = new AntigueItem();
            painting.Name = "Painting Of Old People";
            painting.Price = 150.00m;

            Customer alice = new Customer("Alice", "Liddell", 10m, 100m);

            alice.PresentItem(chair);
            alice.PresentItem(vase);
            alice.PresentItem(painting);
        }
    }
}
