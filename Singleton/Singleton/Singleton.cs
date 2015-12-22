using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPat
{
    public class Singleton
    {
        // mutex защита для использования нескольких потоков одновременно
        private static readonly object mutex = new object();
        private static Singleton example;

        private Singleton()
        {
            Console.WriteLine("Instance is created");
        }

        public static Singleton Sample()
        {// Если example null, то создаем его
            if (example == null) 
            {//пока один поток (первый instance имеет mutex) все остальные потоки будут блокированы
                lock (mutex)
                {
                    if (example == null)
                    {// первый поток может создать наш Singleton
                        example = new Singleton();
                    }
                }
            }
            return example;
        }
    }
}
