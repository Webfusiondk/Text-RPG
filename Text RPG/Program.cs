using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{

    //Main
    class Program
    {
        public static CastelGuard CG;
        public static TownGuard TG;
        public static Bandit ban;
        public static BigRat BigRat;
        public static Warrior war;
        public static RatKing RatKing;
        public static Demon Demon1;
        public static Rat Rat;
        public static List<Armor> armor_list;
        public static Character currenttarget;
        public static string name;
        static void Main(string[] args)
        {
            armor_list = new List<Armor>();
            Story story = new Story();
            CG = new CastelGuard("Castel Guard", 15, 150, 50);
            TG = new TownGuard("Gate Guard", 10, 200, 50);
            BigRat = new BigRat("Big Beefy Rat", 5, 70, 25);
            Rat = new Rat("Rat", 3, 50, 10);
            RatKing = new RatKing("RatKing", 10, 180, 15);
            Demon1 = new Demon("Demon", 1, 100, 30);
            currenttarget = Demon1;
            CreateAdventure();
            story.StoryStart();
            Console.Clear();
            story.StoryAct1();
            Console.ReadKey();
        }
        //Create Main char
        public static string CreateAdventure()
        {
            Console.WriteLine("Enter the name of your Adventure");
            Console.Write("Name: ");
            name = Console.ReadLine();
            return name;

        }
        //change to warrior
        public Warrior PlayWar()
        {
            int hp = 100;
            int attack = 10;
            int playerlevel = 1;
            return new Warrior(CreateAdventure(), playerlevel, hp, attack);
        }
        //change to bandit
        public Bandit PlayBan()
        {
            int hp = 70;
            int attack = 15;
            int playerlevel = 1;
            return new Bandit(CreateAdventure(), playerlevel, hp, attack);
        }

        //Make armor to armor list
        public void CreateArmor(string name, int plusHp)
        {
            Armor armor = new Armor(name, plusHp);
            armor_list.Add(armor);
        }
        //Checks all armor in the game
        public static void CheckAllArmor(List<Armor> armorlist)
        {
            Console.WriteLine("All Armor in the game");
            for (int i = 0; i < armor_list.Count; i++)
            {
                Console.WriteLine("Name:{0} {1}\n+Hp:", armor_list[i].Name, armor_list[i].PlusHp);
            }
        }
        //Armor stats
        public void CheckArmorStats(Armor armor)
        {
            Console.Write("\nName: {0}\nHp: {1}", armor.Name, armor.PlusHp);
        }
        //Warrior attack menu
        public static void WarriorMenu()
        {
            string userchoice;
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Attack");
            userchoice = Console.ReadLine();
            switch (userchoice)
            {
                case "1":
                    WarriorAttackChoice();
                    break;
                default:
                    Console.WriteLine("Pick! 1 or 2!");
                    WarriorMenu();
                    break;
            }
            Console.Clear();
        }
        //Warrior attack menu
        public static void WarriorAttackChoice()
        {
            string userchoice;
            Console.WriteLine("Choose Special:");
            Console.WriteLine("1. Normalattack");
            Console.WriteLine("2. ShieldSlam!");
            Console.WriteLine("3. Double Slash");
            Console.WriteLine("4. <--- Go back");
            userchoice = Console.ReadLine();
            switch (userchoice)
            {
                case "1":
                    war.NormalAttack(currenttarget);
                    break;
                case "2":
                    war.ShieldSlam(currenttarget);
                    break;
                case "3":
                    war.DoubleSlash(currenttarget);
                    break;
                default:
                    WarriorMenu();
                    break;
            }
        }

        public static void BanditMenu()
        {
            string userchoice;
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Attack");
            userchoice = Console.ReadLine();
            switch (userchoice)
            {
                case "1":
                    BanditAttackChoice();
                    break;
                default:
                    Console.WriteLine("Pick! 1 or 2!");
                    BanditMenu();
                    break;
            }
            Console.Clear();
        }

        public static void BanditAttackChoice()
        {
            string userchoice;
            Console.WriteLine("Choose Special:");
            Console.WriteLine("1. Backstab");
            Console.WriteLine("2. Slice and Slice");
            Console.WriteLine("3. Kick");
            Console.WriteLine("4. <--- Go back");
            userchoice = Console.ReadLine();
            switch (userchoice)
            {
                case "1":
                    ban.BackStab(currenttarget);
                    break;
                case "2":
                    ban.SliceAndSlice(currenttarget);
                    break;
                case "3":
                    ban.Kick(currenttarget);
                    break;
                default:
                    BanditMenu();
                    break;
            }
        }
    }


}
