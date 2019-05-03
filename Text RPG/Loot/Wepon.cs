using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    class Wepon : Loot
    {
        public static List<Wepon> wepon_list = new List<Wepon>();
        public Wepon(string name, int plusHp)
            : base(name, plusHp)
        {
        }
    }
}
