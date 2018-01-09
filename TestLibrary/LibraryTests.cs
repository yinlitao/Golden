using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;

namespace TestLibrary
{
    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(43, new Thing().Get(43));
        }
    }
}
