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
    abstract class AbstracTFactory
    {
        protected IChocolate chocolate;
        protected IKitKat kitkat;
        protected ISweet sweet;

        public abstract IChocolate CreateChocolate();

        public abstract IKitKat CreateKitKat();

        public abstract ISweet CreateSweet();
    }
}
