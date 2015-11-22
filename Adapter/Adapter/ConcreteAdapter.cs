using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapter
{
    class ConcreteAdapter : ADapter
    {
        private Adaptee adaptee;

        public ConcreteAdapter()
        {
            adaptee = new Adaptee();
        }

        public void Operation()
        {
            adaptee.AdapteeOperation();
        }
    }
}
