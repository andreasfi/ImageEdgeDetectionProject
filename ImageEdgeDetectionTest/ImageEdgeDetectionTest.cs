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
        string path;

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

        // Test input and throw execption
        [TestMethod]
        public void correctInputTestWithException()
        {
            var testIOFiles = Substitute.For<IIOfiles>();
            var testIImageDetection = Substitute.For<IImageDetection>();
            ImageManagement im = new ImageManagement(testIOFiles, testIImageDetection);

            testIOFiles.loadFile("nopath").Returns(k => { throw new ArgumentException(); });

            Bitmap falseimage = im.GetImageFromPath("nopath");

            // If there is a exception the catch will return null
            Assert.AreEqual(falseimage, null);

        }
        // Test input to check if it really is a bitmap
        [TestMethod]
        public void correctInputTestWithoutException()
        {
            var testIOFiles = Substitute.For<IIOfiles>();
            var testIImageDetection = Substitute.For<IImageDetection>();
            ImageManagement im = new ImageManagement(testIOFiles, testIImageDetection);

            testIOFiles.loadFile("nopath").Returns<Bitmap>(bitmap);

            Bitmap realimage = im.GetImageFromPath("nopath");

            // Compares if it is bitmaps
            Assert.AreEqual(realimage, bitmap);

        }
        // Test output by throwing an exception
        [TestMethod]
        public void correctOutputTestWithException()
        {
            var testIOFiles = Substitute.For<IIOfiles>();
            var testIImageDetection = Substitute.For<IImageDetection>();
            ImageManagement im = new ImageManagement(testIOFiles, testIImageDetection);

            // We throw an exception when the methods is used
            testIOFiles.When(x => x.saveFile(bitmap, "nopath"))
                .Do(x => { throw new NullReferenceException(); });


            im.SaveImageToPath(bitmap, "nopath");
            // We get the boolean (that is in ImageManagement) and check if its true
            Assert.IsTrue(im.t);
        }
        // Test the output 
        [TestMethod]
        public void correctOutputTestWithoutException()
        {
            var testIOFiles = Substitute.For<IIOfiles>();
            var testIImageDetection = Substitute.For<IImageDetection>();
            ImageManagement im = new ImageManagement(testIOFiles, testIImageDetection);
            Boolean isok = false;

            // Since its a void method we need to use when do
            // When the file is written it sets the boolean to true
            testIOFiles.When(x => x.saveFile(bitmap, "nopath"))
                .Do(x => isok=true );

            im.SaveImageToPath(bitmap, "nopath");

            Assert.IsTrue(isok);
        }

        // Test if there is a exception
        [TestMethod]
        public void correctFilterTestWithException()
        {
            var testIOFiles = Substitute.For<IIOfiles>();
            var testIImageDetection = Substitute.For<IImageDetection>();
            ImageManagement im = new ImageManagement(testIOFiles, testIImageDetection);

            // It throws an exception
            testIImageDetection.applyFilter(nullbitmap).Returns(k => { throw new Exception(); });

            Bitmap falseimage = im.applyTheFilter(nullbitmap);

            // If a exception is trown, applyTheFilter returns null
            Assert.AreEqual(falseimage, null);
        }

        // Test if the filter is applied
        [TestMethod]
        public void correctFilterTestWithOutException()
        {
            var testIOFiles = Substitute.For<IIOfiles>();
            var testIImageDetection = Substitute.For<IImageDetection>();
            ImageManagement im = new ImageManagement(testIOFiles, testIImageDetection);

            // The substitute return a bitmap
            testIImageDetection.applyFilter(nullbitmap).Returns<Bitmap>(bitmap);

            Bitmap realimage = im.applyTheFilter(bitmap);

            // Check if the initial image is different (filter applied)
            Assert.AreNotEqual(realimage, bitmap);
        }


    }
}
