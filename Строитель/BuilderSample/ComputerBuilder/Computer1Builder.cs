using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderSample.ComputerBuilder
{
    class Computer1Builder : ComputerBuilderBase
    {
        public Computer1Builder(): base()
        {
        }

        public override void BuildCPU()
        {
            Computer.CPU = "Intel";
        }

        public override void BuildHDD()
        {
            Computer.HDD = "100";
        }

        public override void BuildRAM()
        {
            Computer.RAM = "16";
        }

        public override void BuildSoundCard()
        {
            Computer.RAM = "Creative";
        }

        public override void BuildVideoCard()
        {
            Computer.VideoCard = "ASUS";
        }
    }
}
