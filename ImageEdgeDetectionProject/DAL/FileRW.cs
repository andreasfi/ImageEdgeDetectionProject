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
    //This is the main class for the DAL-Data Access Layer part of the program
    public class FileRW : IIOfiles
    {
        // this getter method initializes an empty image, pushes it into StreamReader object with points to a path
        //then it returns it
        public Bitmap loadFile(string path)
        {
            Bitmap image = null;
            StreamReader streamReader = new StreamReader(path);
            image = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
            streamReader.Close();
            return image;
        }

        // this setter method matches an image with its given path, where it gets stored
        // it also detects and specifies the exact extension of the image to be saved
        // the image is saven after being pushed trhough a StreamWriter object
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

            try
            {
                StreamWriter streamWriter = new StreamWriter(savepath, false);
                image.Save(streamWriter.BaseStream, imgFormat);
                streamWriter.Flush();
                streamWriter.Close();
            }
            catch (Exception e)
            {
                // logge
            }
            
        }
    }
}
