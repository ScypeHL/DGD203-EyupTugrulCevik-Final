using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class MainMenu : Game
    {
        Write wr = new Write();
        int reportTextSpeed = 0;
        public MainMenu()
        {

        }

        public void start()
        {
            Console.WriteLine("               Main Menu               ");
            Console.WriteLine("                                       ");
            Console.WriteLine("               Commands:               ");
            Console.WriteLine("            Play - Settings            ");
            primaryCommand();
        }

        void primaryCommand()
        {
            string q1 = "";   
            
            q1 = Console.ReadLine().ToLower();
            
            if (q1 == "play" || q1 == "settings" || q1 == "0") {}
            else { Console.WriteLine("The command you entered is invalid"); Console.Clear(); start(); }

            switch (q1)
            {
                case "play":
                    Console.Clear();
                    break;
                case "settings":
                    textSpeedSettings();
                    break;
                case "0":
                    BaseTextSpeed = 0;
                    Console.WriteLine($"{BaseTextSpeed}s {Spl}x");
                    break;
            }
        }

        public void textSpeedSettings()
        {
            string q1 = "";
            bool repeat = true;
            
            Console.WriteLine("Type 'start' to see several lines of text");
            Console.WriteLine("Type 'exit' to exit to the main manu");
            Console.WriteLine("Type 'reset' to reset the setting to '400'");

            while (repeat)
            {
                q1 = Console.ReadLine().ToLower();
                if (q1 == "start" || q1 == "exit" || q1 == "reset") { repeat = false; }
                else { Console.WriteLine("The command you entered is invalid"); }
            }

            switch (q1)
            {
                case "start":
                    testTextSpeed();
                    break;
                case "exit":
                    Console.Clear();
                    start();
                    break;
                case "reset":
                    BaseTextSpeed = 400;
                    Console.Clear();
                    Console.WriteLine("The text speed is reset");
                    start();
                    break;
            }

            void testTextSpeed()
            {
                Console.Clear();
                wr.print("This is a sequence");
                wr.print("to show you the preset text speed");
                wr.print("If you willing to adjust it");
                wr.print("you can type it down below");
                wr.print("to remove delay tpye '0'");
                wr.print("By default the delay is '400'");
                wr.print("To see this massage again input 'repeat'");
                setTextSpeed();
            }

            void setTextSpeed()
            {
                string q1;
                int q2;
                bool repeat1 = true;

                while (repeat1)
                {
                    q1 = Console.ReadLine();
                    if (q1 != null)
                    {
                        if (q1 == "repeat") { repeat1 = false; Console.WriteLine("repeating the sequence..."); Console.WriteLine(""); testTextSpeed(); }
                        else if (int.TryParse(q1, out q2)) { repeat1 = false; BaseTextSpeed = int.Parse(q1); Console.Clear(); start(); }
                        else { Console.WriteLine("The command you entered is invalid"); }
                    }
                    else { Console.WriteLine("The command you entered is invalid"); }
                }
            }
        }
    }
}
