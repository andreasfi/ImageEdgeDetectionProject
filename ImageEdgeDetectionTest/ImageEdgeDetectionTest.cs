using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using ImageEdgeDetectionProject;
using ImageEdgeDetectionProject.BLL;
using System.Drawing;
using ImageEdgeDetectionTest.Properties;

namespace ImageEdgeDetectionTest
{
    //this is the #3 test list via NSubstitute interface calls
    [TestClass]
    public class ImageEdgeDetectionTest
    {
        String path;

        //given a string path this test verifies its initialization on an empty value
        Bitmap bitmap;
        Bitmap nullbitmap;
        [TestInitialize]
        public void TestInitialize()
        {
            path = "C:/Users/uadmin.SINFHES-M51AP8D/Source/Repos/ImageEdgeDetectionProject/ImageEdgeDetectionProject/ressources/notanimage.jpg";

            bitmap = Resources.view;
            nullbitmap = null;
        }

        //this test checks if the outcome of recalling a file through its path is true
        //through the interface substitute call
        [TestMethod]
        public void correctInputTestWithException()
        {
            var testIOFiles = Substitute.For<IIOfiles>();
            var testIImageDetection = Substitute.For<IImageDetection>();
            ImageManagement im = new ImageManagement(testIOFiles, testIImageDetection);

            testIOFiles.loadFile("nopath").Returns(k => { throw new ArgumentException(); });

            Bitmap falseimage = im.GetImageFromPath("nopath");

            Assert.AreEqual(falseimage, null);

        }
        [TestMethod]
        public void correctInputTestWithoutException()
        {
            var testIOFiles = Substitute.For<IIOfiles>();
            var testIImageDetection = Substitute.For<IImageDetection>();
            ImageManagement im = new ImageManagement(testIOFiles, testIImageDetection);

            testIOFiles.loadFile("nopath").Returns<Bitmap>(bitmap);

            Bitmap realimage = im.GetImageFromPath("nopath");

            //Assert.IsInstanceOfType(realimage, typeof(Bitmap));

            Assert.AreEqual(realimage, bitmap);

        }
        [TestMethod]
        
        public void correctOutputTestWithException()
        {
            var testIOFiles = Substitute.For<IIOfiles>();
            var testIImageDetection = Substitute.For<IImageDetection>();
            ImageManagement im = new ImageManagement(testIOFiles, testIImageDetection);

            /*
            [ExpectedException(typeof(NullReferenceException),
        "Wrong file path")]
        */

            testIOFiles.When(x => x.saveFile(bitmap, "nopath"))
                .Do(x => { throw new NullReferenceException(); });

            im.SaveImageToPath(bitmap, "nopath");
            Assert.IsTrue(im.t);
        }
        [TestMethod]
        public void correctOutputTestWithoutException()
        {
            var testIOFiles = Substitute.For<IIOfiles>();
            var testIImageDetection = Substitute.For<IImageDetection>();
            ImageManagement im = new ImageManagement(testIOFiles, testIImageDetection);
            Boolean isok = false;
            testIOFiles.When(x => x.saveFile(bitmap, "nopath"))
                .Do(x => isok=true );

            im.SaveImageToPath(bitmap, "nopath");

            Assert.IsTrue(isok);


        }

        //this test checks if the object path is properly pointing to the suggested root directory for the image when recalled
        [TestMethod]
        public void correctFilterTestWithException()
        {
            var testIOFiles = Substitute.For<IIOfiles>();
            var testIImageDetection = Substitute.For<IImageDetection>();
            ImageManagement im = new ImageManagement(testIOFiles, testIImageDetection);

            testIImageDetection.applyFilter(nullbitmap).Returns(k => { throw new Exception(); });

            Bitmap falseimage = im.applyTheFilter(nullbitmap);
            Assert.AreEqual(falseimage, null);
        }

        [TestMethod]
        public void correctFilterTestWithOutException()
        {
            var testIOFiles = Substitute.For<IIOfiles>();
            var testIImageDetection = Substitute.For<IImageDetection>();
            ImageManagement im = new ImageManagement(testIOFiles, testIImageDetection);

            testIImageDetection.applyFilter(nullbitmap).Returns<Bitmap>(bitmap);

            Bitmap realimage = im.applyTheFilter(bitmap);
            Assert.AreNotEqual(realimage, bitmap);
        }


    }
}
