using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Goblin : Enemies
    {
        public Goblin()
        {
            EnemyAp = 8;
            EnemySp = 0;
            EnemyDp = 3;
            EnemyASpeed = 1.6f;
            EnemyHp = 80;

        }
    }
}
