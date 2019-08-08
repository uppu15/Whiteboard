using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClockAngle;

namespace ClockAngleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AngleDiff1200()
        {
            
            Assert.AreEqual(0, ClockAngle.Clock.ClockAngleCal(12, 00));
        }
        [TestMethod]
        public void AngleDiff0300()
        {
            Assert.AreEqual(90, ClockAngle.Clock.ClockAngleCal(3, 00));
        }
        [TestMethod]
        public void AngleDiff0930()
        {
            Assert.AreEqual(105, ClockAngle.Clock.ClockAngleCal(9, 30));
        }
        [TestMethod]
        public void AngleDiff0430()
        {
            Assert.AreEqual(45, ClockAngle.Clock.ClockAngleCal(4, 30));
        }
    }
}
