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
    class FactoryA : AbstracTFactory
    {
        public FactoryA()
        {
            chocolate = new ChocolateA();
            kitkat = new KitKatA();
            sweet = new SweetA();
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
