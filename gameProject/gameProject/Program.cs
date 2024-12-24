using System.Reflection.Emit;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace Pro
{
    class Program()
    {
        static void Main(string[] args)
        {
            MainMenu main = new MainMenu();
            main.start();
            
            CharacterCreation chcreate = new CharacterCreation();
            chcreate.start();

            MapGatherer mapGatherer = new MapGatherer();
            mapGatherer.getRandomLand();
        }

    }
}