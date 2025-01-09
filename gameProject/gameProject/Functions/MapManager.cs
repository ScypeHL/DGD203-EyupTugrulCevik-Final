using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class MapManager: Game
    {
        private Places places = new Places();
        string getLand;
        string selectedMap;
        int hasMap = 8;      // remaining map
        int maxMap;          // max amount of map that a stage can get

        string[] hasShop = { "renetria", "suloqinetria", "detenetria" };
        string[] hasCamp = { "xhanlir", "vetria" };
        string[] hasTreasure = { "vezbeflin", "trabraquel" };

        List<string> allLands = new List<string>();
        List<string> oldLands = new List<string>();
        public MapManager()
        {
            allLands.Add("renetria");
            allLands.Add("vetria");
            allLands.Add("suloqinetria");
            allLands.Add("detenetria");
            allLands.Add("kernil");
            allLands.Add("xhanlir");
            allLands.Add("vezbeflin");
            allLands.Add("trabraquel");
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
            selectedMap = wr.read();

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
                case "vetria":
                    Map map1 = new Map(new Vetria());
                    break;
                case "detenetria":
                    Map map2 = new Map(new Detenetria());
                    break;
                case "soluqinetria":
                    Map map3 = new Map(new Suloqinetria());
                    break;
                case "renetria":
                    Map map4 = new Map(new Renetria());
                    break;
                case "xhanlir":
                    Map map5 = new Map(new Xhanlir());
                    break;
                case "kernil":
                    Map map6 = new Map(new Kernil());
                    break;
                case "vezbeflin":
                    Map map7 = new Map(new Vezbeflin());
                    break;
                case "trabraquel":
                    Map map8 = new Map(new Trabraquel());
                    break;
            }
        }
    }
}
