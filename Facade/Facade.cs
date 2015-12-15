using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    class Facade
    {
        public void Method(){

            Service service = new Service();

            service.methodA();

            service.methodB();

            service.methodC();
            
        }
    }
}
