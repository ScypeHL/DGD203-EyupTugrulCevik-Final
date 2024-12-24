using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Map: Game
    {
        Places places = new Places();
        public Map(Places Places)
        {
            places = Places;
        }
    }
}
