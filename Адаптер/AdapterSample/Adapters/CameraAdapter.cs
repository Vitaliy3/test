using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdapterSample.CamepaPhone;
using AdapterSample.Camera;

namespace AdapterSample.Adapters
{
    class CameraAdapter : ICamera
    {

        private ICameraPhone _cameraPhone;

        public CameraAdapter(ICameraPhone cameraPhone)
        {
            _cameraPhone = cameraPhone;
        }  

        public string Name
        {
            get
            {
                return _cameraPhone.Name;
            }
            set
            {               
            }
        }

        public void QualityPhoto()
        {
            _cameraPhone.Photo();
        }

        public void QualityVideo()
        {
            _cameraPhone.Video();
        }
    }
}         

      