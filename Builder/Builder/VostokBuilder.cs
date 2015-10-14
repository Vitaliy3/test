using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class VostokBuilder : RefgBuilderBase 
    {
        public VostokBuilder() : base()
        { }

        public override void BuildDoors()
        {
            Refg.Doors = "Votok dver 2001";
        }

        public override void BuildEngine()
        {
            Refg.Engine = "Super 9 ";
        }
        public override void BuildFreeze()
        {
            Refg.freezer = "Mur 12";
        }
        public override void BuildGuarantee()
        {
            Refg.guarantee = "S11 ";
        }


    }
}
