using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Products.Chocolate;
using AbstractFactory.Products.KitKat;
using AbstractFactory.Products.Sweet;

namespace AbstractFactory.Factories
{
    class FactoryB : AbstracTFactory
    {
        public FactoryB()
        {
            chocolate = new ChocolateB();
            kitkat = new KitKatB();
            sweet = new SweetB();
        }

        public override IChocolate CreateChocolate()
        {
            return chocolate;
        }

        public override IKitKat CreateKitKat()
        {
            return kitkat;
        }

        public override ISweet CreateSweet()
        {
            return sweet;
        }
    }
}
