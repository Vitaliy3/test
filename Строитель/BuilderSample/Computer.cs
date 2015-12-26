using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderSample
{
    class Computer
    {
        public string CPU { get; set; }
        public string HDD { get; set; }
        public string RAM { get; set; }
        public string SoundCard { get; set; }
        public string VideoCard { get; set; }       

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("CPU: {0}\n", CPU);
            sb.AppendFormat("HDD: {0}\n", HDD);
            sb.AppendFormat("RAM: {0}\n", RAM);
            sb.AppendFormat("SoundCard: {0}\n", SoundCard);
            sb.AppendFormat("VideoCard: {0}\n", VideoCard);           

            return sb.ToString();
        }
    }
}
