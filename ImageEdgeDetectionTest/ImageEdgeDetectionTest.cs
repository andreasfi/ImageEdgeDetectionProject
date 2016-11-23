using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using ImageEdgeDetectionProject;
using ImageEdgeDetectionProject.BLL;
using System.Drawing;
using ImageEdgeDetectionTest.Properties;

namespace ImageEdgeDetectionTest
{
    [TestClass]
    public class ImageEdgeDetectionTest
    {
        String path;
        Bitmap bitmap;
        Bitmap nullbitmap;
       [TestInitialize]
        public void TestInitialize()
        {
            path = "C:/Users/uadmin.SINFHES-M51AP8D/Source/Repos/ImageEdgeDetectionProject/ImageEdgeDetectionProject/ressources/notanimage.jpg";

            bitmap = Resources.view;
            nullbitmap = null;
        }
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
        [ExpectedException(typeof(NullReferenceException),
        "Wrong file path")]
        public void correctOutputTestWithException()
        {
            var testIOFiles = Substitute.For<IIOfiles>();
            var testIImageDetection = Substitute.For<IImageDetection>();
            ImageManagement im = new ImageManagement(testIOFiles, testIImageDetection);

            //testIOFiles.saveFile(nullbitmap, "nopath");


            testIOFiles.When(x => x.saveFile(bitmap, "nopath"))
                .Do(x => { throw new NullReferenceException(); });
            
            im.SaveImageToPath(bitmap, "nopath");
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
