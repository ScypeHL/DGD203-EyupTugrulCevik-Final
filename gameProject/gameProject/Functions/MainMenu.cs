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
                    Spl = BaseTextSpeed / 10;
                    break;
                case "settings":
                    textSpeedSettings();
                    break;
                case "debug":
                    BaseTextSpeed = 0;
                    Spl = BaseTextSpeed / 10;
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
                        repeat = false;
                        break;
                    case "exit":
                        checkandclear();
                        start();
                        repeat = false;
                        break;
                    case "reset":
                        BaseTextSpeed = 400;
                        checkandclear();
                        Console.WriteLine("The text speed is reset");
                        start();
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("The command you entered is invalid");
                        break;
                }
            }
            
            void testTextSpeed()
            {
                checkandclear();
                wr.print("This is a sequence");
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
                    if (q1 != null || q1 != "")
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
                                    if (q3 == "repeat") { testTextSpeed(); repeat2 = false; }
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
                                Console.WriteLine($"The text speed is set to {BaseTextSpeed} successfuly");
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
                    repeat = false;
                    combat.start("Test1");
                }
                if (q1 == "shop")
                {
                    repeat = false;
                    shop.print();
                }
                if (q1 == "map")
                {
                    repeat = false;
                    inventory.add("madelion");
                    inventory.add("madelion");
                    inventory.add("madelion");
                    map.input();
                }
                if (q1 == "inv")
                {
                    repeat = false;
                    Console.WriteLine("'5' should be printed");
                    inventory.add("debug");
                    inventory.add("debug");
                    inventory.add("debug");
                    inventory.add("debug");
                    inventory.add("debug");
                    inventory.count("debug");
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
