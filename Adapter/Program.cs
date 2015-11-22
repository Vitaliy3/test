using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Adapter;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ADapter adapter = new ConcreteAdapter();
            adapter.Operation();
            Console.ReadKey();
        }
    }
}
