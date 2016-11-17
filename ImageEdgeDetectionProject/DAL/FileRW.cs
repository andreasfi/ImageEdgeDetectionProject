using System;
using System.Collections.Generic;
using System.Drawing;
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

        public void saveFile(Bitmap image)
        {
            throw new NotImplementedException();
        }


    }
}
