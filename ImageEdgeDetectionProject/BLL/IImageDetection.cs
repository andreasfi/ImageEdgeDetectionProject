using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEdgeDetectionProject.BLL
{
    interface IImageDetection
    {
        Bitmap loadImage(string path);
        void saveImage(Bitmap image, string savepath);
        Bitmap applyFilter(Bitmap image);
        
    }
}
