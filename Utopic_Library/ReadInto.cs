using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utopic_Library
{
    class ReadInto
    {
        // create methods to read menu files into arrays and lists
        public static void ReadRooms()
        {
            // read rooms into roomsArray
            int index = 0;
            StreamReader input;
            input = File.OpenText("Rooms.csv");

            while (index < World.roomsArray.Length && !input.EndOfStream)
            {
                World.roomsArray[index] = input.ReadLine();
                index++;
            }

            input.Close();
        }

        public static void ReadWeapons()
        {
            int index = 0;
            StreamReader input;
            input = File.OpenText("Weapons.csv");

            while (index < World.weaponsArray.Length && !input.EndOfStream)
            {
                World.weaponsArray[index] = input.ReadLine();
                index++;
            }

            input.Close();
        }

        public static void ReadPotions()
        {
            int index = 0;
            StreamReader input;
            input = File.OpenText("Potions.csv");

            while (index < World.potionsArray.Length && !input.EndOfStream)
            {
                World.potionsArray[index] = input.ReadLine();
                index++;
            }

            input.Close();
        }

        public static void ReadTreasure()
        {
            int index = 0;
            StreamReader input;
            input = File.OpenText("Treasure.csv");

            while (index < World.treasureArray.Length && !input.EndOfStream)
            {
                World.treasureArray[index] = input.ReadLine();
                index++;
            }

            input.Close();
        }

        public static void ReadItems()
        {
            int index = 0;
            StreamReader input;
            input = File.OpenText("Items.csv");

            while (index < World.itemList.Count && !input.EndOfStream)
            {
                World.itemList[index] = input.ReadLine();
                index++;
            }

            input.Close();
        }

        public static void ReadMobs()
        {
            int index = 0;
            StreamReader input;
            input = File.OpenText("Mobs.csv");

            while (index < World.mobList.Count && !input.EndOfStream)
            {
                World.mobList[index] = input.ReadLine();
                index++;
            }

            input.Close();
        }
    }
}
