using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pro
{
    internal class Write:Game
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

    }
}
