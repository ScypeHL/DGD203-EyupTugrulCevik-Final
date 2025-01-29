using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Kernil : Places
    {
        Ending ending = new Ending();
        public Kernil()
        {
        }

        public void start()
        {
            Stage = 6;
            tale1();
            tale2();
        }
        void tale1()
        {
            wr.n();
            wr.print("...");
            wr.print("Huh-");
            wr.print("This is a bit dark");
            wr.print("Watch where you steppin'");

            wr.n();
            wr.print("Now we are in somewhere dangerous");
            wr.print("But we can finally save ourselves");
            wr.print("I am so hyped right now");

            wr.n();
            wr.print("...");
            wr.print("You hear that?");
            wr.print("This way");

            wr.n();
            wr.print("...");
            wr.print("...");
            wr.g("The sound is getting louder");
            wr.g("Get ready");

            wr.n();
            wr.en("Huh");
            wr.en("What are you");

            wr.n();
            wr.g("We are humans");
            wr.g("that come here to obtain your head");

            wr.n();
            wr.en("HAHAHAHAHA");
            wr.en("Good for me then");
            wr.en("Having fans");
            wr.en("I have tears in my eyes now");
            wr.en("but a little bit after");
            wr.en("I will have blood on my hands");
            wr.en("Your blood");
            wr.en("Lets see how tasty it is");

            wr.n();
            Console.WriteLine("- A boss is encountered -");
            combat.start("Katakan");
        }

        void tale2()
        {
            wr.n();
            wr.en("AAAAAGGHH");
            wr.print("- Enemy can barely breathe -");

            wr.n();
            wr.en("After all those things i have done");
            wr.en("After all those power i got from him-");

            wr.n();
            wr.g("Wait, is the guy in question 'Kaneae'?");

            wr.n();
            wr.en("If you are his men");
            wr.en("Why did you do this to me");

            wr.n();
            wr.g("You master causing us trouble");
            wr.g("How nice it is");
            wr.g("We got you, a pet of his");
            wr.g("No we have to do one last thing");

            wr.n();
            wr.print("- Clapping sound is ecoing in the cave -");
            wr.k("Well done, two of you");
            wr.k("Coungratz, You found me");
            wr.k("Now please do your thing");
            tale3();
        }

        void tale3()
        {
            wr.n();
            wr.g("This is another days job");
            wr.g("But what i can say is");
            wr.g("There are people looking for you");

            wr.n();
            wr.g($"My {Name} friend is kidnapped by them");
            wr.g("I am a guide after all");
            wr.g("and i can say those people are something");

            wr.n();
            wr.print("- Kaneae's eye stars to glow -");

            wr.n();
            wr.k("seems like you are not lying");
            wr.k("Then lets do it like that");

            wr.n();
            wr.print("- Kaneae gives you some stuff -");

            wr.n();
            wr.k("Take those and find them, kill them");
            wr.k("If you do, you can keep the equipments");
            wr.k("Who knows, maybe they increases your chance against me");

            wr.n();
            wr.g("And what if we dont");

            wr.n();
            wr.k("You guys just fought a 'Katakan'");
            wr.k("Do i have to say anything else");

            wr.n();
            wr.g("Right right i got it");

            wr.n();
            wr.k("This is a 'yes' then");

            wr.n();
            wr.g("Lets go");
            wr.g("We have a job to do");

            wr.n();
            wr.print("- You both leaves the cave -");
            wr.print("- For a who knows adventure -");
            ending.start();
        }
    }
}
