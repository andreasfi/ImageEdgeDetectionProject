using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEdgeDetectionProject
{

    // this is the creation of the relative interface 
    // this specific interface refers exclusively to the DAL-Data Access Layer main class
    public interface IIOfiles
    {
        //the interface deals with the 'path' and the image saving functions that points to that path 
        Bitmap loadFile(string path);
        void saveFile(Bitmap image, string savepath);

    }
}
