using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class Enemies : Game
    {
        public Enemies()
        {
        }

        public void Attack()
        {

            int randomizer = rng.Next(1, 101);
            if (randomizer >= 30)
            {
                currentHp = currentHp - (EnemyAp * 1.1f + EnemySp * 1.2f) * (100 - Dp);
                combat.enemyQueue = combat.enemyQueue + 120 * (2 - EnemyASpeed);
                wr.print($"Enemy deals {EnemyAp * 1.1f + EnemySp * 1.2f} damage - {currentHp}Hp left");
            }
            else if (randomizer < 30)
            {
                currentHp = currentHp - (EnemyAp * 1.6f + EnemySp * 1.4f) * (100 - Dp);
                combat.enemyQueue = combat.enemyQueue + 200 * (2 - EnemyASpeed);
            }
        }

    }
}
