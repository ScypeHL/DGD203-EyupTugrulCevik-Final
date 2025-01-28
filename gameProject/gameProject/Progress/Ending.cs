using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Ending:Game
    {
        Adjuster adj = new Adjuster();
        public Ending()
        {

        }

        public void start()
        {
            wr.n();
            wr.n();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Congratulations");
            Console.WriteLine("You beat the game");
            Console.WriteLine("You take the 1. of 1 ending");
        }
    }
}
