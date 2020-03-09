using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Hero : Alive
    {
        public int heart { get; private set; }

        public Hero()
        {
            health = 100;
            heart = 3;
        }

        public override void Run()
        {

        }
    }
}
