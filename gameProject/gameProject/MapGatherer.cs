using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class MapGatherer: Game
    {
        Places places = new Places();
        Random rng = new Random();
        string getLand;
        string selectedMap;
        int hasMap = 8;      // remaining map
        int maxMap;          // max amount of map that a stage can get

        string[] hasShop = { "Renetria", "Suloqinetria", "Detenetria" };
        string[] hasCamp = { "Xhanlir", "Vetria" };
        string[] hasTreasure = { "Vezbeflin", "Trabraquel" };

        List<string> allLands = new List<string>();
        List<string> oldLands = new List<string>();
        public MapGatherer()
        {
            allLands.Add("Renetria");
            allLands.Add("Vetria");
            allLands.Add("Suloqinetria");
            allLands.Add("Detenetria");
            allLands.Add("Kernil");
            allLands.Add("Xhanlir");
            allLands.Add("Vezbeflin");
            allLands.Add("Trabraquel");
        }

        public void getRandomLand()
        {
            int rNum;
            stage();
            for (int i = 0; i < maxMap; i++)
            {
                rNum = rng.Next(1, hasMap);
                getLand = allLands[rNum];
                allLands.Remove(getLand);
                oldLands.Add(getLand);
                hasMap = hasMap - 1;
                Console.Write(getLand);
                
                if (hasShop.Contains(getLand)) { Console.WriteLine(" > Has a shop"); }
                else if (hasCamp.Contains(getLand)) { Console.WriteLine(" > Has a healing site"); }
                else if (hasTreasure.Contains(getLand)) { Console.WriteLine(" > Has a treasure"); }
                else { Console.WriteLine(""); }
            
            }
            Console.WriteLine("Please select the place you want to head up to");
            selectLand();
        }

        public void selectLand()
        {
            selectedMap = Console.ReadLine();

            if (oldLands.Contains(selectedMap))
            {
                oldLands.Clear();
                map();
            }
            else
            {
                selectLand();
            }
        }
        
        public void stage()
        {
            switch (Stage)
            {
                case 1:
                    maxMap = 3;
                    break;
                case 2:
                    maxMap = 2;
                    break;
                case 3:
                    maxMap = 2;
                    break;
                case 4:
                    maxMap = 1;
                    break;

            }
        }

        public void map()
        {
            Console.WriteLine(selectedMap);
            switch (selectedMap)
            {
                case "Vetria":
                    Map map1 = new Map(new Vetria());
                    break;
                case "Detenetria":
                    Map map2 = new Map(new Detenetria());
                    break;
                case "Soluqinetria":
                    Map map3 = new Map(new Suloqinetria());
                    break;
                case "Renetria":
                    Map map4 = new Map(new Renetria());
                    break;
                case "Xhanlir":
                    Map map5 = new Map(new Xhanlir());
                    break;
                case "Kernil":
                    Map map6 = new Map(new Kernil());
                    break;
                case "Vezbeflin":
                    Map map7 = new Map(new Vezbeflin());
                    break;
                case "Trabraquel":
                    Map map8 = new Map(new Trabraquel());
                    break;
            }
        }
    }
}
