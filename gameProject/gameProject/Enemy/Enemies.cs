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
                Hp = Hp - (EnemyAp * 1.1f + EnemySp * 1.2f);
                combat.enemyQueue = combat.enemyQueue + 120;
                wr.print($"Enemy deals {EnemyAp * 1.1f + EnemySp * 1.2f} damage - {Hp}Hp left");
            }
            else if (randomizer < 30)
            {
                Hp = Hp - (EnemyAp * 1.6f + EnemySp * 1.4f);
                combat.enemyQueue = combat.enemyQueue + 200;
            }
        }

    }
}
