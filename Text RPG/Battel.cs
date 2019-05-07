using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    //All battels of the game
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
            Console.WriteLine("Your enemys stats are \n");
            Console.ReadKey(true);
            DemonHunt(Program.war, Program.Demon1);
        }

        public static void BigRat(Warrior warrior, BigRat bigRat)
        {
            Program.currenttarget = bigRat;
            while (bigRat.Hp > 0 && warrior.Hp > 0)
            {
                PrintPlayerStats(bigRat, warrior);

                Program.WarriorMenu();
                if (bigRat.Hp > 0)
                {
                    Console.WriteLine(bigRat.BigRatTurn(bigRat.EnemyChoice(), warrior));
                    warrior.Dead();
                }
            }
            warrior.Hp = 120;
            Console.WriteLine("{0} was killed!", bigRat.Name);
            Console.Clear();
        }

        public static void RatKing(Warrior warrior, RatKing ratking)
        {
            Program.currenttarget = ratking;
            while (ratking.Hp > 0 && warrior.Hp > 0)
            {
                PrintPlayerStats(ratking, warrior);

                Program.WarriorMenu();
                if (ratking.Hp > 0)
                {
                    Console.WriteLine(ratking.RatKingTurn(ratking.EnemyChoice(), warrior));
                    warrior.Dead();
                }
            }
            warrior.Hp = 120;
            Console.WriteLine("{0} was killed!", ratking.Name);
            Console.Clear();
        }

        public static void RatHunt(Warrior warrior, Rat rat)
        {
            Program.currenttarget = rat;
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
            warrior.Hp = 110;
            Console.WriteLine("{0} was killed!", rat.Name);
            Console.Clear();
        }

        public static void DemonHunt(Warrior warrior, Demon demon)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Demon kills: " + i);
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

        public static void TownCharge(Bandit bandit, TownGuard townGuard)
        {
                while (townGuard.Hp > 0 && bandit.Hp > 0)
                {
                    PrintPlayerStats(townGuard, bandit);

                    Program.WarriorMenu();
                    if (townGuard.Hp > 0)
                    {
                        Console.WriteLine(townGuard.TownGuardTurn(townGuard.EnemyChoice(), bandit));
                        bandit.Dead();
                    }
                }
        }

        public static void CastelSige(Bandit bandit, CastelGuard castelGuard)
        {
            for (int i = 0; i < 2; i++)
            {
                while (castelGuard.Hp > 0 && bandit.Hp > 0)
                {
                    PrintPlayerStats(castelGuard, bandit);

                    Program.WarriorMenu();
                    if (castelGuard.Hp > 0)
                    {
                        Console.WriteLine(castelGuard.CastelGuardTurn(castelGuard.EnemyChoice(), bandit));
                        bandit.Dead();
                    }
                }
                castelGuard.Hp = 150;
                bandit.Hp = 70;
                Console.Clear();
            }

        }
        public static void BanditvsBigRat(Bandit bandit, BigRat bigRat)
        {
            while (bigRat.Hp > 0 && bandit.Hp > 0)
            {
                PrintPlayerStats(bigRat, bandit);

                Program.WarriorMenu();
                if (bigRat.Hp > 0)
                {
                    Console.WriteLine(bigRat.BigRatTurn(bigRat.EnemyChoice(), bandit));
                    bandit.Dead();
                }
            }
        }

    }
}
