using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pro
{
    public class Write:Game
    {
        int textLenght;
        public Write()
        {
        }

        
        public void n()
        {
            Console.WriteLine("");
        }
        public void print(string text)
        {
            Console.WriteLine(text);
            textLenght = text.Length;
            Thread.Sleep(BaseTextSpeed + textLenght * Spl);
        }
        public void g(string text)
        {
            Console.WriteLine("[Guide] " + text);
            textLenght = text.Length;
            Thread.Sleep(BaseTextSpeed + textLenght * Spl);
        }
        public void en(string text)
        {
            Console.WriteLine("[Enemy] " + text);
            textLenght = text.Length;
            Thread.Sleep(BaseTextSpeed + textLenght * Spl);
        }

        public void s(string text)
        {
            Console.WriteLine("[Someone] " + text);
            textLenght = text.Length;
            Thread.Sleep(BaseTextSpeed + textLenght * Spl);
        }

        public void u(string text)
        {
            Console.WriteLine("[Unknown] " + text);
            textLenght = text.Length;
            Thread.Sleep(BaseTextSpeed + textLenght * Spl);
        }

        public void c(string text)
        {
            Console.WriteLine("[Client] " + text);
            textLenght = text.Length;
            Thread.Sleep(BaseTextSpeed + textLenght * Spl);
        }

        public string read()
        {
            string q1 = "";
            Read();
            void Read()
            {
                string q2;

                q1 = Console.ReadLine().ToLower();

                if (q1 == "command")
                {
                    wr.n();
                    Console.WriteLine("Available commands:");
                    Console.WriteLine("Settings");
                    Console.WriteLine("Save");
                    Console.WriteLine("Typing anything else will stop the 'command' section");
                    q2 = Console.ReadLine().ToLower();
                    switch (q2)
                    {
                        case "settings":
                            menu.textSpeedSettings();
                            read();
                            break;
                        case "save":
                            save.save();
                            read();
                            break;
                        default:
                            read();
                            break;
                    }
                }
                else
                {

                }
            }
            return q1;
        }

    }
}
