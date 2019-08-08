using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MirrorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MirrorTest_Jason()
        {
            Assert.AreEqual("nosaJ", Mirror.Program.MirrorString("Jason"));
        }
        [TestMethod]
        public void MirrorTest_ABC_Space()
        {
            Assert.AreEqual("CBA 321", Mirror.Program.MirrorString("123 ABC"));
        }
        [TestMethod]
        public void MirrorTest_Caliope()
        {
            Assert.AreEqual("epoilaC", Mirror.Program.MirrorString("Caliope"));
        }
        [TestMethod]
        public void MirrorTest_LeadingSpaces()
        {
            Assert.AreEqual("nosaJ  ", Mirror.Program.MirrorString("  Jason"));
        }
    }
}
