using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    class Program
    {
        static void Main()
        {
            ShapeMaker shapeMaker = new ShapeMaker();

            shapeMaker.DrawCircle();
            shapeMaker.DrawReactangle();
            shapeMaker.DrawSquare();

            Console.ReadKey();
        }
    }
}
