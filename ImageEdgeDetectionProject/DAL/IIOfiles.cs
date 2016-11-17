using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEdgeDetectionProject
{
    interface IIOfiles
    {
        Bitmap loadFile(string path);
        void saveFile(Bitmap image, string savepath);

    }
}
