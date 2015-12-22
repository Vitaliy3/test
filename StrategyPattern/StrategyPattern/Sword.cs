using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class Sword : iWeapon
    {
        public void Use()
        {
            Console.WriteLine("Using Sword");
        }
    }
}
