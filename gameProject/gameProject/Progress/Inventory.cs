using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class Inventory : Game
    {
        List<string> Inv = new List<string>();
        public Inventory()
        {
        }

        public void add(string item)
        {
            Inv.Add(item);
        }

        public void remove(string item, int count)
        {
            for (int i = 1; i <= Inv.Count; i++)
            {
                Inv.Remove(item);
            }
        }

        public bool check(string item)
        {
            if (Inv.Contains(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void count(string item) // mostly used for debugging
        {
            int output = 0;
            output = counter(item);
            Console.WriteLine(output);
        }
        
        public int counter(string item)
        {
            int totalCount = 0;
            while (true)
            {
                if (Inv.Contains(item))
                {
                    Inv.Remove(item);
                    totalCount = totalCount + 1;
                }
                else
                {
                    for (int i = 1; i <= totalCount; i++)
                    {
                        Inv.Add(item);
                    }
                    return totalCount;
                }
            }
        }
    }
}
