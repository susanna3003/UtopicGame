using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utopic_Library
{
    public static class Load
    {
        public static StreamReader input;

        public static void LoadRooms()
        {
            input = File.OpenText("Rooms.txt");
            while (!input.EndOfStream)
            {
                World.room1 = input.ReadLine();
                World.room2 = input.ReadLine();
                World.room3 = input.ReadLine();
                World.room4 = input.ReadLine();
                World.room5 = input.ReadLine();
            }

        }

        public static void LoadWeapons()
        {
            input = File.OpenText("Weapons.txt");
            while (!input.EndOfStream)
            {
                World.weapon1 = input.ReadLine();
                World.weapon2 = input.ReadLine();
                World.weapon3 = input.ReadLine();
                World.weapon4 = input.ReadLine();
            }
        }

        public static void LoadPotions()
        {
            input = File.OpenText("Potions.txt");
            while (!input.EndOfStream)
            {
                World.potion1 = input.ReadLine();
                World.potion2 = input.ReadLine();
            }
        }

        public static void LoadTreasures()
        {
            input = File.OpenText("Treasures.txt");
            while (!input.EndOfStream)
            {
                World.treasure1 = input.ReadLine();
                World.treasure2 = input.ReadLine();
                World.treasure3 = input.ReadLine();
            }
        }

        public static void LoadItems()
        {
            input = File.OpenText("Items.txt");
            while (!input.EndOfStream)
            {
                World.item1 = input.ReadLine();
                World.item2 = input.ReadLine();
                World.item3 = input.ReadLine();
                World.item4 = input.ReadLine();
            }
        }

        public static void LoadMobs()
        {
            input = File.OpenText("Mobs.txt");
            while (!input.EndOfStream)
            {
                World.mob1 = input.ReadLine();
                World.mob2 = input.ReadLine();
                World.mob3 = input.ReadLine();
                World.mob4 = input.ReadLine();
                World.mob5 = input.ReadLine();
            }
        }

    }
}
