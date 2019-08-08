using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfOdds;

namespace SumOfOddsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumOfOddsTest10()
        {
            Assert.AreEqual(25, Program.SumOfOdds(10));
        }
        [TestMethod]
        public void SumOfOddsTest2()
        {
            Assert.AreEqual(1, Program.SumOfOdds(2));
        }
    }
}
