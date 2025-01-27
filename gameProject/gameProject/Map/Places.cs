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
        }

        public void start(string landName)
        {
            Detenetria();
            Vetria();
            Renetria();
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

    }
}
