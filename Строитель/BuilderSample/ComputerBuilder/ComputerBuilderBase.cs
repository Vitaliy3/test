using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderSample.ComputerBuilder
{
    abstract class ComputerBuilderBase
    {
        protected Computer Computer;

        protected ComputerBuilderBase()
        {
            Computer = new Computer();
        }

        public Computer GetComputer()
        {
            return Computer;
        }

        public abstract void BuildCPU();
        public abstract void BuildHDD();
        public abstract void BuildRAM();
        public abstract void BuildSoundCard();
        public abstract void BuildVideoCard();

    }
}
