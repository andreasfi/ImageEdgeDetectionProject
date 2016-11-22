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
    class ImageManagement
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
            return filerw.loadFile(path);
        }
        public void SaveImageToPath(Bitmap image, String path)
        {
            filerw.saveFile(image, path);
        }
        public Bitmap applyTheFilter(Bitmap image)
        {
            return imageDetection.applyFilter(image);
        }
    }
}
