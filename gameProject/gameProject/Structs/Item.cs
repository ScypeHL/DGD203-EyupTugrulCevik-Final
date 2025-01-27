using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public struct Item
    {
        public Item()
        {
            name = "";
            description = "";
            price = 0;
            hpIncrease = 0;
            hpRegen = 0;
            apIncrease = 0;
            spIncrease = 0;
            dpIncrease = 0;
            aspeedIncrease = 0;
        }
        
        public string name;
        public string description;
        public int price;
        public float hpIncrease;
        public float hpRegen;
        public int apIncrease;
        public int spIncrease;
        public int dpIncrease;
        public float aspeedIncrease;
    }
}
