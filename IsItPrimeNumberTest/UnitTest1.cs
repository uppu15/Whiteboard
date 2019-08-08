using Microsoft.VisualStudio.TestTools.UnitTesting;
using IsItPrimeNumber;

namespace IsItPrimeNumberTest
{
    [TestClass]
    public class PrimeTest
    {
        [TestMethod]
        public void TestPrime_2()
        {
            int x = 2;
            Assert.IsTrue(Program.isPrimeNumber(x));
        }
        [TestMethod]
        public void TestPrime_11()
        {
            int x = 11;
            Assert.IsTrue(Program.isPrimeNumber(x));
        }
        [TestMethod]
        public void TestPrime_9()
        {
            int x = 9;
            Assert.IsFalse(Program.isPrimeNumber(x));
        }
        [TestMethod]
        public void TestPrime_100()
        {
            int x = 100;
            Assert.IsFalse(Program.isPrimeNumber(x));
        }
        [TestMethod]
        public void TestPrime_1()
        {
            int x = 1;
            Assert.IsFalse(Program.isPrimeNumber(x));
        }
        [TestMethod]
        public void TestPrime_0()
        {
            int x = 0;
            Assert.IsFalse(Program.isPrimeNumber(x));
        }
        [TestMethod]
        public void TestPrime_negative0()
        {
            int x = -3;
            Assert.IsFalse(Program.isPrimeNumber(x));
        }
        [TestMethod]
        public void TestPrime_113()
        {
            int x = 113;
            Assert.IsTrue(Program.isPrimeNumber(x));
        }
    }
}

