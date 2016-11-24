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
            // We pass the interfaces through the constructor
            this.filerw = filerw;
            this.imageDetection = imageDetection;
        }
        public Bitmap GetImageFromPath(String path)
        {
            // In a trycatch, we try to load the file
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
            // in a trycatch, we try to save the file
            t = false;
            try
            {
                filerw.saveFile(image, path);
            } catch(NullReferenceException nre)
            {
                // To verify if the exception was raised, we use a boolean
                // The ImageEdgeDetectionTest then checks if the boolean is true/that the exception was raised
                t = true;
            } 
            
        }
        public Bitmap applyTheFilter(Bitmap image)
        {
            // In a trycatch, we try to apply the filter to the image 
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
