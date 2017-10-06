using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuicksorterLib;

namespace QuicksortTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestQuicksort()
        {
            var quicksorter = new Quicksorter();
            quicksorter.Add(10);
        }
    }
}
