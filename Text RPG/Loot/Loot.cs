using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    class Loot
    {
        private string name;
        private int plusHp;
        private string Name
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
        private int PlusHp
        {
            get
            {
                return plusHp;
            }
            set
            {
                plusHp = value;
            }
        }
        public Loot(string name, int plusHp)
        {
            Name = name;
            PlusHp = plusHp;
        }

    }
}
