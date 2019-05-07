using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    //Warrior char
    class Warrior : Character
    {
        public int numOfAttack;
        private Armor armor;
        private Wepon wepon;

        public Armor Armor
        {
            get { return armor; }
            set { armor = value; }
        }


        public Wepon Wepon
        {
            get { return wepon; }
            set { wepon = value; }
        }


        public Warrior(string name, int playerlevel, int hp, int attack)
            :base(name,playerlevel,hp,attack)
        {
            Name = name;
            Hp = hp;
            Attack = attack;
        }

        public void ShieldSlam(Character target)
        {
            target.Hp -= Attack + 30;
        }
        public void DoubleSlash(Character target)
        {
            target.Hp -= Attack + 20;
            target.Hp -= Attack + 20;
        }
    }

    //bandit Char
    class Bandit : Character
    {
        public Bandit(string name, int playerlevel, int hp, int attack) 
            : base(name, playerlevel, hp, attack)
        {

        }
        public void BackStab(Character target)
        {
            target.Hp -= Attack + 40;
        }
        public void SliceAndSlice(Character target)
        {
            target.Hp -= Attack + 10;
            target.Hp -= Attack + 10;
            target.Hp -= Attack + 10;
        }
        public void Kick(Character target)
        {
            target.Hp -= Attack + 30;
        }
    }
}
