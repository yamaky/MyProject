using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Gun : Weapon
    {
        public int shells;

        public Gun()
        {
            damage = 30;
            hit = 60;
        }

        public override void Attack()
        {

        }
    }
}
