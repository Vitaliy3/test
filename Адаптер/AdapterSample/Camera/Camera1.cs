using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterSample.Camera
{
    class Camera1 : ICamera
    {
        public string Name
        {
            get;
            set;
        }

        public void QualityPhoto()
        {
            Console.WriteLine("Фото с камеры");
        }

        public void QualityVideo()
        {
            Console.WriteLine("Видео с камеры");
        }
    }
}
