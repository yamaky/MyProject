using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Enemy : Hero
    {
        public Enemy()
        {
            health = 100;
            heart = 1;
        }

        public override void Run(int i, int y, int spead)
        {

        }
    }
}
