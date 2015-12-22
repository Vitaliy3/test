using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    public class Singletonclass
    {
        private static readonly object obj = new object();
        private static Singletonclass example;

        private Singletonclass()
        {
            Console.WriteLine("Instance is created");
        }

        public static Singletonclass Sample()
        {
            if (example == null) 
            {
                lock (obj)
                {
                    if (example == null)
                    {
                        example = new Singletonclass();
                    }
                }
            }
            return example;
        }
    }
}
