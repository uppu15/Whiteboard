using Microsoft.VisualStudio.TestTools.UnitTesting;
using HowManyCaps;

namespace HowManyCapsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCountCaptialsStarWars()
        {
            Assert.AreEqual(2, UpperCase.CountCaps("Star Wars"));
            Assert.AreEqual(12, UpperCase.CountCaps("NowIsTheTimeForAllGoodMenToComeAndEat"));
            Assert.AreEqual(4, UpperCase.CountCaps("ThisIsPascalCase"));
            Assert.AreEqual(7, UpperCase.CountCaps("It's ALWAYS a good time for tacos!"));
        }
        [TestMethod]
        public void TestCountCaptials()
        {
            Assert.AreEqual(2, UpperCase.CountCaps("Star Wars"));
        }
    }
}
