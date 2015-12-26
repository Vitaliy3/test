using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterSample.CamepaPhone
{
    interface ICameraPhone
    {
        string Name { get; set; }
        void Photo();
        void Video();
    } 
}
