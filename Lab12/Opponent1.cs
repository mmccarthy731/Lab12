using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Opponent1 : Player
    {
        public Opponent1(string name)
            : base(name) { }

        public override Roshambo GenerateRoshambo()
        {
            return (Roshambo)0;
        }
    }
}
