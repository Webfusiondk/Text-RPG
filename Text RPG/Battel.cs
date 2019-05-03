using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    class Battel
    {
        private static int critChance = 16; // 1 in 16 attacks crit


        public static bool IsCrit()
        {
            Random rnd = new Random();
            int crit = rnd.Next(1, critChance);

            if (crit == 1)
            {
                return true;
            }
            return false;
        }

        public bool IsPlayerDead(Warrior warrior)
        {
            if (warrior.Hp == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsEnemyDead(Enemy enemy)
        {
            if (enemy.Hp == 0)
            {
                return true;
            }
            return false;
        }

        public static void PrintPlayerStats(Character character1, Character character2)
        {
            Console.WriteLine(character1.PrintStats());
            Console.WriteLine(character2.PrintStats());
        }

        public static void DemonQuest()
        {
            Console.Clear();
            Console.WriteLine("You will have to slay 10 demons..");
            Console.WriteLine("After evey fight you will get full hp.. But if you die you lose");
            Console.WriteLine("Your enemys stats are \n" + Program.Demon1.PrintStats());
            Console.ReadKey(true);
            DemonHunt(Program.war, Program.Demon1);
        }

        public static void BigRat(Warrior warrior, BigRat bigRat)
        {
            while (bigRat.Hp > 0 && warrior.Hp > 0)
            {
                PrintPlayerStats(bigRat, warrior);

                Program.WarriorMenu();
                if (bigRat.Hp > 0)
                {
                    Console.WriteLine(bigRat.RatTurn(bigRat.EnemyChoice(), warrior));
                    warrior.Dead();
                }
            }
            warrior.Hp = 100;
            Console.WriteLine("{0} was killed!", bigRat.Name);
            Console.Clear();
        }

        public static void RatHunt(Warrior warrior, Rat rat)
        {
            while (rat.Hp > 0 && warrior.Hp > 0)
            {
                PrintPlayerStats(rat, warrior);

                Program.WarriorMenu();
                if (rat.Hp > 0)
                {
                    Console.WriteLine(rat.RatTurn(rat.EnemyChoice(), warrior));
                    warrior.Dead();
                }
            }
            rat.Hp = 50;
            warrior.Hp = 100;
            Console.WriteLine("{0} was killed!", rat.Name);
            Console.Clear();
        }

        public static void DemonHunt(Warrior warrior, Demon demon)
        {
            for (int i = 0; i < 10; i++)
            {
                while (demon.Hp > 0 && warrior.Hp > 0)
                {
                    PrintPlayerStats(demon, warrior);

                    Program.WarriorMenu();
                    if (demon.Hp > 0)
                    {
                        Console.WriteLine(demon.DemonTurn(demon.EnemyChoice(), warrior));
                        warrior.Dead();
                    }
                }
                    demon.Hp = 100;
                    warrior.Hp = 100;
                    Console.WriteLine("{0} was killed!", demon.Name);
                    Console.Clear();

            }
        }
    }
}
