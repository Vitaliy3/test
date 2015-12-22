using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw --- Circle");
        }
    }
}
