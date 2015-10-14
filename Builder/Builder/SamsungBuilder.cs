using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class SamsungBuilder : RefgBuilderBase
    {
        public SamsungBuilder() : base()
        { }

        public override void BuildDoors()
        {
            Refg.Doors = "Samsung n-200";
        }

        public override void BuildEngine()
        {
            Refg.Engine = "Sg 7000";
        }
        public override void BuildFreeze()
        {
            Refg.freezer = "Han 21";
        }
        public override void BuildGuarantee()
        {
            Refg.guarantee = "S8";
        }
    }
}
