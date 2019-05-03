using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    class Story
    {
        public void StoryStart()
        {
            Console.WriteLine("Welcome to Text RPG");
            Console.ReadKey(true);
            Console.WriteLine(Program.war.Name + " i hope you are ready!");
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
            string userchoice;
            Console.WriteLine(Program.war.Name + " your first mission is to slaying 10 demons");
            Console.WriteLine("Would you like to accept this quest?");
            userchoice = Console.ReadLine().ToLower();
            switch (userchoice)
            {
                case "yes":
                    StoryAct1Yes();
                break;
                case "no":
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
            string userchoice;
            Console.WriteLine("Thank you so much for your help!");
            Console.WriteLine("I heard that the king got traped in the Sewers!");
            Console.WriteLine("It was somthing aboute giant rats came and took him!");
            Console.WriteLine("Pleas hurry down to the Sewers!");
            Console.WriteLine("Would you like to accept the quest to save the king?");
            userchoice = Console.ReadLine().ToLower();
            switch (userchoice)
            {
                case "yes":
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
            string userchoice;
            Console.WriteLine("How could you! You are a traitor.. Your Warrior rank will be taken from you!");
            Console.WriteLine("You are now forskaen to the bandits, never come back here!");
            Console.WriteLine("(Thinking: sould i kill him?)");
            userchoice = Console.ReadLine().ToLower();
            switch (userchoice)
            {
                case "yes":
                    BanditStoryAct1Yes();
                    break;
                case "no":
                    BanditStoryAct1No();
                    break;
                default:
                    Console.WriteLine("Pleas Type yes or no!");
                    StoryAct1No();
                    break;
            }
            Console.Clear();
        }


        public void BanditStoryAct1Yes()
        {

        }
        public void BanditStoryAct1No()
        {

        }
    }
}
