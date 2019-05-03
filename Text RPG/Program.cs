using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    class Program
    {

        public static BigRat BigRat;
        public static Warrior war;
        public static Demon Demon1;
        public static Rat Rat;
        public static List<Armor> armor_list;
        static Character currenttarget;
        static void Main(string[] args)
        {
            armor_list = new List<Armor>();
            Story story = new Story();
            BigRat = new BigRat("Big Beefy Rat", 70, 25);
            Rat = new Rat("Rat", 50, 10);
            Demon1 = new Demon("Demon", 100, 30);
            currenttarget = Demon1;
            war = Create();
            story.StoryStart();
            Console.Clear();
            story.StoryAct1();
            Console.ReadKey();

        }


        static Warrior Create()
        {
            string name;
            int hp = 100;
            int attack = 10;

            Console.WriteLine("Enter the name of your Warrior");
            Console.Write("Name: ");
            name = Console.ReadLine();
            return new Warrior(name, hp, attack);
        }

        public void CreateArmor(string name, int plusHp)
        {
            Armor armor = new Armor(name, plusHp);
            armor_list.Add(armor);
        }

        public static void CheckAllArmor(List<Armor> armorlist)
        {
            Console.WriteLine("All Armor in the game");
            for (int i = 0; i < armor_list.Count; i++)
            {
                Console.WriteLine("Name:{0} {1}\n+Hp:", armor_list[i].Name, armor_list[i].PlusHp);
            }
        }

        public void CheckArmorStats(Armor armor)
        {
            Console.Write("\nName: {0}\nHp: {1}", armor.Name, armor.PlusHp);
        }

        //Method to add armor and weapon to iventory
        //warrior.armor = armor in inventory
        //warrior.weapon = weapon in inventory

        //public static void CompareArmorStats(Armor other_armor, Armor your_armor)
        //{
        //    if (your_armor == Warrior.equipped_armor)
        //    {
        //        Console.Write("Name: {0} | Equipped Weapon Name: {1}\nHp: {2} | Equipped Armor Hp: {3}"
        //            , other_armor.Name, your_armor.Name, other_armor.PlusHp, your_armor.PlusHp);
        //    }
        //    else
        //    {
        //        Console.Write("Other Weapon Name: {0} | Your Weapon Name: {1}\nOther Armor Hp: {2} | Your Armor Hp: {3}} "
        //            , other_armor.Name, your_armor.Name, other_armor.PlusHp, your_armor.PlusHp);
        //    }
        //}

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

    }


}
