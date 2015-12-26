using System;
using BuilderSample.ComputerBuilder;

namespace BuilderSample
{
    class Program
    {
        static void Main(string[] args)
        { 
            var Computer = new Computer1Builder();
            Computer.BuildCPU();
            Computer.BuildHDD();
            Computer.BuildRAM();

            var newComputer = Computer.GetComputer();
            Console.WriteLine(newComputer);


            Computer.BuildSoundCard();
            Computer.BuildVideoCard();
            newComputer = Computer.GetComputer();
            Console.WriteLine(newComputer);

            Console.ReadLine();
        }
    }
}
