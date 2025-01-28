using System;
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

            wr.n();
            for (int i = 0; i < Abilities.Count; i++)
            {
                Console.WriteLine($"{i + 1} - " + Abilities[i]);
            }

            while (repeat)
            {
                q1 = wr.read();
                if (Int32.TryParse(q1, out q2))
                {
                    if (q2 - 1 >= 0 || q2 <= Abilities.Count) { repeat = false; execute = Abilities[q2 - 1]; Converter(execute); }
                }
                else
                {
                    Console.WriteLine("Please use an existing ability");
                }
            }
        }

        void Converter(string queue)
        {
            switch (queue)
            {
                case "basic attack":
                    executeMove(1, 0, 1, 0);
                    break;
                case "heavy attack":
                    executeMove(1.6f, 2.5f, 3f, 0);
                    break;
                
                // sorceress special skills
                case sorcerer1:
                    executeMove(0, 2, 2.2f, 300);
                    break;
                case sorcerer2:
                    executeMove(0.4f, 1.8f, 1.8f, 0);
                    break;

                // archer special skills
                case archer1:
                    executeMove(1.7f, 0, 2, 0);
                    break;
                case archer2:
                    executeMove(1.2f, 0.4f, 1.6f, 0);
                    break;

                // warrior special skills
                case warrior1:
                    executeMove(1.2f, 0, 1.2f , 0);
                    break;
                case warrior2:
                    executeMove(3, 0.9f, 3.5f, 0);
                    break;

                // hunter special skills
                case hunter1:
                    executeMove(1.2f, 1.5f, 1.3f, 0);
                    break;
                case hunter2:
                    executeMove(1.7f, 1.7f, 2.1f, 0);
                    break;
            }
            healthCheck();
        }
        void enemysTurn()
        {
            enemies.Attack();
            healthCheck();
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
