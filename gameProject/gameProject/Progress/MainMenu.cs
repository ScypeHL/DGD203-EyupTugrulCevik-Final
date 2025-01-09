using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class MainMenu : Game
    {
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
            
            q1 = wr.read();

            switch (q1)
            {
                case "play":
                    checkandclear();
                    gameStarted = true;
                    break;
                case "settings":
                    textSpeedSettings();
                    break;
                case "debug":
                    Debug();
                    break;
                case "0":
                    BaseTextSpeed = 0;
                    gameStarted = true;
                    Console.WriteLine($"{BaseTextSpeed}s {Spl}x");
                    break;
                default:
                    checkandclear();
                    Console.WriteLine("The command you entered is invalid");
                    start();
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

                switch (q1)
                {
                    case "start":
                        testTextSpeed();
                        break;
                    case "exit":
                        checkandclear();
                        start();
                        break;
                    case "reset":
                        BaseTextSpeed = 400;
                        checkandclear();
                        Console.WriteLine("The text speed is reset");
                        start();
                        break;
                    default:
                        Console.WriteLine("The command you entered is invalid");
                        break;
                }
            }
            
            void testTextSpeed()
            {
                checkandclear();
                wr.print($"This is a sequence {BaseTextSpeed} - {Spl}");
                wr.print("to show you the preset text speed");
                wr.print("If you willing to adjust it");
                wr.print("you can type it down below");
                wr.print("to remove delay tpye '0'");
                wr.print("By default the delay is '400'");
                wr.print("To see this massage again input 'repeat'");
                wr.print("To apply the speed you previously entered press 'Enter'");
                setTextSpeed();
            }

            void setTextSpeed()
            {
                string q1;
                int q2;
                string q3 = "";
                bool repeat1 = true;
                bool repeat2 = true;

                while (repeat1)
                {
                    q1 = Console.ReadLine().ToLower();
                    if (q1 != null)
                    {   
                        if (q1 == "" || q1 == null) { q1 = "";  }
                        else if (int.TryParse(q1, out q2)) 
                        { 
                            if (!gameStarted)
                            {
                                repeat1 = false;
                                BaseTextSpeed = int.Parse(q1);
                                Spl = BaseTextSpeed / 10;
                                Console.WriteLine($"The text speed is set to {BaseTextSpeed}");
                                Console.WriteLine("Type 'repeat' to test the text speed");
                                Console.WriteLine("Type 'exit' to exit settings");

                                while (repeat2)
                                {
                                    q3 = Console.ReadLine().ToLower();
                                    if (q3 == "repeat") { testTextSpeed(); }
                                    else if (q3 == "exit") 
                                    {
                                        repeat2 = false;
                                        checkandclear();
                                        Console.WriteLine($"The text speed is set to {BaseTextSpeed} successfuly");
                                        start();
                                    }
                                    else { Console.WriteLine("The command you entered is invalid"); }
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        else { Console.WriteLine("The command you entered is invalid"); }
                    }
                    else 
                    {
                        checkandclear();
                        Console.WriteLine("The text speed is adjusted successfuly");
                        start();
                    }
                }
            }
        }
        void Debug()
        {
            string q1 = "";
            bool repeat = true;
            while (repeat)
            {
                q1 = Console.ReadLine().ToLower();
                if (q1 == "combat")
                {
                    combat.start("Goblin");
                }
            }
        }

        void checkandclear()
        {
            if (!gameStarted)
            {
                Console.Clear();
            }
            else
            {
                return;
            }
        }
    }
}
