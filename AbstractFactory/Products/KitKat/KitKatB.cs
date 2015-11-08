using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.KitKat
{
    class KitKatB : IKitKat
    {
        int taste = 25;

        public int GetTaste()
        {
            return taste;
        }
    }
}
