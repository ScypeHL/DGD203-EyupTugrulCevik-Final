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
            
            MainMenu main = new MainMenu();
            main.start();
            
            CharacterCreation chcreate = new CharacterCreation();
            chcreate.start();

            MapManager mapGatherer = new MapManager();
            mapGatherer.getRandomLand();
        }

    }
}