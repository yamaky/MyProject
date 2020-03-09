using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Hero
    {
        public int health;
        public int heart;
        public int i, y;
        public int spead;

        public Hero()
        {
            health = 100;
            heart = 3;
        }

        public virtual void Run(int i, int y, int spead)
        {

        }
    }
}
