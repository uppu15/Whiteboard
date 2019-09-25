using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindSubstring;

namespace FindSubstringTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void sandiego()
        {
            Assert.Equals(0, Program.IsSubstringThere("San Diego", "sand"));
        }

        [TestMethod]
        public void elephant()
        {
            Assert.Equals(5, Program.IsSubstringThere("Elephant", "ant"));
        }

        [TestMethod]
        public void nullstring()
        {
            Assert.Equals(-1, Program.IsSubstringThere("", ""));
        }

        [TestMethod]
        public void noMatch()
        {
            Assert.Equals(-1, Program.IsSubstringThere("1234", "asdf"));
        }
    }
}
