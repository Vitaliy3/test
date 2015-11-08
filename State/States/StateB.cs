using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    class StateB : IState
    {
        public String Say()
        {
            return "Bad";
        }
    }
}
