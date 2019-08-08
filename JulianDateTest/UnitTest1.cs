using Microsoft.VisualStudio.TestTools.UnitTesting;
using JulianDate;

namespace JulianDateTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void JulianTest0103()
        {
            Assert.AreEqual(3, JulianDate.Julie.JulianDateCal(1, 3));
        }

        [TestMethod]
        public void JulianTest0506()
        {
            Assert.AreEqual(126, JulianDate.Julie.JulianDateCal(5, 6));
        }

        [TestMethod]
        public void JulianTest0930()
        {
            Assert.AreEqual(273, JulianDate.Julie.JulianDateCal(9, 30));
        }

        [TestMethod]
        public void JulianTest1231()
        {
            Assert.AreEqual(365, JulianDate.Julie.JulianDateCal(12, 31));
        }
    }
}
