using ImageEdgeDetectionProject.BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEdgeDetectionProject
{
    // This class is the class that should be tested
    public class ImageManagement
    {
        readonly IIOfiles filerw;
        readonly IImageDetection imageDetection;
        public ImageManagement(IIOfiles filerw, IImageDetection imageDetection)
        {
            this.filerw = filerw;
            this.imageDetection = imageDetection;
        }
        public Bitmap GetImageFromPath(String path)
        {
            Bitmap image;
            try
            {
                image = filerw.loadFile(path);
            } catch (ArgumentException ae)
            {
                return null;
            }
            return image;
        }
        public Boolean t;
        public void SaveImageToPath(Bitmap image, String path)
        {
            t = false;
            try
            {
                filerw.saveFile(image, path);
            } catch(NullReferenceException nre)
            {
                //throw new NullReferenceException();
                t = true;
            } 
            
        }
        public Bitmap applyTheFilter(Bitmap image)
        {
            try
            {
                return imageDetection.applyFilter(image);
            } catch (Exception e)
            {
                return null;
            }
        }
    }
}
