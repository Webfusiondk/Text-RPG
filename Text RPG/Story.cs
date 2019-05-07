using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    class Story
    {
        //The hole story of the game
        string userchoice;
        Program pro = new Program();
        public void StoryStart()
        {
            Console.WriteLine("Welcome to Text RPG");
            Console.ReadKey(true);
            Console.WriteLine("Adventure i hope you are ready!");
            Console.ReadKey(true);
            Console.WriteLine("You will encounter dangerous enemies and bosses!");
            Console.ReadKey(true);
            Console.WriteLine("The game will be an adventure packed with excitement");
            Console.WriteLine("The adventure will be based on your choices threw out or journey!");
            Console.WriteLine("Good luck Warrior on your adventure");
            Console.ReadKey(true);
        }

        public void StoryAct1()
        {
            Console.WriteLine("Adventure your first mission is to slaying 10 demons");
            Console.WriteLine("Would you like to accept this quest?");
            userchoice = Console.ReadLine().ToLower();
            switch (userchoice)
            {
                case "yes":
                    Console.Clear();
                    pro.PlayWar();
                    StoryAct1Yes();
                break;
                case "no":
                    Console.Clear();
                    pro.PlayBan();
                    StoryAct1No();
                break;
                default:
                    Console.WriteLine("Pleas Type yes or no!");
                    StoryAct1();
                    break;
            }
            Console.Clear();
        }

        public void StoryAct1Yes()
        {
            Console.WriteLine("Brilliant! i will reward you with an impressive item!");
            Console.WriteLine("But remeber if you die under combat you will have to start over...");
            Battel.DemonQuest();
            Program.war.LevelUp();
            StoryAct2Yes();
        }

        public void StoryAct2Yes()
        {
            Console.WriteLine("Thank you so much for your help!");
            Console.WriteLine("I heard that the king got traped in the Sewers!");
            Console.WriteLine("It was somthing aboute giant rats came and took him!");
            Console.WriteLine("Pleas hurry down to the Sewers!");
            Console.WriteLine("Would you like to accept the quest to save the king?");
            userchoice = Console.ReadLine().ToLower();
            switch (userchoice)
            {
                case "yes":
                    Console.Clear();
                    StorySewers();
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Type yes or no");
                    StoryAct2Yes();
                    break;
            }
        }

        public void StorySewers()
        {
            Console.WriteLine("You have to enter the sewer here!");
            Console.WriteLine("But becarefull there are probly enemys down there!");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("'Enter the sewer'\n");
            Battel.RatHunt(Program.war, Program.Rat);
            Console.WriteLine("thinking to my self... There are so meney gad dam rats down here!");
            Console.WriteLine("Sould i just keep walking? How far is it!");
            Console.Clear();
            Battel.RatHunt(Program.war, Program.Rat);
            Program.war.LevelUp();
            Console.WriteLine("What is that sound???");
            Console.WriteLine("Bum Bum Bum!");
            Battel.BigRat(Program.war, Program.BigRat);
            Console.WriteLine("Phyyy that was a big rat!");
            Console.WriteLine("I swear to god that im gonna rip the head off that king when i find him...");
            Console.WriteLine("Reeeeee");
            Console.WriteLine("What was that!!");
            Battel.RatKing(Program.war, Program.RatKing);
            Program.war.LevelUp();
            Program.war.LevelUp();
            Program.war.LevelUp();
        }

        public void StoryAct1No()
        {
            Console.WriteLine("How could you! You are a traitor.. Your Warrior rank will be taken from you!");
            Console.WriteLine("You are now forskaen to the bandits, never come back here!");
            Console.WriteLine("(Thinking: sould i kill him?)");
            userchoice = Console.ReadLine().ToLower();
            switch (userchoice)
            {
                case "yes":
                    Console.Clear();
                    BanditStoryAct1Yes();
                    break;
                case "no":
                    Console.Clear();
                    BanditStoryAct1No();
                    break;
                default:
                    Console.WriteLine("Pleas Type yes or no!");
                    StoryAct1No();
                    break;
            }
        }


        public void BanditStoryAct1Yes()
        {
            string userchoice;
            Console.WriteLine("Assanation!");
            Console.WriteLine("I think i can use this new dagger i got from him!");
            Console.WriteLine(" +5 Attack!");
            Console.ReadKey(true);
            Program.ban.Attack += 5;
            Console.WriteLine("(Start walking towards the town)");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("Guard at the town gate: You are not welcome here!");
            Console.WriteLine("Guard: Turn around or get punished!");
            Console.WriteLine("(Sould i walk strigt in or find a diffrent path into the town)");
            Console.WriteLine("Yes for strigt and no for diffrent path");
            userchoice = Console.ReadLine().ToLower();
            switch (userchoice)
            {
                case "yes":
                    Console.Clear();
                    BanditStoryAct2Yes();
                    break;
                case "no":
                    Console.Clear();
                    BanditStoryAct2No();
                    break;
                default:
                    break;
            }
        }

        public void BanditStoryAct2Yes()
        {
            Console.WriteLine("Allright lets do this!");
            Console.WriteLine("Charge!");
            Battel.TownCharge(Program.ban, Program.TG);
            Console.WriteLine("Amazing that i just killed that guard!");
        }

        public void BanditStoryAct2No()
        {
            Console.WriteLine("I heard that there was a hole in the wall on the west site of the town");
            Console.WriteLine("(Walking towards the hole)");
            Console.ReadKey(true);
            Console.WriteLine("There it is!");
            Console.WriteLine("Im gonna try getting threw it!\n");
            Console.WriteLine("Allright i got to hold low profile now..");
            Console.WriteLine("Start walking towards the castel..");
            Console.WriteLine("There are 2 guards garding the main entry..");
            Console.WriteLine("I can probly get in threw the sewer");
            Console.WriteLine("Type 1 for fighting threw the guards.\n Type 2 for sewer");
            userchoice = Console.ReadLine();
            switch (userchoice)
            {
                case "1":
                    Console.Clear();
                    Battel.CastelSige(Program.ban, Program.CG);
                    break;
                case "2":
                    Console.Clear();
                    BanditSewer();
                    break;
                default:
                    break;
            }
        }

        public void BanditSewer()
        {
            Console.WriteLine("That is that smell!");
            Console.WriteLine("It smells like somthing died down here and got back to life and died agien!");
            Console.WriteLine("(Starts walking...)");
            Console.WriteLine("(I can hear them talk above me)");
            Console.WriteLine("What is that! Its so big and furry!");
            Battel.BanditvsBigRat(Program.ban, Program.BigRat);
            Program.ban.LevelUp();
            Program.ban.LevelUp();
            Program.ban.LevelUp();
            Console.WriteLine("What the fuck was that!");
            Console.WriteLine("Why is there some kind of mutated rat down here!");
        }
        public void BanditStoryAct1No()
        {

        }

    }
}
