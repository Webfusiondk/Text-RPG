using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    //All Enemys and there attacks
    class Enemy : Character
    {
        public int numOfAttack;

        public Enemy(string name, int playerlevel, int hp, int attack)
            : base(name, playerlevel, hp, attack)
        {
        }

        public int EnemyChoice()
        {
            int eChoice;
            Random ran = new Random();
            eChoice = ran.Next(1, numOfAttack + 1);
            return eChoice;
        }
    }

    class Demon : Enemy, ILoot
    {

        public Demon(string name, int playerlevel, int hp, int attack)
            : base(name, playerlevel, hp, attack)
        {
            numOfAttack = 2;
        }
        public void Shadowball(Character target)
        {
            target.Hp -= Attack + 20;
        }

        public string DemonTurn(int choice, Character target)
        {
            if (choice == 1)
            {
                NormalAttack(target);
                return "Demon hit you!";
            }
            else if (choice == 2)
            {
                Shadowball(target);
                return "Demon hit you with shadowball!";
            }
            return null;
        }

        public string DropLoot()
        {
            throw new NotImplementedException();
        }
    }


    class BigRat : Enemy
    {
        public BigRat(string name, int playerlevel, int hp, int attack) 
            : base(name, playerlevel, hp, attack)
        {
            numOfAttack = 2;
        }
        public string Charge(Character target)
        {
            target.Hp -= 30;
            return "Rush!";
        }
        public string Bash(Character target)
        {
            target.Hp -= 40;
            return "Bonk!";
        }

        public string BigRatTurn(int choice, Character target)
        {
            if (choice == 1)
            {
                Charge(target);
                return "Rush!";
            }
            else if (choice == 2)
            {
                Bash(target);
                return "Big rat hit you hard!";
            }
            return null;
        }
    }

    class Rat : Enemy
    {
        public Rat(string name, int playerlevel, int hp, int attack) 
            : base(name, playerlevel, hp, attack)
        {
            numOfAttack = 3;

        }
        public string Bite(Character target)
        {
            target.Hp -= 50;
            return "Hak!";
        }
        public string Scratch(Character target)
        {
            target.Hp -= 20;
            target.Hp -= 10;
            target.Hp -= 5;
            return "Scratch Scratch Scratch";
        }

        public string RatTurn(int choice, Character target)
        {
            if (choice == 1)
            {
                NormalAttack(target);
                return "Rat hit you";
            }
            else if (choice == 2)
            {
                Bite(target);
                return "Rat bit you!";
            }
            else if (choice == 3)
            {
                Scratch(target);
                return "Rat Scratch you!";
            }
            return null;
        }
    }

    class RatKing : Enemy
    {
        public RatKing(string name, int playerlevel, int hp, int attack)
            : base(name, playerlevel, hp, attack)
        {
            numOfAttack = 4;
        }
        public string Screem(Character target)
        {
            target.Hp -= Attack + 40;
            return "Reeee";
        }

        public string Bite(Character target)
        {
            target.Hp -= Attack + 25;
            return "You will taste good!";
        }

        public string RatMedic(RatKing target)
        {
            target.Hp += Hp + 20;
            return "+ 20HP";
        }

        public string RatArmy(Character target)
        {
            target.Hp -= Attack - 20;
            return "RatArmy ATTACK!";
        }

        public string RatKingTurn(int choice, Character target)
        {
            if (choice == 1)
            {
                Screem(target);
                return "Reeee";
            }
            else if (choice == 2)
            {
                Bite(target);
                return "You will taste good!";
            }
            else if (choice == 3)
            {
                RatMedic(Program.RatKing);
                return "+ 20HP to RatKing";
            }
            else if (choice == 4)
            {
                RatArmy(target);
                return "RatArmy ATTACK!";
            }
            return null;
        }
    }
    class TownGuard : Enemy
    {
        public TownGuard(string name, int playerlevel, int hp, int attack) 
            : base(name, playerlevel, hp, attack)
        {
            numOfAttack = 1;
        }

        public string TownGuardTurn(int choice, Character target)
        {
            if (choice == 1)
            {
                NormalAttack(target);
                return "Slash!";
            }
            return null;
        }
    }
    class CastelGuard : Enemy
    {
        public CastelGuard(string name, int playerlevel, int hp, int attack)
            : base(name, playerlevel, hp, attack)
        {
            numOfAttack = 1;
        }

        public string CastelGuardTurn(int choice, Character target)
        {
            if (choice == 1)
            {
                NormalAttack(target);
                return "Slash!";
            }
            return null;
        }
    }
}
