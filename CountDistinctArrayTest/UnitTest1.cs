using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountDistinctArray;

namespace CountDistinctArrayTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3 };
            Assert.AreEqual(8, Program.CountDistinctElements(x));
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] x = {  };
            Assert.AreEqual(0, Program.CountDistinctElements(x));
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] x = { 12, 12, 12, 12, 12 };
            Assert.AreEqual(1, Program.CountDistinctElements(x));
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[] x = { 2, 3, 4, 5, 2, 2, 2, 2, 3, 4 };
            Assert.AreEqual(4, Program.CountDistinctElements(x));
        }
    }
}
