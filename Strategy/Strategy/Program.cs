using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine auto = new Engine(4, "Volvo", new PetrolMove());
            auto.Move();
            auto.Movable = new GasMove();
            auto.Move();

            Console.ReadLine();
        }
    }
    interface IStrateg
    {
        void Move();
    }

    class PetrolMove : IStrateg
    {
        public void Move()
        {
            Console.WriteLine("Стратегия с бензиновым двигателем");
        }
    }

    class GasMove : IStrateg
    {
        public void Move()
        {
            Console.WriteLine("Стратегия с газовым двигателем");
        }
    }
    class Engine
    {
        protected int liters; // параметр кол-во литров 
        protected string model; // параметр модель двигателя

        public Engine(int num, string model, IStrateg mov)
        {
            this.liters = num;
            this.model = model;
            Movable = mov;
        }
        public IStrateg Movable { private get; set; }
        public void Move()
        {
            Movable.Move();
        }
    }
}
