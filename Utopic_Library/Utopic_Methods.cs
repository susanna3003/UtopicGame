using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Utopic_Library
{
    public class Utopic_Methods
    {
        public static void MainUtopicMenu()
        {
            // declare boolean sentry
            Boolean userContinue = true;

            ////declare rooms description
            //string room1Desc, room2Desc, room3Desc, room4Desc, room5Desc;

            ////declare weapons description
            //string weapon1Desc, weapon2Desc, weapon3Desc, weapon4Desc;

            ////declare potions description
            //string potion1Desc, potion2Desc;

            ////declare treasure description
            //string treasure1Desc, treasure2Desc, treasure3Desc;

            ////declare mobs description
            //string mob1Desc, mob2Desc, mob3Desc, mob4Desc, mob5Desc;


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

                switch (Console.ReadLine())
                {
                    case "1":
                        Load.LoadRooms();

                        Console.WriteLine(World.room1);
                        Console.WriteLine(World.room2);
                        Console.WriteLine(World.room3);
                        Console.WriteLine(World.room4);
                        Console.WriteLine(World.room5);
                        break;

                    case "2":
                        Load.LoadWeapons();

                        Console.WriteLine(World.weapon1);
                        Console.WriteLine(World.weapon2);
                        Console.WriteLine(World.weapon3);
                        Console.WriteLine(World.weapon4);
                        break;

                    case "3":
                        Load.LoadPotions();

                        Console.WriteLine(World.potion1);
                        Console.WriteLine(World.potion2);
                        break;

                    case "4":
                        Load.LoadTreasures();
                        
                        Console.WriteLine(World.treasure1);
                        Console.WriteLine(World.treasure2);
                        Console.WriteLine(World.treasure3);
                        break;

                    case "5":
                        Load.LoadItems();

                        Console.WriteLine(World.item1);
                        Console.WriteLine(World.item2);
                        Console.WriteLine(World.item3);
                        Console.WriteLine(World.item4);
                        break;

                    case "6":
                        Load.LoadMobs();

                        Console.WriteLine(World.mob1);
                        Console.WriteLine(World.mob2);
                        Console.WriteLine(World.mob3);
                        Console.WriteLine(World.mob4);
                        Console.WriteLine(World.mob5);
                        break;

                    case "7":
                        Environment.Exit(0);
                        userContinue = false;
                        break;
                }

                Console.ReadLine();
            } while (userContinue == true);
        }

        public static void CombatMethod()
        {
            //Create random object
            Random rand = new Random();
            int playerHP = rand.Next(100, 151);
            int mobHP = rand.Next(100, 151);

            String damage = "1D8";
            Char[] delim = { 'D' };
            string[] tokenDamage = damage.Split(delim);

        }
    }
}
