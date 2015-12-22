using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class Axe : iWeapon
    {
        public void Use()
        {
            Console.WriteLine("Using Axe");
        }
    }
}
