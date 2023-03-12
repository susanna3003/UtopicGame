using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            // declare boolean sentry
            Boolean userContinue = true;

            //declare main menu variables
            string rooms, weapons, potions, treasure, items, mobs;

            //create file for room values
            StreamWriter roomValues;
            roomValues = File.CreateText("Rooms.txt");
            roomValues.WriteLine("Bedroom");
            roomValues.WriteLine("Hallway");
            roomValues.WriteLine("Living room");
            roomValues.WriteLine("Balcony");
            roomValues.WriteLine("Walkway");
            roomValues.Close();

            //declare rooms
            string room1 = "Bedroom";
            string room2 = "Hallway";
            string room3 = "Living room";
            string room4 = "Balcony";
            string room5 = "Walkway";

            //declare rooms description
            string room1Desc, room2Desc, room3Desc, room4Desc, room5Desc;

            //create file for weapon values
            StreamWriter weaponValues;
            weaponValues = File.CreateText("Weapons.txt");
            weaponValues.WriteLine("Sword");
            weaponValues.WriteLine("Bow");
            weaponValues.WriteLine("Muto Tree Spear");
            weaponValues.WriteLine("Throwing Knives");
            weaponValues.Close();

            //declare weapons
            string weapon1 = "Sword";
            string weapon2 = "Bow";
            string weapon3 = "Muto Tree Spear";
            string weapon4 = "Throwing Knives";

            //declare weapons description
            string weapon1Desc, weapon2Desc, weapon3Desc, weapon4Desc;

            //create file for potion values
            StreamWriter potionValues;
            potionValues = File.CreateText("Potions.txt");
            potionValues.WriteLine("Golden Apple potion (immunity)");
            potionValues.WriteLine("Harry's Cloak potion (invisibility)");
            potionValues.Close();

            //declare potions
            string potion1 = "Golden Apple potion (immunity)";
            string potion2 = "Harry's Cloak potion (invisibility)";

            //create file for treasure values
            StreamWriter treasureValues;
            treasureValues = File.CreateText("Treasure.txt");
            treasureValues.WriteLine("Heirloom Locket");
            treasureValues.WriteLine("Heart of Muto Tree");
            treasureValues.WriteLine("500 Gold");
            treasureValues.Close();

            //declare treasure
            string treasure1 = "Heirloom Locket";
            string treasure2 = "Heart of Muto Tree";
            string treasure3 = "500 Gold";

            //create file for item values
            StreamWriter itemValues;
            itemValues = File.CreateText("Items.txt");
            itemValues.WriteLine("Compass");
            itemValues.WriteLine("Journal");
            itemValues.WriteLine("Temping Rod");
            itemValues.WriteLine("Seeing Stones");
            itemValues.Close();

            //declare items
            string item1 = "Compass";
            string item2 = "Journal";
            string item3 = "Temping Rod";
            string item4 = "Seeing Stones";

            //create file for mob values
            StreamWriter mobValues;
            mobValues = File.CreateText("Mobs.txt");
            mobValues.WriteLine("Pups");
            mobValues.WriteLine("Sea Serpents");
            mobValues.WriteLine("Muto Troll");
            mobValues.WriteLine("Uto Troll");
            mobValues.WriteLine("Harps");
            mobValues.Close();

            //declare mobs
            string mob1 = "Pups";
            string mob2 = "Sea Serpents";
            string mob3 = "Muto Troll";
            string mob4 = "Uto Troll";
            string mob5 = "Harps";

            //declare mobs description
            string mob1Desc, mob2Desc, mob3Desc, mob4Desc, mob5Desc;


            do
            {
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

                //read txt files
                StreamReader input;
                //input = File.OpenText("Rooms.txt");
                //StreamReader readWeaponValues;
                //readWeaponValues = File.OpenText("Weapons.txt");
                //StreamReader readPotionValues;
                //readPotionValues = File.OpenText("Potions.txt");
                //StreamReader readTreasureValues;
                //readTreasureValues = File.OpenText("Treasure.txt");
                //StreamReader readItemValues;
                //readItemValues = FileY.OpenText("Items.txt");
                //StreamReader readMobValues;
                //readMobValues = File.OpenText("Mobs.txt");
                //hello
                switch (Console.ReadLine())
                {
                    case "1":
                        input = File.OpenText("Rooms.txt");
                        while (!input.EndOfStream)
                        {
                            room1 = input.ReadLine();
                            room2 = input.ReadLine();
                            room3 = input.ReadLine();
                            room4 = input.ReadLine();
                            room5 = input.ReadLine();
                        }
                        /*Console.WriteLine(room1);
                        Console.WriteLine(room2);
                        Console.WriteLine(room3);
                        Console.WriteLine(room4);
                        Console.WriteLine(room5);*/
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
                        userContinue = false;
                        break;
                }

                Console.ReadLine();
            } while (userContinue == true);
        }
    }
}
