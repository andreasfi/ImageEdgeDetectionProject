using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageEdgeDetectionProject.BLL;
using System.Drawing;
using NSubstitute;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using ImageEdgeDetectionProject;

namespace ImageEdgeDetectionTest
{
    [TestClass]
    class MyImageDetection
    {
        String path;
        Bitmap image;
        [TestInitialize]
        public void TestInitialize()
        {
            path = "ressources/view.jpg";

            StreamReader streamReader = new StreamReader(path);
            image = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
            streamReader.Close();
        }
        [TestMethod]
        public void loadImageTest()
        {
            var test = Substitute.For<IIOfiles>();

            ImageDetection imgd = new ImageDetection();
            
            
            

            test.When(x => x.loadFile(path)).Do(x => { throw new Exception(); });
            Bitmap loadimage = test.loadFile(path);


            Assert.AreEqual(image, loadimage);

        }
        [TestMethod]
        public void saveImageTest()
        {
           
        }
    }
}
