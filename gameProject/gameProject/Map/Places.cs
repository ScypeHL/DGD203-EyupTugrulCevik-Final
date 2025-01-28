using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class Places: Game
    {
        public Dictionary<Vector2, Land> _lands;
        public Places()
        {
            _lands = new Dictionary<Vector2, Land>();
            Detenetria();
            Vetria();
            Renetria();
            Kernil();
            Pazar();
        }

        public void start(string landName)
        {
            Detenetria();
            Vetria();
            Renetria();
            Kernil();
            Pazar();
        }

        private void Detenetria()
        {
            Vector2 coordinates = new Vector2 {x = 1, y = 1};
            
            Land detenetria = new Land();
            detenetria.name = "Detenetria";
            detenetria.isAccessible = true;
            detenetria.description = "";
            _lands[coordinates] = detenetria;
        }

        private void Vetria()
        {
            Vector2 coordinates = new Vector2 { x = 2, y = 3 };

            Land vetria = new Land();
            vetria.name = "Vetria";
            vetria.isAccessible = true;
            vetria.description = "";
            _lands[coordinates] = vetria;
        }

        private void Renetria()
        {
            Vector2 coordinates = new Vector2 { x = 4, y = 2 };

            Land renetria = new Land();
            renetria.name = "Renetria";
            renetria.isAccessible = true;
            renetria.description = "";
            _lands[coordinates] = renetria;
        }

        private void Kernil()
        {
            Vector2 coordinates = new Vector2 { x = 5, y = 5 };

            Land kernil = new Land();
            kernil.name = "Kernil";
            kernil.isAccessible = false;
            kernil.description = "The famous cave of Katakan is here";
            kernil.requirements = "3x Madelions";
            _lands[coordinates] = kernil;
        }

        private void Pazar()
        {
            Vector2 coordinates = new Vector2 { x = 3, y = 1 };

            Land pazar = new Land();
            pazar.name = "Pazar";
            pazar.isAccessible = true;
            pazar.description = "This is a place that you can purchase stuff to upgrade youself";
            _lands[coordinates] = pazar;
        }

    }
}
