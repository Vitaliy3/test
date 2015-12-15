using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    class Service
    {
        public void methodA()
        {
            Console.WriteLine("вызван метод А");
        }

        public void methodB()
        {
            Console.WriteLine("вызван метод B");
        }

        public void methodC()
        {
            Console.WriteLine("вызван метод C");
        }
    }
}
