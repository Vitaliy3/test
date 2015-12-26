using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterSample.Camera
{
    interface ICamera
    {
        string Name { get; set; }
        void QualityPhoto();
        void QualityVideo();
    }
}
