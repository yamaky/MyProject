﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Enemy : Alive
    {
        public Enemy()
        {
            health = 100;
            heart = 1;
        }

        public override void Run()
        {

        }
    }
}
