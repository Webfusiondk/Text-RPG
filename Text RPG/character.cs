using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    class Character
    {
        int playerlevel;
        string name;
        int hp;
        int attack;
        public int Playerlevel
        {
            get
            {
                return playerlevel;
            }
            set
            {
                playerlevel = value;
            }
        }
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
        public Character(string name, int playerlevel, int hp, int attack)
        {
            Playerlevel = playerlevel;
            Name = name;
            Hp = hp;
            Attack = attack;
        }

        public string Dead()
        {
            string dead = null;
            if (hp <= 0)
            {
                dead = "Better luck next time!";
                System.Windows.Forms.Application.Restart();
            }
            return dead;
        }

        public string PrintStats()
        {
            return
            "Name: " + Name + "\n" +
            "Level: " + Playerlevel + "\n" +
            "Hp: " + Hp + "\n" +
            "Attack: " + Attack + "\n";
        }
        public void LevelUp()
        {
            Console.WriteLine("Level Up!" + "\n" + "Attack +5" + "\n" + "Hp +10");

            attack += 5;
            hp += 10;
            playerlevel += 1;
        }

        public void NormalAttack(Character target)
        {
            target.hp -= attack;
        }
    }
}
