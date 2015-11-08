﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Chocolate
{
    class ChocolateB : IChocolate
    {
        int quality = 100;

        public int GetQuality()
        {
            return quality;
        }
    }
}
