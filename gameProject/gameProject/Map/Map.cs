using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class Map: Game
    {
        Places places = new Places();
        const int defaultWidth = 5;
        const int defaultHeight = 5;
        int width;
        int height;
        bool somewhereClose = false;
        Vector2 playerPosition;
        public Map()
        {
            playerPosition.x = 0;
            playerPosition.y = 0;
        }

        void start()
        {

        }

        public void input()
        {
            string q1;
            wr.n();
            Console.WriteLine("Where would you like to do");
            Console.WriteLine("You can go 'up, down, right, left'");
            
            while (true)
            {
                q1 = wr.read();
                switch (q1)
                {
                    case "up":
                        move(0, 1);
                        break;
                    case "down":
                        move(0, -1);
                        break;
                    case "right":
                        move(1, 0);
                        break;
                    case "left":
                        move(-1, 0);
                        break;
                    case "enter":
                        enter();
                        break;
                    case "dis":
                        display();
                        break;
                    default:
                        Console.WriteLine("This is not a valid direction");
                        break;
                }
            }
        }

        void move(int x, int y)
        {
            if (playerPosition.x + x < 0 || playerPosition.x + x > defaultWidth || playerPosition.y + y < 0 || playerPosition.y + y > defaultHeight)
            {
                wr.n();
                Console.WriteLine("There is nowhere to go");
                Console.Write(playerPosition.x);
                Console.WriteLine(" - " + playerPosition.y);
                input();
            }
            else
            {
                playerPosition.x = playerPosition.x + x;
                playerPosition.y = playerPosition.y + y;

                wr.n();
                Console.Write(playerPosition.x);
                Console.WriteLine(" - " + playerPosition.y);

                wr.n();
                landmark();

                input();
            }
            
        }

        void display()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("■");
                Console.Write(" ");
            }
        }
        
        void landmark()
        {

            if (places._lands.TryGetValue(playerPosition, out Land land))
            {
                Console.WriteLine($"You are close to the {land.name}");
                Console.WriteLine("You can go by typing 'enter'");
            }
        }

        void enter()
        {
            if (places._lands.TryGetValue(playerPosition, out Land land))
            {
                switch (land.name)
                {
                    case "Detenetria":
                        Detenetria detenetria = new Detenetria();
                        break;
                    case "Renetria":
                        Renetria renetria = new Renetria();
                        break;
                    case "Vetria":
                        Vetria vetria = new Vetria();
                        break;
                }
            }
            else
            {
                wr.n();
                Console.WriteLine("There is nowhere to go");
                input();
            }
        }

    }
}
