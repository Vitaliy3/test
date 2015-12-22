using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class Stone : iWeapon
    {
        public void Use()
        {
            Console.WriteLine("Using Stone");
        }
    }
}
