using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPat
{
    class Program
    {
        static void Main()
        {
            Singleton MyInstance = Singleton.Sample();
            Singleton MyInstance2 = Singleton.Sample();

            Console.ReadKey();

        }
    }
}
