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
        public Detenetria()
        {
        }

        public void start()
        {
            Stage = 3;
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
                q1 = wr.read();
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
                        q2 = wr.read();
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
                q1 = wr.read();
                if (q1 == "1") { repeat = false; wr.n(); wr.print("Okay, lets wait a bit more then."); tale21(); }
                else if (q1 == "2") { repeat = false; wr.print("Yeah, its getting annoying. Lets go"); tale22(); }
                else { wr.print("bug in -file Detenetria -line 140"); }

            }
        }

        void tale21()
        {
            string q1;
            bool repeat = true;
            
            wr.n();
            wr.print("...");
            wr.print("...");

            wr.n();
            wr.print("Oh finally someone is coming");

            wr.n();
            wr.print("-Someone opens the door-");

            wr.n();
            wr.s("Oh my, sorry if i make you wait");
            wr.s("There were things i had to take care of");

            wr.n();
            wr.g("No no, we just arrived, no worries");
            wr.g("Then can we please talk about the job in more detail");

            wr.n();
            wr.c("Oh yes, of course");
            wr.c("What i demand from you is something that belongs to me");
            wr.c("It is stolen from my basement");

            wr.n();
            wr.g("And what does that object look like");

            wr.n();
            wr.c("I can show a copy of it if you will");
            wr.c("Please come downstairs");

            wr.n();
            wr.g("What, no! Bring it here");

            wr.n();
            wr.s("Did I say something wrong");

            wr.n();
            Console.WriteLine("1 - Let's take a look");
            Console.WriteLine("2 - Why don't we just get the intel and then go");

            while (repeat)
            {
                q1 = wr.read();
                if (q1 == "1") { repeat = false; tale3(); }
                else if (q1 == "2") { repeat = false; tale211(); }
                else { Console.WriteLine("Excuse me?"); }

            }

        }

        void tale211()
        {
            wr.n();
            wr.c("Look, this is no joke");
            wr.c("I will treat you well if you bring me what i want");
            wr.c("As you can understand this thing worth more than you can imagine");
            wr.c("I want to show it to you so you will have the best intel you can get");
            wr.c("Everything's okay now?");

            yesno.start();
            if (yesnoOut) { tale3(); }
            else if (!yesnoOut) { tale31(); }
            else { Console.WriteLine("bug in Detenetria at line 219"); }
        }
        
        public void tale3()
        {
            Stage = 31;
            bool repeat = true;
            string q1;
            
            wr.n();
            wr.c("Good, now follow me to the downstairs");
            wr.c("I'm headin up first");

            wr.n();
            wr.print("...");
            wr.print("- You take the stairs and go downstairs -");
            wr.print("...");

            wr.n();
            wr.g("- Cough cough -");
            wr.g("What is wrong with that place");
            wr.g("And why is it so dark in here");

            wr.n();
            wr.s("Come here");

            wr.n();
            wr.g("Where is 'here' you pi...");
            wr.g("This way i assume");
            wr.g("Let's go");

            wr.n();
            wr.print("...");
            wr.print("...");

            wr.n();
            wr.g("You know what, maybe we should go back");

            wr.n();
            Console.WriteLine("1 - Why is it?");
            Console.WriteLine("2 - How is this place so big");


            while (repeat)
            {
                q1 = wr.read();
                if (q1 == "1") { repeat = false; wr.g("We are walking like 5 minutes straight. This guy is onto something, lets just go back"); tale4(); }
                else if (q1 == "2") { repeat = false; wr.g("Yeah, that is what i was thinking. There is something wrong, we should go back"); tale4(); }
                else { }
            }

        }

        void tale31()
        {
            wr.n();
            wr.s("I really dont wanna waste my time with you two");
            wr.s("You can go now");

            wr.n();
            wr.g("...");
            wr.g("Have a nice day");

            wr.n();
            wr.print("...");
            wr.g("What is wrong with you");
            wr.g("Why did you just behave");
            wr.g("Now we lost the job, thanks");
            wr.g("Im gonna grab something to eat");

            wr.n();
            wr.g("go get me after you done");
            wr.g("I will be at the city center");
            shop.print();

            wr.n();
            wr.print("done?");
            wr.print("lets go then");
            ender();
        }

        void tale4()
        {
            wr.n();
            wr.print("- You guys decided to go back -");
            wr.print("- And than you figured something out -");

            wr.n();
            wr.g("Umm...");
            wr.g("Yeah we stepped down from here");
            wr.g("I remember that desk");
            wr.g("...");
            wr.g("Am i dumb, do you see the stairs");
            wr.g("Actually at first i thought that man was trying to kidnap us or something but");
            wr.g("i dont think he has powers to make a part of a structure vanish");

            wr.n();
            wr.print("...");
            wr.print("- An obnoxious smell scent fills the room -");
            wr.print("- Something appears in the dark -");

            wr.n();
            wr.u("Well well well");
            wr.u("Our guest are being a little bit loud arent they?");

            wr.n();
            wr.g("And there it goes");

            wr.n();
            wr.u("I have prepared a well made meal to celebrate your appearance");
            wr.u("Would you like to join me?");

            wr.n();
            wr.g("Fuck no!");

            wr.n();
            wr.en("No Mr. Guide, you would..");

            wr.n();
            wr.print("- An enemy is encountered -");
            
            combat.start("Vinil");
            
            tale41();

        }
        public void tale41()
        {
            Stage = 32;
            string q1 = "";
            
            wr.n();
            wr.en("It is- impossible... you-");

            wr.n();
            wr.g("Yeah, thats what they all say");
            wr.g("I am this and you mere people could not beat me and blah blah");
            wr.g("Let's see what you're made of");

            wr.n();
            wr.print("- Guide takes an action to the enemy -");

            wr.n();
            wr.en("Okay okay don't, i will take you back please don't...");

            wr.n();
            wr.print("- The stairs appear -");

            wr.n();
            wr.en("I broke the illusion, this way takes you outside of the chamber");

            wr.n();
            wr.g("Chamber spell, illusions... This guy is really something");
            wr.g("Oh right. Let's go, we had wasted our time enough.");

            wr.n();
            wr.print("- You take the stairs -");

            wr.n();
            wr.c("So?");

            wr.n();
            wr.g("So?!?!");
            wr.g("You motherfucker");
            wr.g("You knew that...");

            wr.n();
            wr.c("That is why i pay that money");
            wr.c("You guys get the job done i assume");

            wr.n();
            Console.WriteLine("1 - As clean as possible");
            Console.WriteLine("2 - I mean come on at least say that we had to stand against a 'Vinil'");

            while (true)
            {
                q1 = wr.read();
                if (q1 == "1") { tale412(); break; }
                else if (q1 == "2") { tale411(); break; }
                else { Console.WriteLine("bug in Detenetria at line 370"); }
            }
        }

        void tale411()
        {
            wr.n();
            wr.c("Would you like to take that job if i told it");

            wr.n();
            wr.g("P- probably yeah");

            wr.n();
            wr.c("Oh really, would you do that");

            wr.n();
            wr.g("We are here for the money, that is the only thing we care");

            wr.n();
            wr.c("Well then here is you reward");
            tale5();
        }

        void tale412()
        {      
            wr.n();
            wr.g("I mean yeah, we handled it.");

            wr.n();
            wr.c("Well then. You did your part");
            wr.c("Now its my turn");
            tale5();
        }

        void tale5()
        {
            Money = Money + 20000;
            wr.print($"- You get 20000 Money. Now you have {Money} Money -");

            wr.n();
            wr.c("I hope we get along well");
            wr.c("I would like to work with you in future");

            wr.n();
            wr.g("Thanks for everything");
            wr.g("Take care!");
            wr.print("...");
            ender();
        }

        void tale22()
        {
            wr.n();
            wr.print("I cant believe they tricked us");
            wr.print("This is so annoying");
            wr.print("...");
            wr.print("But, you know");
            wr.print("since we are here now");
            wr.print("Lets just go buy sıme stuff");

            wr.n();
            wr.print("...");
            wr.print("...");
            wr.print("...");

            wr.n();
            wr.print("Here we are, lets take a look");
            shop.print();
            ender();
            
        }

        void ender()
        {
            inventory.add("madelion");
            map.input();
        }
    }
}
