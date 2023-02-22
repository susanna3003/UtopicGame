using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
* 2/22/23
* CSC 153
* Susanna Quayle
* Sprint 1
*/
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare main menu variables
            string rooms, weapons, potions, treasure, items, mobs;

            //declare rooms
            string room1 = "Bedroom";
            string room2 = "Hallway";
            string room3 = "Living room";
            string room4 = "Balcony";
            string room5 = "Walkway";

            //declare weapons
            string weapon1 = "Sword";
            string weapon2 = "Bow";
            string weapon3 = "Muto Tree Spear";
            string weapon4 = "Throwing Knives";

            //declare potions
            string potion1 = "Golden Apple potion (immunity)";
            string potion2 = "Harry's Cloak potion (invisibility)";

            //declare treasure
            string treasure1 = "Heirloom Locket";
            string treasure2 = "Heart of Muto Tree";
            string treasure3 = "500 Gold";

            //declare items
            string item1 = "Compass";
            string item2 = "Journal";
            string item3 = "Temping Rod";
            string item4 = "Seeing Stones";

            //declare mobs
            string mob1 = "Pups";
            string mob2 = "Sea Serpents";
            string mob3 = "Muto Troll";
            string mob4 = "Uto Troll";
            string mob5 = "Harps";

            //main menu
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Display rooms");
            Console.WriteLine("2. Display weapons");
            Console.WriteLine("3. Display potions");
            Console.WriteLine("4. Display treasure");
            Console.WriteLine("5. Display items");
            Console.WriteLine("6. Display mobs");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine(room1);
                    Console.WriteLine(room2);
                    Console.WriteLine(room3);
                    Console.WriteLine(room4);
                    Console.WriteLine(room5);
                    break;
                case "2":
                    Console.WriteLine(weapon1);
                    Console.WriteLine(weapon2);
                    Console.WriteLine(weapon3);
                    Console.WriteLine(weapon4);
                    break;
                case "3":
                    Console.WriteLine(potion1);
                    Console.WriteLine(potion2);
                    break;
                case "4":
                    Console.WriteLine(treasure1);
                    Console.WriteLine(treasure2);
                    Console.WriteLine(treasure3);
                    break;
                case "5":
                    Console.WriteLine(item1);
                    Console.WriteLine(item2);
                    Console.WriteLine(item3);
                    Console.WriteLine(item4);
                    break;
                case "6":
                    Console.WriteLine(mob1);
                    Console.WriteLine(mob2);
                    Console.WriteLine(mob3);
                    Console.WriteLine(mob4);
                    Console.WriteLine(mob5);
                    break;
                case "7":
                    Environment.Exit(0);
                    break;
            }

            Console.ReadLine();
        }
    }
}
