using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEdgeDetectionProject.BLL
{
    class ImageDetection : IImageDetection
    {
        IIOfiles fileHandler;

        public ImageDetection()
        {
            fileHandler = new FileRW();
        }

        public Bitmap applyFilter(Bitmap image)
        {
            throw new NotImplementedException();
        }

        public Bitmap loadImage(string path)
        {
            Bitmap image = fileHandler.loadFile(path);
            return image;
        }

        public void saveImage(Bitmap image, string savepath)
        {
            fileHandler.saveFile(image, savepath);
        }
    }
}
