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
                Console.WriteLine("7. Fight!");
                Console.WriteLine("8. Exit");
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
                        CombatMethod();
                        break;

                    case "8":
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
            int playerAttack = rand.Next(10, 21);
            int mobAttack = rand.Next(10, 21);
            int playerHP = 50, mobHP = 50;

            //String damage = "1D8";
            //Char[] delim = { 'D' };
            //string[] tokenDamage = damage.Split(delim);

            bool ifCombat = false;
            bool ans = false;
            Console.WriteLine("A deadly enemy approaches!");
            Console.WriteLine("Will you go into combat? Y/N");
            while (ans == false)
            {
                string userAns = Console.ReadLine();
                if (userAns == "Y")
                {
                    ifCombat = true;
                    ans = true;
                }
                else if (userAns == "N")
                {
                    ifCombat = false;
                    ans = true;
                }
                else
                {
                    Console.WriteLine("Incorrect input, please try again.");
                    Console.ReadLine();
                    ans = false;
                }
            }
            

            int mobLevel = rand.Next(1, 6); // will later define mobLevels for each mob but as of now just generating rand level
            int lucky = rand.Next(0, 2); // determines if command goes in player's favor - 0 == player's luck, 1 == mob's luck - FIGURE OUT HOW TO REGENERATE LUCKY ON EACH TURN
            if (ifCombat == true)
            {
                Console.WriteLine("Your opponent is a level " + mobLevel + " which is the number of rounds it will take to end the battle!");
                Console.WriteLine("Available commands: S - strike, B - block, F - flee");
                string combatCommand = Console.ReadLine();
                for (int i = 0; i < mobLevel; i++) //create mobLevel to control length of battle (higher level mob --> longer battle)
                {
                    lucky = rand.Next(0, 2);
                    playerAttack = rand.Next(10, 21);
                    mobAttack = rand.Next(10, 21);

                    if (combatCommand == "S" && lucky == 0)
                    {
                        mobHP -= playerAttack;
                        Console.WriteLine("Succesful strike!");
                        Console.WriteLine("You dealt " + playerAttack + " damage!");
                        Console.ReadLine();
                    }
                    else if (combatCommand == "S" && lucky == 1)
                    {
                        playerHP -= mobAttack;
                        Console.WriteLine("You've been damaged!");
                        Console.ReadLine();
                    }
                    else if (combatCommand == "B" && lucky == 0)
                    {
                        Console.WriteLine("(MOBTYPE)'s attack has been blocked!");
                        Console.ReadLine();
                    }
                    else 
                    {
                        playerHP -= mobAttack;
                        Console.WriteLine("(MOBTYPE) evaded your block and damaged you!");
                        Console.ReadLine();
                    }
                }

                if (combatCommand == "F" && lucky == 0)
                {
                    Console.WriteLine("You've fled the battle!");
                    Console.ReadLine();
                }
                else if (combatCommand == "F" && lucky == 1)
                {
                    playerHP -= mobAttack;
                    Console.WriteLine("You fled the battle but (MOBTYPE) got one last strike in!");
                    Console.ReadLine();
                }
                else if (playerHP > mobHP)
                {
                    Console.WriteLine("You have won the battle!");
                    Console.WriteLine("PlayerHP: " + playerHP + " MobHP: " + mobHP);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You have lost the battle! Better luck next time!");
                    Console.WriteLine("PlayerHP: " + playerHP + " MobHP: " + mobHP);
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Very well, perhaps the next battle shall be yours.");
                Console.ReadLine();
            }

        }
    }
}
