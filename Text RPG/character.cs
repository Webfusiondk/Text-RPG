using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    class Character
    {
        string name;
        int hp;
        int attack;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
            }
        }
        public int Attack
        {
            get
            {
                return attack;
            }
            set
            {
                attack = value;
            }
        }
        public Character(string name, int hp, int attack)
        {
            Name = name;
            Hp = hp;
            Attack = attack;
        }

        public string Dead()
        {
            if (hp <= 0)
            {
                return "Better luck next time!";
            }
            return null;
        }

        public string PrintStats()
        {
            return
            "Name: " + Name + "\n" +
            "Hp: " + Hp + "\n" +
            "Attack: " + Attack;
        }

        public void NormalAttack(Character target)
        {
            target.hp -= attack;
        }
    }
}
