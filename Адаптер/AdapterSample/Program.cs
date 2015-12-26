using System;
using AdapterSample.Adapters;
using AdapterSample.CamepaPhone;
using AdapterSample.Camera;

namespace AdapterSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ICamera camera = new Camera1();
            camera.Name = "Canon";
            PhoneInfoPrinter.PrintPhoneInfo(camera);

            ICameraPhone cameraPhone = new CameraPhone1();
            cameraPhone.Name = "LG";
            CameraAdapter adapter = new CameraAdapter(cameraPhone);
            PhoneInfoPrinter.PrintPhoneInfo(adapter); 
        
            Console.ReadLine();
        }
    }
}
