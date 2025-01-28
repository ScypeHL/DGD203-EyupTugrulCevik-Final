using System.Reflection.Emit;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace Pro
{
    class Program()
    {
        static void Main(string[] args)
        {
            Adjuster adjuster = new Adjuster();
            adjuster.start();
            adjuster.startGame();
        }

    }
}