using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Renetria:Places
    {
        public Renetria()
        {
            start();
        }

        void start()
        {
            tale1();
            tale2();
            tale3();
            tale4();
            tale5();
            tale6();
            tale7();
        }
        void tale1()
        {
            string q1 = "";

            wr.n();
            wr.print("We are not that far from the city");
            wr.print("Just that hill and we should see the people");
            wr.print("Isn't it great");
            wr.print("Like");
            wr.print("They are kind of isolated from the world");
            wr.print("But the weirdest part is");
            wr.print("This city is actually a port city");
            wr.print("and we are about a kilometer away from the sea level by now");
            wr.print("Yet we are climbing");
            wr.print("still...");

            wr.n();
            Console.WriteLine("1 - But would you like to live like that");
            Console.WriteLine("2 - How do you think the people will treat us");

            while (true)
            {
                q1 = wr.read();
                if (q1 == "1") { tale11(); break; }
                else if (q1 == "2") { tale12(); break; }
                else { }
            }
        }

        void tale11()
        {
            wr.n();
            wr.print("Of course i would");
            wr.print("What is wrong with that");
            wr.print("I mean you are isolated form the world but");
            wr.print("That is a problem only because we saw the outer world");

            wr.n();
            wr.print("Ugh- just one more step");
            wr.print("aaaaaand-");
            wr.print("Here we are");
            wr.print("Renetria, the city of what");
            wr.print("opportunities?");
            wr.print("maybe it is");
            wr.print("lets find out then");
        }

        void tale12()
        {
            wr.n();
            wr.print("This man");
            wr.print("Everytime i go somewhere for the first time");
            wr.print("I get so tense");
            wr.print("Like i forget how to speak");

            wr.n();
            wr.print("I hope we get along with people");
            wr.print("and just like that");
            wr.print("We arrived");

            wr.n();
            wr.print("Renetria, right");
            wr.print("I heard about that place");
            wr.print("But it looks way nicer to me");
            wr.print("Oh right, lets go get the job first");
            wr.print("before it gets late");
        }

        void tale2()
        {
            wr.n();
            wr.g("...");
            wr.g("This- what is this?");
            wr.g("Ow right, these are the quests");

            wr.n();
            wr.s("Welcome to Renetria foreigners");
            wr.s("How may i help you");

            wr.n();
            wr.g("Oh hello, we are actually looking for a job");
            wr.g("Any- kind of job");

            wr.n();
            wr.s("Is there anything you guys interested on the board");
            wr.s("If not i may suggest one");

            wr.n();
            wr.g("Lets hear you deal first then");

            wr.n();
            wr.s("I would be honored");
            wr.s("Please, this way");
        }

        void tale3()
        {
            wr.n();
            wr.print("...");

            wr.n();
            wr.g("so, lets hear it");

            wr.n();
            wr.s("Okay, then lets do this");
            wr.c("I have the intel");
            wr.c("I dont know where exactly it is");
            wr.c("but");
            wr.c("Here it is, the map");
            wr.c("I marked the location");
            wr.c("What you are looking for is a chest");
            wr.c("Orange and brown");

            wr.n();
            wr.g("Aaaaand");

            wr.n();
            wr.c("10000");
            wr.c("No more");
            wr.c("Deal?");
            wr.g("Deal");

            wr.n();
            wr.print("...");

            wr.n();
            wr.g("Well then");
            wr.g("We better go");

            wr.n();
            wr.c("Have a nice trip");

        }

        void tale4()
        {
            wr.n();
            wr.print("...");
            wr.print("...");

            wr.n();
            wr.print("So this-");
            wr.print("This is-");
            wr.print("A lake?");
            wr.print("Aww come on man");
            wr.print("Do we really have to dive into that thing");
            wr.print("Oh wait");
            wr.print("Wait wait wait wait wait");

            wr.n();
            wr.print("Hold that rope");
            wr.print("I say '3' and you pull the rope");
            wr.print("Got it?");
            wr.print("Got it");

            wr.n();
            wr.print("3");
            wr.print("2");
            wr.print("1");
            wr.print("Now!");

            wr.n();
            wr.print("Pull it");
            wr.print("Come on");
            wr.print("Yes, its moving");
            wr.print("Over here");

            wr.n();
            wr.print("...");
            wr.print("...");
            wr.print("...");
            
            wr.n();
            wr.print("Dont get too close to it");
            wr.print("might be living still");

            wr.n();
            Console.WriteLine("1 - What is this thing");
            Console.WriteLine("2 - Can you at least tell me what are we onto");

            string q1 = "";
            while (true)
            {
                q1 = wr.read();
                if (q1 == "1") { tale41(); break; }
                else if (q1 == "2") { tale42(); break; }
                else { Console.WriteLine("bug"); }
            }
        }

        void tale41()
        {
            wr.n();
            wr.print("So this thing, is some sort of a mutant");
            wr.print("that lives spesifically places like those");
            wr.print("I saw some so i knew that was one of those");

            wr.n();
            wr.print("Lets just hope that he ate our chest");
            wr.print("so we cen obtain it easily");
            wr.print("otherwise-");
            wr.print("I dont even wanna thing 'otherwise'");
        }

        void tale42()
        {
            wr.n();
            wr.print("Yeah, right");
            wr.print("so this- is a mutant basically");
            wr.print("How it helps is about its eating habits");
            wr.print("The usually eat a kind of plant called 'Gerp'");
            wr.print("And what a coincidence is that");
            wr.print("Those 'Gerps' is generally orange and yellow");

            wr.n();
            wr.print("So maybe");
            wr.print("maybe");
            wr.print("If it ate our chest");
            wr.print("Our job is mostly over");
        }

        void tale5()
        {
            wr.n();
            wr.print("So lets see");
            wr.print("...");
            wr.print("...");
            wr.print("Oh, no no no");
            wr.print("Step back, step back");
            wr.print("Its still living");

            wr.n();
            wr.en("AAAAAAAAGGGGHHH");

            wr.n();
            Console.WriteLine(" - An enemy is encountered - ");
            combat.start("Mutant");
        }

        void tale6()
        {
            wr.n();
            wr.print("Woah, that was freaking good");
            wr.print("And the most important");
            wr.print("- Guide tears enemy's stomach -");

            wr.n();
            wr.print("...");
            wr.print("...");
            wr.print("YEEEEEEEEAAHHHHHH");
            wr.print("We made it");
            wr.print("This is it, the box");
            wr.print("Now move your ass and help me get it");

            wr.n();
            wr.print("- You get the box -");

            wr.n();
            wr.print("Finally we can go back");
            wr.print("I dont wanna waste any more of my seconds here");
            wr.print("Lets go");
        }

        void tale7()
        {
            wr.n();
            wr.g("Hello, are you here");

            wr.n();
            wr.c("Come inside");
            wr.c("I was washing the dishes, sorry");
            wr.c("So, you find the box?");

            wr.n();
            wr.g("Of course we did but first");

            wr.n();
            wr.c("Here it is");
            wr.c("10000");

            wr.n();
            Money = Money + 10000;
            wr.print($"- You get 10000 Money. Now you have {Money} Money -");

            wr.c("and-");

            wr.n();
            wr.g("Here is your chest");

            wr.n();
            wr.c("Oh my- what happened to it");
            wr.c("What is this-");

            wr.n();
            wr.g("Oh yeah, we found out that a mutant ate your chest");
            wr.g("So this is not about us");

            wr.n();
            wr.c("Yeah i see that");
            wr.c("Anyway thank you for your help");

            wr.n();
            wr.g("Anywhere, anytime");
            wr.g("Have a nice day");

            inventory.add("madelion");
            map.input();
        }
    }
}
