using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterSample.CamepaPhone
{
    class CameraPhone1 : ICameraPhone
    {
        public string Name
        {
            get; set;
        }

        public void Photo()
        {
            Console.WriteLine("Фото с телефона");
        }

        public void Video()
        {
            Console.WriteLine("Видео с телефона");
        }
    }
}
