using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrokenPrinter;

namespace BrokenPrinterTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void chococake()
        {
            Assert.AreEqual(5, BrokenPrinter.Program.NumChar("i don't want to eat this coconut chocolate cake", 'c'));
        }

        [TestMethod]
        public void nullString()
        {
            Assert.AreEqual(0, BrokenPrinter.Program.NumChar("", ' '));
        }

        [TestMethod]
        public void bunchaSpaces()
        {
            Assert.AreEqual(10, BrokenPrinter.Program.NumChar("          ", ' '));
        }

        [TestMethod]
        public void noCharAppear()
        {
            Assert.AreEqual(0, BrokenPrinter.Program.NumChar("this string will not use letter that is between b and d", 'c'));
        }
    }
}
