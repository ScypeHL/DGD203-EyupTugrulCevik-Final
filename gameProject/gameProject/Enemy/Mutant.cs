using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Mutant : Enemies
    {
        public Mutant()
        {
            EnemyAp = 18;
            EnemySp = 6;
            EnemyDp = 12;
            EnemyASpeed = 0.7f;
            EnemyHp = 75;
        }
    }
}
