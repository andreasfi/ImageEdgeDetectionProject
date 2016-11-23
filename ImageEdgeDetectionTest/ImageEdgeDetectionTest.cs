using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using ImageEdgeDetectionProject;
using ImageEdgeDetectionProject.BLL;

namespace ImageEdgeDetectionTest
{
    //this is the #3 test list via NSubstitute interface calls
    [TestClass]
    public class ImageEdgeDetectionTest
    {
        String path;

        //given a string path this test verifies its initialization on an empty value
        [TestInitialize]
        public void TestInitialize()
        {
            path = "";
        }

        //this test checks if the outcome of recalling a file through its path is true
        //through the interface substitute call
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

        //this test checks if the object path is properly pointing to the suggested root directory for the image when recalled
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
