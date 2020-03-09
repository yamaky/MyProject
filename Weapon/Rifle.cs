using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Rifle : Weapon
    {
        public int shells;

        public Rifle()
        {
            damage = 50;
            hit = 50;
        }

        public override void Attack()
        {

        }
    }
}
