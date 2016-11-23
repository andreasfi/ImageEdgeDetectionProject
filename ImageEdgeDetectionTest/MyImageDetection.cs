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
    //this is the tests list referring to the main ImageDetection class for the BLL-Business Logic Layer
    [TestClass]
    class MyImageDetection
    {
        String path;
        Bitmap image;

        //this test initializes a given image file path, then pushes the path into a StreamReader class object
        [TestInitialize]
        public void TestInitialize()
        {
            path = "ressources/view.jpg";

            StreamReader streamReader = new StreamReader(path);
            image = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
            streamReader.Close();
        }

        //this test checks if a detected image and its path loaded equivalent are (or not) matching 
        //when called through the interface 
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
