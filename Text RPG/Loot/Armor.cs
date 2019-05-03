using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    class Armor : Loot
    {

        public Armor(string name, int plusHp) 
            : base(name, plusHp)
        {
            Name = name;
            PlusHp = plusHp;
        }

        public string Name { get; }
        public int PlusHp { get; }
    }
}
