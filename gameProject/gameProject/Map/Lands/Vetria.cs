﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Vetria : Places
    {
        public Vetria()
        {
        }

        public void start()
        {
            Stage = 4;
            tale1();
            tale2();
        }

        void tale1()
        {
            wr.n();
            wr.print("Ugh");
            wr.print("We have been walking for forever");
            wr.print("Cant we just arrive already!");

            wr.n();
            wr.print("...");
            wr.print("...");
            wr.print("...");

            wr.n();
            wr.print("Oh we are almost here");
            wr.print("We gonna take that turn and we will see his nest");

            wr.n();
            wr.print("Just so you know it probably wont be hard");
            wr.print("but");
            wr.print("They are a bit aggresive");
            wr.print("Stay sharp, act faster");

            wr.n();
            wr.g("This is it, its his nest");
            wr.g("Lets go");

            wr.n();
            wr.en("What are you doing here humans");

            wr.n();
            wr.g("We just came to pay you a visit");
            wr.g("Is that how you treat your guests");

            wr.n();
            wr.en("You talk to much human");
            wr.en("Act more, talk less");

            wr.n();
            wr.print("- An enemy is encountered -");
            combat.start("Goblin");
        }

        public void tale2()
        {
            Stage = 41;
            wr.n();
            wr.print("Woah, that was not bad");
            wr.print("We did a pretty good job");
            wr.print("We should carry this");
            wr.print("Lets go");

            Money = Money + 8000;
            wr.print($"- You get 8000 Money. Now you have {Money} Money -");
            inventory.add("madelion");
            map.input();
        }
    }
}
