using System;

namespace Prototype
{
    class MainApp
    {
        static void Main()
        {
            //Создание 2-х экземпляров и клонировние
            Prototype prototype1 = new ConcretePrototype1("1");
            Prototype clonedPrototype1 = prototype1.Clone();
            Console.WriteLine("Cloned: {0}", clonedPrototype1.Id);

            Prototype prototype2 = new ConcretePrototype2("2");
            Prototype clonedPrototype2 = prototype2.Clone();
            Console.WriteLine("Cloned: {0}", clonedPrototype2.Id);

            Console.ReadKey();
        }
    }

    public abstract class Prototype
    {
        public Prototype(string id)
        {
            this.Id = id;

            Console.Write("Base constructor is called.");
        }

        public string Id { get; set; }

        public virtual Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id)
            : base(id)
        {
        }
    }

    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string id)
            : base(id)
        {
        }
    }
}
