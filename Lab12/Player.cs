using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    abstract class Player
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Roshambo pick;

        public Roshambo Pick
        {
            get { return pick; }
            set { pick = value; }
        }

        public Player(string name)
        {
            this.name = name;
        }

        public abstract Roshambo GenerateRoshambo();

        public override string ToString()
        {
            return $"{name}: {pick}\n";
        }
    }
}
