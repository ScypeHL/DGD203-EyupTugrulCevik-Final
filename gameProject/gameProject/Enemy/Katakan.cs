using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Katakan: Enemies
    {
        public Katakan()
        {
            EnemyAp = 6;
            EnemySp = 6;
            EnemyDp = 40;
            EnemyASpeed = 1f;
            EnemyHp = 200;
        }
    }
}
