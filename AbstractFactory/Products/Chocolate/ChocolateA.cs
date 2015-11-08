using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Chocolate
{
    class ChocolateA: IChocolate
    {
        int quality = 250;

        public int GetQuality()
        {
            return quality;
        }
    }
}
