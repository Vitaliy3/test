using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw --- Rectangle");
        }
    }
}
