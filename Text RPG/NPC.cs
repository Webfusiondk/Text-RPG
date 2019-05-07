using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    class NPC : Character
    {

        //All NPCs like shopkeeper
        public NPC(string name, int playerlevel, int hp, int attack) 
            : base(name, playerlevel, hp, attack)
        {

        }
    }
}
