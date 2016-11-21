using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEdgeDetectionProject.BLL
{
    class FileRW : IIOfiles
    {

        public Bitmap loadFile(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            Bitmap image = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
            streamReader.Close();

            return image;
        }

        public void saveFile(Bitmap image, string savepath)
        {
            string fileExtension = Path.GetExtension(savepath).ToUpper();
            ImageFormat imgFormat = ImageFormat.Png;

            if (fileExtension == "BMP")
            {
                imgFormat = ImageFormat.Bmp;
            }
            else if (fileExtension == "JPG")
            {
                imgFormat = ImageFormat.Jpeg;
            }

            StreamWriter streamWriter = new StreamWriter(savepath, false);
            image.Save(streamWriter.BaseStream, imgFormat);
            streamWriter.Flush();
            streamWriter.Close();
        }


    }
}
