using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Test1: Enemies
    {
        public Test1()
        {
            EnemyAp = 40;
            EnemySp = 0;
            EnemyDp = 3;
            EnemyASpeed = 1.6f;
            EnemyHp = 80;

        }
    }
}
