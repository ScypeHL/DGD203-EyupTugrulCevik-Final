using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class Combat : Game
    {
        string execute;
        float playerQueue;
        public float enemyQueue;
        float holdHP;
        float holdEnemyHP;

        bool hasVinil = false;
        bool hasGoblin = false;
        bool hasMutant = false;

        Vinil vinil;
        Mutant mutant;
        Goblin goblin;
        Enemies enemies = new Enemies();

        const string hunter1 = "hole maker";
        const string hunter2 = "king slicer";
        const string warrior1 = "silver steel";
        const string warrior2 = "edge of the hell";
        const string sorcerer1 = "frozen strike";
        const string sorcerer2 = "fireball";
        const string archer1 = "piercing shot";
        const string archer2 = "arrow rain";
        public Combat()
        {

        }

        void executeMove(float apScale, float spScale, float cooldown, int ccDelay)
        {
            float damage = apScale * Ap + spScale * Sp * 1.6f;
            
            EnemyHp = EnemyHp - damage;
            playerQueue = playerQueue + ((2 - ASpeed) * 100) * cooldown;

            Console.WriteLine($"You dealt '{damage}' damage - Enemy has {EnemyHp}Hp");
            if (ccDelay > 0) { enemyQueue = enemyQueue + ccDelay; }
        }
        public void start(string enemytype)
        {
            holdHP = currentHp;
            holdEnemyHP = EnemyHp;
            
            enemyType = enemytype;
            switch (enemyType)
            {
                case "Vinil":
                    Enemy vinil = new Enemy(new Vinil());
                    break;
                case "Mutant":
                    Enemy mutant = new Enemy(new Mutant());
                    break;
                case "Goblin":
                    Enemy goblin = new Enemy(new Goblin());
                    break;
                case "Test1":
                    Enemy test1 = new Enemy(new Test1());
                    break;
                case "Katakan":
                    Enemy katakan = new Enemy(new Katakan());
                    break;

            }

            playerQueue = 0;
            enemyQueue = 0;
            playerQueue = playerQueue + (2 - ASpeed * 100);
            enemyQueue = enemyQueue + (2 - EnemyASpeed * 100);
            compareSpeed();
        }

        void compareSpeed()
        {
            playersTurn();
        }

        void healthCheck()
        {
            if (currentHp <= 0) { lost(); }
            else if (EnemyHp <= 0) { win(); }
            else { queueMeter(); }
        }
        
        void queueMeter()
        {  
            while (true)
            {
                playerQueue = playerQueue - 1;
                enemyQueue = enemyQueue - 1;

                if (Math.Clamp(0, playerQueue, 999) == 0)
                {
                    playersTurn();
                    break;
                }
                else if (Math.Clamp(0, enemyQueue, 999) == 0)
                {
                    enemysTurn();
                    break;
                }
            }
        }

        void playersTurn()
        {
            string q1;
            int q2;
            bool repeat = true;
            
            wr.n();
            Console.WriteLine("Your turn");
            printMove();

            q1 = wr.read();
            if (Int32.TryParse(q1, out q2) && q2 >= 1 && q2 <= 4) { Converter(q2); }
            else { Console.WriteLine("This is not an existing ability"); }

        }

        void Converter(int queue)
        {
            if (ab._abilities.TryGetValue(queue, out Ability ability))
            {
                Console.WriteLine($"You have executed {ability.name}");
                executeMove(ability.apScale, ability.spScale, ability.cooldown, ability.ccDealy);
                healthCheck();
            }
            else
            {
                Console.WriteLine("This is not an existing ability");
                playersTurn();
            }
            
        }
        void enemysTurn()
        {
            enemies.Attack();
            healthCheck();
        }

        void printMove()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"{i} - {ab._abilities[i].name} > || Damage:{ab._abilities[i].apScale * Ap + ab._abilities[i].spScale * Sp * 1.6f}|| Cooldown:{((2 - ASpeed) * 100) * ab._abilities[i].cooldown}|| CC:{ab._abilities[i].ccDealy}tick||");
            }
                
        }
        
        void win()
        {
            string q1 = "";
            wr.n();
            Console.WriteLine("- You won -");
            Console.WriteLine("Press enter to countinue");

            while (true)
            {
                q1 = wr.read();
                if (q1 == "") { break; }
                else
                {
                    Console.WriteLine("Invalid command");
                }
            }
        }

        void lost()
        {
            string q1 = "";
            wr.n();
            Console.WriteLine("- You lost -");
            Console.WriteLine("Press enter to play the fight again");

            while (true)
            {
                q1 = wr.read();
                if (q1 == "") { currentHp = holdHP; EnemyHp = holdEnemyHP; start(enemyType); break; }
                else
                {
                    Console.WriteLine("Invalid command");
                }
            }
        }
    }

}
