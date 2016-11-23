using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEdgeDetectionProject.BLL
{
    // this is the creation of the interface relative to 'ImageDetection' Class
    // this specific interface with its tests list refers exclusively to the BLL-Business Layer Logic main class
    public interface IImageDetection
    {
        //three substitute method calls:
        // the first one is for the image path to be loaded
        Bitmap loadImage(string path);

        //the second one is for the image to be saved in the given path
        void saveImage(Bitmap image, string savepath);

        // the third one is for applying the filter to the saved image
        Bitmap applyFilter(Bitmap image);
        
    }
}
