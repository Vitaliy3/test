using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    class StateA : IState
    {
        public String Say()
        {
            return "Good";
        }
    }
}
