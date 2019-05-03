using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    class Consumables : Loot
    {
        public Consumables(string name, int plusHp) 
            : base(name, plusHp)
        {
        }
    }
}
