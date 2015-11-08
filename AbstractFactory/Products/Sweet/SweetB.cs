using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Sweet
{
    class SweetB : ISweet
    {
        int price = 60;

        public int GetPrice()
        {
            return price;
        }
    }
}
