namespace Pro
{
    public class CharacterCreation : Game
    {
        Classes classes = new Classes();
        Write wr = new Write();

        bool regret = false;
        string birthplace = lands[rng.Next(0, 8)];

        public CharacterCreation()
        {
            Spl = BaseTextSpeed / 10;
        }

        // text boxes are in the -start and -createClass
        #region start
        public void start()
        {
            wr.print("Welcome to our fantastic world");
            wr.print("with all the things waiting to be discovered.");
            wr.print("You will be greeted by everything");
            wr.print("But i cant say that 'everthing' will treat you well");
            wr.print("We dont want something bad happens to you, right?");

            wr.n();
            wr.print("Thats why i will be your guide");
            wr.print("But");
            wr.print("Since we will be sharing our some time together");
            wr.print("I thing addressing to you with your name would be better");
            getName();

            wr.print($"Okay then lets get to work {Name}");
            wr.print("Because we have things to prepare");
            wr.print($"Like you");
            wr.print("You cant just step outside like that");
            wr.print("And of course I, your greatest guide, have a plan");
            wr.print("But it will be better to ask you too");
            wr.print("");
            wr.print("If you want i have bunch of sets waiting for you");
            wr.print("You can choose one of them");
            wr.print("If not, you can build it yourself");
            wr.print("You will be using it after all");
            wr.print("So do you want to [create new] or [use preset]"); 
            create();
            classes.start();
            map.input();
        }
        #endregion

        #region getName
        public void getName()
        {
            wr.print("So could you please share your precious name with me?");
            string q1;
            string q2;
            Name = wr.read();
            if (Name == null ^ Name == "")
            {
                wr.print("Are you afraid of share your name with me?");
                q1 = wr.read();
                if (q1 == "yes" ^ q1 == "Yes" ^ q1 == "y" ^ q1 == "Y")
                {
                    wr.print("Actually i can't blame you");
                    wr.print("It has been only minutes since we met but I did ask this.");
                    wr.print("Its okay if you don't want to but I would be appericiated if you share your name with me");
                    wr.print("");
                    Name = "";
                }
                else if (q1 == "no" ^ q1 == "No" ^ q1 == "n" ^ q1 == "N")
                {
                    wr.print("Okay than you name is?");
                    getName();
                }
                else if (q1 == null ^ q1 == "")
                {
                    wr.print("Okay, if you dont want you dont have to say.");
                    wr.print("I wont force you");
                    wr.print("But i hope we get along well");
                    wr.print("");
                    Name = "";
                }
                else
                {
                    wr.print("I dont get it");
                    getName();
                }
            }
            else
            {
                wr.print("");
                wr.print($"So your name is {Name}, right?");
                q2 = wr.read();
                if (q2 == "yes" ^ q2 == "Yes" ^ q2 == "y" ^ q2 == "Y")
                {
                    return;
                }
                else if (q2 == "no" ^ q2 == "No" ^ q2 == "n" ^ q2 == "N")
                {
                    wr.print("");
                    wr.print("What is your name then");
                    getName();
                }
                else
                {
                    wr.print("I dont get it");
                    getName();
                }
            }
        }
        #endregion

        #region create
        public void create()
        {
            string q1;
            q1 = wr.read();
            if (q1 == null ^ q1 == "")
            {
                wr.print(notAnswer[rng.Next(0, 5)]);
                create();
            }
            else if (q1 == "create new")
            {
                createClass();
            }
            else if (q1 == "use preset")
            {
                wr.n();
                wr.print($"Now I advice you four options {Name}");
                wr.print("Please take a look at them and decide on one");
                printClass();
                chooseClass();
            }
            else
            {
                wr.print("Okay but this is unfortunately not an option.");
                wr.print("You can [create new] or [use preset]");
                create();
            }
        }
        #endregion

        #region aboutClass
        public void printClass()
        {
            Console.WriteLine($"[Hunter] >   Health:100 | Attack:14 | Skill:8  | Defense: 10 | Attack Speed:1.4");
            Console.WriteLine($"[Sorcerer] > Health:90  | Attack:3  | Skill:19 | Defense: 6  | Attack Speed:0.6");
            Console.WriteLine($"[Archer] >   Health:100 | Attack:13 | Skill:13 | Defense: 5  | Attack Speed:1.2");
            Console.WriteLine($"[Warrior] >  Health:140 | Attack:16 | Skill:5  | Defense: 14 | Attack Speed:1.1");
        }
        public void chooseClass()
        {
            string q1;


            q1 = wr.read();
            if (q1 == null ^ q1 == "")
            {
                wr.print(notAnswer[rng.Next(0, 5)]);
                chooseClass();
            }
            else if (q1 == "hunter" ^ q1 == "Hunter")
            {
                Character hunter = new Character(new Hunter(), new Dagger());
            }
            else if (q1 == "sorcerer" ^ q1 == "Sorcerer")
            {
                Character sorcerer = new Character(new Sorcerer(), new MagicWand());
            }
            else if (q1 == "warrior" ^ q1 == "Warrior")
            {
                Character warrior = new Character(new Warrior(), new Sword());
            }
            else if (q1 == "archer" ^ q1 == "Archer")
            {
                Character archer = new Character(new Archer(), new Bow());
            }
            else if (q1 == "dummy" ^ q1 == "Dummy")
            {
                Character dummy = new Character(new Dummy(), new Sword());
            }
            else
            {
                wr.print("Excuse me but i did not get it. Can you please come again?");
                chooseClass();
            }
        }
        #endregion

        #region createClass
        public void createClass()
        {
            bool repeat = true;

            wr.n();
            wr.print($"So you want to create your own character, right {Name}");
            wr.print("Okay then, lets start with something simple");
            wr.print("I will be telling a story and you will be completing it");
            wr.print("Sounds good right?");
            while (repeat)
            {
                yesno.start();
                if (yesnoOut)
                {
                    repeat = false;
                    wr.n();
                    wr.print("Hmm, lets see");
                    wr.print("Oh! This looks good");
                    wr.print("Then lets begin with this");
                    wr.n();
                    tale();
                }
                else if (!yesnoOut) { wr.print("No? I thought you wanted to create your own story"); }
                else
                {
                    wr.print("bug");
                }
            }
        }

        void tale()
        {
            tale1();
            tale2();
            tale3();
            tale4();
            tale5();
            tale6();
            tale7();
            tale8();
        }

        void tale1()
        {
            string q1;

            wr.print($"You were born in {birthplace} as a child of ...");
            wr.print("1 - [Retired Knight]\n2 - [Blacksmith]\n3 - [Gatherer]\n4 - [Farmer]\n5 - [Librarian]");
            wr.n();
            q1 = wr.read();

            if (q1 == "retired knight" ^ q1 == "1") { Ap += 3; Dp -= 1; ASpeed -= 0.1f; Hp -= 10; }
            else if (q1 == "blacksmith" ^ q1 == "2") { Ap += 2; Dp += 2; ASpeed += 0.05f; Sp -= 1; }
            else if (q1 == "gatherer" ^ q1 == "3") { Ap += 1; Sp += 1; ASpeed += 0.15f; Hp -= 10; }
            else if (q1 == "farmer" ^ q1 == "4") { Hp += 20; tale2(); }
            else if (q1 == "librarian" ^ q1 == "5") { Sp += 2; ASpeed -= 0.1f; Ap -= 2; Dp -= 1; }
            else { wr.print("Unfortunately this is not an option"); tale(); }
        }

        void tale2()
        {
            string q1;

            wr.n();
            wr.print("In your childhood, you had a lot of friends");
            wr.print("You were not a quiet child and they were no diffrent");
            wr.print("You all were always doing some fun stuff like ...");
            wr.print("1 - [Climbing Trees]");
            wr.print("2 - [Hide 'n Seek]");
            wr.print("3 - [Watching residents cooking at the square and copying them]");
            wr.print("4 - [Sneakpeeking inside of the areas that we are not allowed]");
            
            q1 = wr.read();

            if (q1 == "1") { Hp -= 10; Sp += 1; ASpeed += 0.05f; }
            else if (q1 == "2") { ASpeed += 0.1f; Hp -= 5; }
            else if (q1 == "3") { Sp += 2; }
            else if (q1 == "4") { ASpeed += 0.1f; Sp += 1; }
            else { wr.print("Unfortunately this is not an option"); tale2(); }

        }

        void tale3()
        {
            string q1;

            wr.n();
            wr.print("Your education life had so ups and downs");
            wr.print("You were never in good terms with the classes");
            wr.print("or were you?");
            
            yesno.start();
            if (yesnoOut) { wr.print("Wow really, you were? Thats a surprise"); Sp += 2; Ap -= 2; }
            else if (!yesnoOut) { wr.print("Yea right. I figured it out"); Sp -= 2; Ap += 2; }
            else { wr.print("bug"); }
        }

        void tale4()
        {
            string q1;

            wr.n();
            wr.print("Okay, i was not talking about it anyway.");

            wr.n();
            wr.print("While in your school years, you did quite a lot of thing");
            wr.print("But you have a regret about ...");
            wr.print("1 - [your love life]");
            wr.print("2 - [your grades]");
            wr.print("3 - [that thing happened to your friends because of you]");

            q1 = wr.read();

            if (q1 == "1") { Sp -= 2; Dp += 2; }
            else if (q1 == "2") { Sp -= 1; Hp += 10; }
            else if (q1 == "3") { ASpeed += 0.1f; Hp -= 10; Ap += 1; regret = true; }
            else { wr.print("Unfortunately this is not an option"); tale4(); }
        }

        void tale5()
        {
            string q1;
            bool repeat = true;

            wr.n();
            wr.print("After the graduation your life was kind of boring");
            wr.print("You got a job and it was nothing but 9 - 5.");
            wr.print("But it was fun for you since you were doing your dream job");
            wr.print("For years you were dreaming of become a ...");
            wr.print("1 - [Warrior]");
            wr.print("2 - [Alchemist]");
            wr.print("3 - [Lecturer]");
            wr.print("4 - [Baker]");
            wr.print("5 - [Gardener]");

            while (repeat)
            {
                q1 = wr.read();

                if (q1 == "1" ^ q1 == "warrior") { repeat = false; Ap += 3; Dp += 2; Hp += 20; }
                else if (q1 == "2" ^ q1 == "alchemist") { repeat = false; Sp += 4; Hp += 10; }
                else if (q1 == "3" ^ q1 == "lecturer") { repeat = false; ASpeed += 0.1f; Hp += 10; Sp += 2; }
                else if (q1 == "4" ^ q1 == "baker") { repeat = false; ASpeed += 0.2f; Ap += 2; Dp += 1; }
                else if (q1 == "5" ^ q1 == "gardener") { repeat = false; ASpeed += 0.1f; Ap += 2; Hp += 30; }
                else { wr.print("Unfortunately this is not an option"); tale5(); }
            }

        }

        void tale6()
        {
            string q1;
            string q2;
            bool repeat = true;
            bool repeat1 = true;

            wr.n();
            wr.print("You were living your life casually until one day");
            wr.print("It was just an ordinary day");
            wr.print("All the shift staff was taking a break and you decided to get some coffee");
            wr.print("Headed up your favourite cafe and get your coffee");
            wr.print("You got a chair and took a look at the newspaper");
            wr.print("Then you heard a voice addressing you");

            wr.n();
            wr.print("It was a casual looking woman");
            wr.print("Said that she knows you from somewhere");
            wr.print("You didn't recongise her but didn't want to down the mood so you got along");
            wr.print("She asked things about you over and over again");

            wr.n();
            wr.print("'You beceme quite handsome, you know. Is this some sort of love effect? Do you have anyone in your life?'");
            
            yesno.start();
            if (yesnoOut) { wr.print("Oh really, good for you."); }
            else if (!yesnoOut) { wr.print("Come on you're lying, what do you mean no?"); }
            else { wr.print("bug"); }

            wr.n();
            wr.print("Yet another question...");
            wr.print("'You were so annoying back in the day you know. It seems like you have changed. What were you doing after you graduated.'");
            wr.print("1 - I got a job right after the graduation and focused on my career");
            wr.print("2 - I didn't do something special");
            wr.print("3 - I got a farm and started growing things");
            wr.print("4 - I was advancing my academic career further.");
            while (repeat1)
            {
                q2 = wr.read();
                if (q2 == "1") { wr.print("You are a dependent guy"); Dp += 4; repeat1 = false; }
                else if (q2 == "2") { wr.print("..."); wr.print("You making it sound like nothing happened."); Hp -= 20; Sp += 1; Ap += 1; repeat1 = false; }
                else if (q2 == "3") { wr.print("Omg its so good. I always wanted to do something like that"); Hp += 20; Ap += 2; repeat1 = false; }
                else if (q2 == "4") { wr.print("Study ugh- stuying... I cant even stand hearing it."); Sp += 3; repeat1 = false; }
                else { wr.print("Stay focused bro this is not an option"); }
            }


            wr.print("After a stressful questioning she left");

            wr.n();
            wr.print("Your break was about to end so you left as well");
            wr.print("But you were still thinking about that woman");
            wr.print("You were thinking about if she is really someone that you know");

            wr.n();
            wr.print("After your shift ended, you spent some more time with your colleagues");
            wr.print("Drinking, talking behind people's backs... It was such a fuss");
            wr.print("Then you heard the same womans voice");
            wr.print("Turned your head back and saw her with someone");
            wr.print("That someone was someone that you know");

            wr.n();
            wr.print("You were struggling remembering who is that guy");
            wr.print("Where do you know him from");
            wr.print("1 - Is he from your school");
            wr.print("2 - Is he your teacher");
            wr.print("3 - Is he from your hood");
            wr.print("4 - Is he from that thing");

            while (repeat)
            {
                q1 = wr.read();

                if (q1 == "1") { repeat = false; ASpeed += 0.1f; Hp -= 10; Dp -= 4; tale61(); }
                else if (q1 == "2") { repeat = false; Sp += 1; Hp -= 5; tale62(); }
                else if (q1 == "3") { repeat = false; Sp += 2; tale63(); }
                else if (q1 == "4")
                {
                    if (regret) { repeat = false; tale614(); }
                    else { repeat = false; tale64(); }
                }
                else { wr.print("Unfortunately this is not an option"); }
            }

        }

        void tale61()
        {
            wr.n();
            wr.print("You wanted to greet him and went to them");
            wr.print("She realised you coming and greeted you first. You greeted her back");
            wr.print($"'Oh my god {Name}, is that you?', he said.");
            wr.print("Seem like he remembered you as well");
            wr.print("You left your colleagues and sat at the table with them");

            wr.print("");
            wr.print("At first there were no problems");
            wr.print("You guys were talking casually");
            wr.print("but the conversation was getting weirder over time");
            wr.print("Atmosphere was a bit tense");
            wr.print("The woman jumped into the conversation and asked if you two were friends back then");
            
            yesno.start();
            if (yesnoOut) { tale611(); Ap += 2; Dp -= 2; }
            else if (!yesnoOut) { tale612(); Dp += 2; Ap -= 2; }
            else { wr.print("bug"); }
        }
        
        void tale611()
        {
            wr.n();
            wr.print("His anger was written all over his face.");
            wr.print("He did not forget what happened after all");
            wr.print("What did you do to him");

            wr.n();
            wr.print("...");
            wr.print("Uuugh");
            wr.print("This suddenly turnet into something dramatic");
            wr.print("Im cutting it from here.");
            //end

        }

        void tale612()
        {
            wr.n();
            wr.print("Guy seemed a bit offended");
            wr.print("but didn't make it out loud");
            wr.print("You guys talked for a little while longer.");
            wr.print("Then you took your leave and headed up to the home");
            //end
        }
        
        void tale62()
        {
            wr.n();
            wr.print("You wanted to greet your teacher and went to them");
            wr.print("She realised you coming and greeted you first. You greeted her back");
            wr.print($"'Oh my god {Name}, is that you?', your teacher said.");
            wr.print("Seem like he remembered you as well");
            wr.print("You left your colleagues and sat at the table with them");

            wr.n();
            wr.print("Some time had passed. You guys talked about stuff like");
            wr.print("How is it going now, How was it back then.. You know, good old days thing");
            wr.print("But it seems like she interested in you a bit too much");

            wr.n();
            wr.print("After some chit chat with them. You left and headed up to home");
            //end

        }

        void tale63()
        {
            wr.n();
            wr.print("You wanted to greet him and went to them");
            wr.print("He realised you and smiled");
            wr.print("He remembered you as well");
            wr.print("You spent such a wonderful time together");
            wr.print("After so many years it was pretty fun");

            wr.n();
            wr.print("Time flied, the conversation felt you so re");
            wr.print("but that woman didn't even say a word, was watching you with a emotionless expression");
            wr.print("You just let it slide so the mood wont be spoiled");
            wr.print("Then you shaked hands with your friend and headed up to home");
            //end
        }
        
        void tale64()
        {
            wr.print("Something happened?");
            yesno.start();
            if (yesnoOut) { wr.print("What is it? Want to tell me?"); tale641(); }
            else if (!yesnoOut) { wr.print("Okay, i will continue then"); }
            else { wr.print("bug"); }
            //end

            void tale641()
            {
                string q1;
                bool repeat = true;

                wr.n();
                wr.print("1 - Okay. I will tel you");
                wr.print("2 - Its nothing important. Lets keep going.");
                //end

                while (repeat)
                {
                    q1 = wr.read();
                    if (q1 == "1") { repeat = false; tale615(); Ap += 1; Sp += 1; }
                    else if (q1 == "2") { repeat = false; wr.print("Okay."); Dp += 1; Hp += 10; }
                    else { wr.print("Come again"); }
                }
            }
        }

        void tale614()
        {
            string q1;
            bool repeat = true;

            wr.n();
            wr.print("This story getting so boring you know");
            wr.print("What is that all about?");
            wr.print("Werent we creating your character?");
            wr.print("And what is 'that thing' anyway?");
            wr.print("Is it related to the thing you said you regret about?");

            wr.n();
            wr.print("Are you hiding something?");
            wr.print("Can you just tell me what exactly have you done?");
            wr.n();
            wr.print("1 - Okay. I will tell you");
            wr.print("2 - I wont tell you");
            wr.print("3 - I- I can't t- tell you");

            while (repeat)
            {
                q1 = wr.read();
                if (q1 == "1") { repeat = false; tale615(); }
                else if (q1 == "2") { wr.print("Then i wont give your thing. Good luck with that"); Dp -= 1; Hp -= 10; ASpeed -= 0.1f; }
                else if (q1 == "3") { wr.print("Not this time bro. Just spit it out."); Ap -= 1; Sp -= 1; ASpeed -= 0.1f; }
                else { wr.print("I want a proper answer"); }
            }
        }
        void tale615()
        {
            string q1;
            bool repeat = true;

            Ap -= 4;
            Dp += 1;

            wr.n();
            wr.print("...");
            wr.print("WHAT!");
            wr.print("What do you mean you stabbed your friend");
            wr.print("and for a girl");
            wr.print("hell no bro, there is no way you did that");
            wr.print("just how stupid are you");

            wr.n();
            wr.print("1 - There is more than that. I just don't want to explain");
            wr.print("2 - I was a child. Of course i regret it.");
            wr.print("3 - Werent we creating a new life? Can't we just change the past?");

            while (repeat)
            {
                q1 = wr.read();
                if (q1 == "1") { repeat = false; wr.print($"I am not believing even a bit but okay. This is none of my business after all. right {Name}?"); ASpeed -= 0.1f; }
                else if (q1 == "2")
                {
                    repeat = false;
                    wr.print("(Sarcastic Laugher) go fuck yourself");
                    wr.print("How can this happen. What tf are we even doing right now.");
                    wr.print("I really want to end this section an forget about everything");
                    wr.print("Lets just do it");
                    Hp -= 10;
                    //end
                }
                else if (q1 == "3") { repeat = false; wr.print("Are you for real? No, kick that guy admin."); Environment.Exit(0); }
                else { wr.print("Talk, NOW!"); }
            }


        }

        void tale7()
        {
            wr.n();
            wr.print("On the way back, you decided to get something to eat");
            wr.print("Found a market and stepped in");
            wr.print("Suddenly the lights turnet off");
            wr.print("You were trying to find somewhere you can support yourself");
            wr.print("and then you felt someone's breath");
            wr.print("That someone held your arms and forced you to lay down");
            wr.print("You were narcotized and collapsed within seconds.");

            wr.n();
            wr.print("...");
            wr.print("...");
            wr.print("...");

            wr.n();
            wr.print("You opened your eyes in somewhere like a basement");
            wr.print("Smell of mose was filling the room");
            wr.print("Someone realised you came to");
            wr.print("Stared you for some time and asked if you know someone called Kaneae");
            wr.print("'Do you know him?'");
            
            yesno.start();
            if (yesnoOut) { tale71(); Ap += 1; Sp += 1; }
            else if (!yesnoOut) { tale72(); Hp -= 20; Dp += 1; }
            else { wr.print("bug"); }
        }

        void tale71()
        {
            wr.n();
            wr.print("'So you know him'");
            wr.print("He punched you in the stomach");
            wr.print("'Would you like to be bothered to tell us where he is?'");
            
            wr.n();
            wr.print("This questioning continued for some time but");
            wr.print("You didn't know where he is or what he is doing");
            wr.print("They realised that there is no use");
            wr.print("They beat you up and dragged you into a forest");
        }

        void tale72()
        {
            wr.n();
            wr.print("He punched you in the stomach");
            wr.print("'Do you think this is a joke'");
            wr.print("'Talk NOW!'");
            
            wr.n();
            wr.print("This questioning continued for some time but");
            wr.print("You didn't know anything about him");
            wr.print("They realised that there is no use");
            wr.print("They treated you 'well' and dragged you into a forest");

        }

        void tale8()
        {
            string q1;
            bool repeat = true;
            ClassName = Name;

            wr.n();
            wr.print("And this was around the time I found you");
            wr.print("With that, your tale ends");
            wr.print("and probably a new one is about to start");
            wr.print("So, any questions?");
            wr.print("1 - Arent we creating a new life, what is this story?");
            wr.print("2 - Wait, so i was beaten up and you found me?");
            wr.print("3 - So this is not a parallel universe or a game and i am literally living?");
            wr.print("4 - So how was it?");

            while (repeat)
            {
                q1 = wr.read();
                if (q1 == "1") { repeat = false; tale81(); }
                else if (q1 == "2") { repeat = false; tale82(); }
                else if (q1 == "3") { repeat = false; tale83(); }
                else if (q1 == "4") { repeat = false; wr.n(); wr.print("Well well, lets see"); classes.compare(); }
                else { wr.print("Sorry, can you please come again?"); }
            }


        }

        void tale81()
        {
            wr.n();
            wr.print($"This is life {Name}");
            wr.print("There are things you cant change");
            wr.print("Im just here to make things better... or maybe easier for you");
            wr.print("Hope you understand");
            
            wr.n();
            wr.print("So Lets see the what we got, shall we?");
            classes.compare();
        }

        void tale82()
        {
            wr.n();
            wr.print("Yes, That is exactly what happened");
            wr.print("You were in the bad shape and i simply...");
            wr.print("gave you another chance");
            wr.print("Not good but... not bad, huh?");

            wr.n();
            wr.print("Okay, so lets take a look at the results");
            classes.compare();
        }

        void tale83()
        {
            wr.n();
            wr.print("Exactly");
            wr.print("This expreience is indeed unique");
            wr.print("And this is the reason");
            wr.print("This is reality");

            wr.n();
            wr.print("Okay then, those are the results");
            classes.compare();
        }
        #endregion
    }
}
