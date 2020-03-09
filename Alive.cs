using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Alive
    {
        public int health { get; protected set; }
        //public int heart { get; private set; }
        public int spead { get; private set; }

        public Alive()
        {
            health = 100;
        }

        public virtual void Run()
        {

        }
    }
}
