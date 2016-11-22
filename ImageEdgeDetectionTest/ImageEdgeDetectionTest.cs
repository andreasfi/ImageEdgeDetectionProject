using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using ImageEdgeDetectionProject;
using ImageEdgeDetectionProject.BLL;

namespace ImageEdgeDetectionTest
{
    [TestClass]
    public class ImageEdgeDetectionTest
    {
        String path;
        [TestInitialize]
        public void TestInitialize()
        {
            path = "";
        }
        [TestMethod]
        public void correctInputTestWithException()
        {
            var testSubstituteForInterface = Substitute.For<IIOfiles>();
            FileRW frw = new FileRW();

            testSubstituteForInterface
                .When(x => x.loadFile(path))
               .Do(x => { throw new Exception(); });

            frw.loadFile(path);


            Assert.AreEqual(frw, true);

        }
        [TestMethod]
        public void correctInputTest2()
        {
            var reader = Substitute.For<IIOfiles>();

            ImageDetection imgd = new ImageDetection();
            String path = "C:/Users/uadmin.SINFHES-M51AP8D/Source/Repos/ImageEdgeDetectionProject/ImageEdgeDetectionProject/ressources/notanimage.jpg";
            reader.loadFile(path);

            //Assert.IsInstanceOfType();

        }
    }
}
