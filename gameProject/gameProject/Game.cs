﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class Game
    {
        public static int Ap = 10;          // attack point
        public static int Sp = 10;          // skill point
        public static int Dp = 10;          // defence point
        public static float ASpeed = 1;     // attack speed
        public static float Hp = 100;       // health point

        public static float Xp = 0;          // experience point
        public static string ClassName;      // class name
        public static string Name = "";      // name, its not a point

        public static int BaseTextSpeed = 400;          // preset 400
        public static int Spl = 40;   // preset 40 - (speed)milisecond per letter

        public static bool yesnoOut;
        public static Random rng = new Random();
        public static List<string> notAnswer = new List<string>();

        public static string[] lands = {"Renetria", "Vetria", "Suloqinetria", "Detenetria", "Kernil", "Xhanlir", "Vezbeflin", "Trabraquel"};
        public static int Stage = 1;

        public Game()
        {
            notAnswer.Add("Are you here, why are you not answering?");
            notAnswer.Add("Did i scare you?");
            notAnswer.Add("Can you please answer the question first?");
            notAnswer.Add("Okay take your time");
            notAnswer.Add("I have plenty of time so don't worry");
        }
    }
}
