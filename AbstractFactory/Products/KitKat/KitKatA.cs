using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.KitKat
{
    class KitKatA: IKitKat
    {
        int taste = 50;

        public int GetTaste()
        {
            return taste;
        }
    }
}
