using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Tasks;
using rhoruntime;

namespace rho {

namespace CameraImpl
{
    public class CameraResult
    {
        protected IMethodResult _oResult = null;

        protected void cameraTask_Completed(object sender, PhotoResult e)
        {
            rho.common.Hashtable<String, String> mapRes = new rho.common.Hashtable<String, String>();
            
            switch (e.TaskResult)
            {
                case TaskResult.OK:
                    mapRes["imageUri"] = e.OriginalFileName;
                    mapRes["image_uri"] = e.OriginalFileName;
                    mapRes["status"] = "ok";
                    break;
                case TaskResult.None:
                    mapRes["message"] = "Error";
                    mapRes["status"] = "error";
                    break;
                case TaskResult.Cancel:
                    mapRes["message"] = "User cancelled operation";
                    mapRes["status"] = "cancel";
                    break;
                default:
                    break;
            }

            _oResult.set(mapRes);

            //Code to display the photo on the page in an image control named myImage.
            //System.Windows.Media.Imaging.BitmapImage bmp = new System.Windows.Media.Imaging.BitmapImage();
            //bmp.SetSource(e.ChosenPhoto);
            //myImage.Source = bmp;
        }
    };

    public class Camera : CameraResult, ICameraImpl 
    {
        
        public Camera()
        {
            CameraRuntimeComponent _runtime = new CameraRuntimeComponent(this);
        }
         
        public void getCameraType(IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getMaxWidth(IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getMaxHeight(IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getSupportedSizeList(IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getDesiredWidth(IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void setDesiredWidth(int desiredWidth, IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getDesiredHeight(IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void setDesiredHeight(int desiredHeight, IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getFileName(IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void setFileName(string fileName, IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getCompressionFormat(IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void setCompressionFormat(string compressionFormat, IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getOutputFormat(IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void setOutputFormat(string outputFormat, IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getColorModel(IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void setColorModel(string colorModel, IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getEnableEditing(IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void setEnableEditing(bool enableEditing, IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getFlashMode(IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void setFlashMode(string flashMode, IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getSaveToDeviceGallery(IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void setSaveToDeviceGallery(bool saveToDeviceGallery, IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getCaptureSound(IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void setCaptureSound(string captureSound, IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getPreviewLeft(IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void setPreviewLeft(int previewLeft, IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getPreviewTop(IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void setPreviewTop(int previewTop, IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getPreviewWidth(IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void setPreviewWidth(int previewWidth, IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getPreviewHeight(IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void setPreviewHeight(int previewHeight, IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getUseSystemViewfinder(IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void setUseSystemViewfinder(bool useSystemViewfinder, IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void takePicture(IReadOnlyDictionary<string, string> propertyMap, IMethodResult oResult)
        {
            _oResult = oResult;
            CameraCaptureTask cameraCaptureTask;
            cameraCaptureTask = new CameraCaptureTask();
            cameraCaptureTask.Completed += new EventHandler<PhotoResult>(cameraTask_Completed);
            cameraCaptureTask.Show();
        }

        public void getProperty(string propertyName, IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getProperties(IReadOnlyList<string> arrayofNames, IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getAllProperties(IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void setProperty(string propertyName, string propertyValue, IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void setProperties(IReadOnlyDictionary<string, string> propertyMap, IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void clearAllProperties(IMethodResult oResult)
        {
            // implement this method in C# here
        }
    }

    public class CameraSingleton : CameraResult, ICameraSingletonImpl
    {
        public CameraSingleton()
        {
            CameraSingletonComponent _runtime = new CameraSingletonComponent(this);
        }

        public void enumerate(IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getCameraByType(string cameraType, IMethodResult oResult)
        {
            // implement this method in C# here
        }

        public void choosePicture(IReadOnlyDictionary<string, string> propertyMap, IMethodResult oResult)
        {
            _oResult = oResult;
            PhotoChooserTask photoChooserTask;
            photoChooserTask = new PhotoChooserTask();
            photoChooserTask.Completed += new EventHandler<PhotoResult>(cameraTask_Completed);
            photoChooserTask.Show();
        }

        public void saveImageToDeviceGallery(string pathToImage, IMethodResult oResult)
        {
            // implement this method in C# here
        }
    }

    public class CameraFactory : ICameraFactoryImpl
    {
        public ICameraImpl getImpl() {
            return new Camera();
        }
        public ICameraSingletonImpl getSingletonImpl() {
            return new CameraSingleton();
        }
    }
}

}
