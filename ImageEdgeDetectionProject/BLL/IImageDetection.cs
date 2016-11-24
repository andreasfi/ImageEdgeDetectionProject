using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEdgeDetectionProject.BLL
{
    // this is the interface for the 'ImageDetection' Class
    // this specific interface for the applyFilter of the programm
    // IO is also implemented, but calls the DAL class
    public interface IImageDetection
    {
        // the third one is for applying the filter to the saved image
        Bitmap applyFilter(Bitmap image);
        
    }
}
