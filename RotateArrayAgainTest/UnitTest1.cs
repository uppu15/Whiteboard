using Microsoft.VisualStudio.TestTools.UnitTesting;
using RotateArrayAgain;

namespace RotateArrayAgainTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Howisthis()
        {
            Assert.AreEqual("thisHowis", RotateArrayAgain.Program.RotateArray("Howisthis",4));
        }

        [TestMethod]
        public void zeroRotation()
        {
            Assert.AreEqual("Howisthis", RotateArrayAgain.Program.RotateArray("Howisthis", 0));
        }
        [TestMethod]
        public void rotateMoreThanLength()
        {
            Assert.AreEqual("sHowisthi", RotateArrayAgain.Program.RotateArray("Howisthis", 9));
        }
        [TestMethod]
        public void nullString()
        {
            Assert.AreEqual("No string to rotate", RotateArrayAgain.Program.RotateArray("", 4));
        }

    }
}
