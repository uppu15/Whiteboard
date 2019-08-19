using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountHowManyLetters;

namespace CountHowManyLettersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void thisisnotit()
        {
            Assert.AreEqual(13, Program.CountChars("this is not it!!"));
        }

        [TestMethod]
        public void TestMethodNumber()
        {
            Assert.AreEqual(7, Program.CountChars("1234 67 9"));
        }

        [TestMethod]
        public void ALotOfSpaces()
        {
            Assert.AreEqual(0, Program.CountChars ("                                             "));
        }

        [TestMethod]
        public void NoSpace()
        {
            Assert.AreEqual(13, Program.CountChars("thisisnotit!!"));
        }
    }

    [TestClass]
    public class CountLetters
    {
        [TestMethod]
        public void thisisnotit()
        {
            Assert.AreEqual(11, Program.CountLetters("this is not it!!"));
        }

        [TestMethod]
        public void TestMethodNumber()
        {
            Assert.AreEqual(0, Program.CountLetters("1234 67 9"));
        }

        [TestMethod]
        public void ALotOfSpaces()
        {
            Assert.AreEqual(0, Program.CountLetters("                          "));
        }

        [TestMethod]
        public void NoSpace()
        {
            Assert.AreEqual(11, Program.CountLetters("ThisIsnotit!!@#4"));
        }
    }
}
