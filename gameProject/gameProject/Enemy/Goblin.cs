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
            EnemyAp = 6;
            EnemySp = 0;
            EnemyDp = 3;
            EnemyASpeed = 1.4f;
            EnemyHp = 400;

        }
    }
}
