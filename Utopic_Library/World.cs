using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utopic_Library
{
    public static class World
    {
        public static string room1 = "", room2 = "", room3 = "", room4 = "", room5 = "";
        public static string weapon1 = "", weapon2 = "", weapon3 = "", weapon4 = "";
        public static string potion1 = "", potion2 = "";
        public static string treasure1 = "", treasure2 = "", treasure3 = "";
        public static string item1 = "", item2 = "", item3 = "", item4 = "";
        public static string mob1 = "", mob2 = "", mob3 = "", mob4 = "", mob5 = "";

        // 4 arrays - rooms, weapon, potion, treasure
        // 2 lists - item, mob

        public static string[] roomsArray = new string[5];
        public static string[] weaponsArray = new string[5];
        public static string[] potionsArray = new string[2];
        public static string[] treasureArray = new string[3];

        public static List<string> itemList = new List<string>();
        public static List<string> mobList = new List<string>();

    }
}
