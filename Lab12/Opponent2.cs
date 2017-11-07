using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Opponent2 : Player
    {
        public Opponent2(string name)
            : base(name) { }

        Random rand = new Random();

        public override Roshambo GenerateRoshambo()
        {
            int index = rand.Next(3);
            Roshambo pick = (Roshambo)index;
            return pick;
        }
    }
}
