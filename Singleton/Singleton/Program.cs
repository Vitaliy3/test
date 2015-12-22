using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            Singletonclass MyInstance = Singletonclass.Sample();
            Singletonclass MyInstance2 = Singletonclass.Sample();

            Console.ReadKey();

        }
    }
}
