using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            var rfBuidler = new VostokBuilder();// базовая комплектация холодильника
            rfBuidler.BuildDoors();
            rfBuidler.BuildEngine();

            var rfg = rfBuidler.GetRefg();
            Console.WriteLine(rfg);
            
            rfBuidler.BuildGuarantee();// комплектация с гарантией
            rfg = rfBuidler.GetRefg();
            Console.WriteLine(rfg);

            var rfBuilderS = new SamsungBuilder();
            rfBuilderS.BuildDoors();
            rfBuilderS.BuildEngine();
            rfBuilderS.BuildFreeze();
            rfBuilderS.BuildGuarantee();
            var rfgS = rfBuilderS.GetRefg();
            Console.WriteLine(rfgS);
            


            Console.ReadKey();

            


        }
    }


    class Refg
    {
        public string Engine { get; set; }
        public string Doors { get; set; }
        public string freezer { get; set; }
        public string guarantee { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("Engine: {0} \n", Engine);
            sb.AppendFormat("Doors: {0} \n", Doors);
            sb.AppendFormat("freezer: {0} \n", freezer);
            sb.AppendFormat("guarantee: {0} \n", guarantee);

            return sb.ToString();
        }
        
    }
    abstract class RefgBuilderBase
    {
        protected Refg Refg;

        protected RefgBuilderBase()
        {
            Refg = new Refg();
        }
        public Refg GetRefg()
        {
            return Refg;
        }
        public abstract void BuildEngine();
        public abstract void BuildFreeze();
        public abstract void BuildDoors();
        public abstract void BuildGuarantee();
    }

    



}
