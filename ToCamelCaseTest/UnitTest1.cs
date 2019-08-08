using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ToCamelCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ToCamelCase1()
        {
            Assert.AreEqual("aSimpleStringInCamelCase", CamelCaseDemo.toCamelCase("A sImPle sTrInG iN camEl cAsE"));
        }

        [TestMethod]
        public void ToCamelCase2()
        {
            Assert.AreEqual("even More Simpler String", CamelCaseDemo.camelCase("Even mOrE sImPlEr sTrInG"));
        }

        //[TestMethod]
        //public void ToCamelCase3()
        //{
        //    Assert.AreEqual("it's A Wonderful Life", CamelCaseDemo.toCamelCase("iT's a wOnDeRfUl lIfE"));
        //}

        //[TestMethod]
        //public void ToCamelCase2space()
        //{
        //    Assert.AreEqual("Dan Likes Taco", CamelCaseDemo.toCamelCase("dAn liKeS taco"));
        //}

        //[TestMethod]
        //public void ToCamelCaseOnlySpace()
        //{
        //    Assert.AreEqual(" ", CamelCaseDemo.toCamelCase(" "));
        //}
    }
}
