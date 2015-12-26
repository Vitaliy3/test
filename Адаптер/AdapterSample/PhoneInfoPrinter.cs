using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdapterSample.Camera;

namespace AdapterSample
{
    class PhoneInfoPrinter
    {
        public static void PrintPhoneInfo(ICamera cat)
        {
            Console.WriteLine("Камера:");
            Console.WriteLine(string.Format("Наименование: {0}", cat.Name));
            Console.Write("Фото: ");
            cat.QualityPhoto();
            Console.Write("Видео: ");
            cat.QualityVideo();

            Console.WriteLine();
        }
    }
}
