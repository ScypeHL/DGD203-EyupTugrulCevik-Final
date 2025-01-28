using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class Enemy:Game
    {
        Enemies enemies = new Enemies();
        public Enemy(Enemies Enemies)
        {
            enemies = Enemies;
        }
    }
}
