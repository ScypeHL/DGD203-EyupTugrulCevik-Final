using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Detenetria:Places
    {
        Yesno yesno = new Yesno();
        Write wr = new Write();
        public Detenetria()
        {
            tale1();
            tale2();
        }

        public void tale1()
        {
            string q1;
            string q2;
            bool repeat = true;
            bool repeat2 = true;

            wr.n();
            wr.print("So we are heading up to Detenetria");
            wr.print("I have heard about that place of course");
            wr.print("That 'tria' lands are so boring");
            wr.print("All of 'em are just trade cities");
            wr.print("Tons of people doing literally nothing");

            wr.n();
            Console.WriteLine("1- I wouldn't talk about trading like that");
            Console.WriteLine("2- Isn't it good that people living a peaceful life");
            Console.WriteLine("3- Yeah i feel you");

            while (repeat)
            {
                q1 = Console.ReadLine();
                if (q1 == "1")
                {
                    repeat = false;
                    wr.n();
                    wr.print("Yeah yeah i know, money being a thing is the problem tho");
                    wr.print("You also need some");
                }
                else if (q1 == "2")
                {
                    repeat = false;
                    wr.n();
                    wr.print("Peaceful life :D? Are you kidding? They are being drained by their employers");
                    wr.print("They are not happy, but i cant ignore that there are people protecting them. I guess that is a thing");
                    wr.print("Not everyone can live like this");
                    wr.print("We are doing a pretty tough thing");
                    
                    wr.n();
                    wr.print("1- Tough thing, you say? We are fiddling around for ours");
                    wr.print("2- Actually i was wondering why did they hire us");

                    while (repeat2)
                    {
                        q2 = Console.ReadLine();
                        if (q1 == "1")
                        {
                            wr.n();
                            wr.print("Its not me bro come on. This place is so weird placed");
                            wr.print("Everything is everywhere");
                            wr.print("But it seems like we are almost there");
                            wr.print("The paper is pointing somewhere around here");
                        }
                        else if (q1 == "2")
                        {
                            wr.n();
                            wr.print("Beats me");
                            wr.print("But the level was not that high so");
                            wr.print("Its okay, i guess.");
                            wr.print("...");
                            wr.print("And it seems like we are almost there");
                            wr.print("The paper is pointing somewhere around here");
                        }
                    }

                }
                else if (q1 == "3")
                {
                    repeat = false;
                    wr.n();
                    wr.print("I am glad we don't have to care about our lifes that much, right?");
                    wr.print("Not that i hate living or anything like that but...");
                    wr.print("It is a bit weird");
                    wr.print("We are living");
                    wr.print("We are literally living");
                    wr.print("It has been so long since i feel that way");
                    wr.print("Do you feeling it too");
                    
                    yesno.start();
                    if (yesnoOut) { wr.print("What a good day to live"); }
                    else if (!yesnoOut) { wr.print("Cant you at lest keep up with me for once"); }
                    else { wr.print("bug at -file Detenetria -line 95"); }
                    
                    wr.n();
                    wr.print("...");
                    wr.print("Ugh... Hmm...");
                    wr.print("According to the paper their place should be here");
                }
                else { wr.print(notAnswer[rng.Next(0, 5)]); }


            }

        }

        void tale2()
        {
            string q1;
            bool repeat = true;

            wr.n();
            wr.print("...");
            wr.print("Ah there is a village over there");
            wr.print("Come on, move!");

            wr.n();
            wr.print("Seems like this is the place");
            wr.print("Now we are waiting");

            wr.n();
            wr.print("...");
            wr.print("-Some time has passed-");
            wr.print("...");

            wr.n();
            wr.print("I really am about to start to think that we are tricked");
            wr.print("So what are we doing?");
            
            wr.n();
            Console.WriteLine("1- Let's wait a bit more");
            Console.WriteLine("2- Let's go, we have quite a lot of things to do");

            while (repeat)
            {
                q1 = Console.ReadLine();
                if (q1 == "1") { repeat = false; wr.n(); wr.print("Okay, lets wait a bit more then."); tale21(); }
                else if (q1 == "2") { repeat = false; wr.print("Yeah, its getting annoying. Lets go"); tale22(); }
                else { wr.print("bug in -file Detenetria -line 140"); }

            }
        }

        void tale21()
        {
            wr.n();
            wr.print("...");
            wr.print("...");

            wr.n();
            wr.print("Oh finally someone is coming");

            wr.n();
            wr.print("-Someone opens the door");
            
            wr.s("Oh my, sorry if i make you wait");
            wr.s("There were things i had to take care of");

            wr.n();
            wr.g("No no, we just arrived, no worries");
            wr.g("Then can we please talk about the job in more detail");

            wr.n();
            wr.s("Oh yes, of course");
            wr.s("What i demand from you is something that belongs to me");
            wr.s("It is stolen from my basement");

            wr.n();
            wr.g("What does that object look like");

            wr.n();
            wr.s("Oh, please come downstairs");
            wr.s("I have a pitcure of it");

        }
        
        void tale22()
        {
            wr.n();
            wr.print("I cant believe they tricked us");
            wr.print("This is so annoying");
            wr.print("...");
            wr.print("But, you know");
            wr.print("since we are here now");
            wr.print("Do you want to go to the city");
            wr.print("In case you want to buy something?");
        }
    }
}
