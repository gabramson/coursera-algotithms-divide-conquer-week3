using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuicksorterLib;

namespace QuicksortTest
{
    [TestClass]
    public class QuicksortTest
    {
        [TestMethod]
        public void TestQuicksort()
        {
            var quicksorter = new Quicksorter<int>();
            quicksorter.Add(10);
            quicksorter.Add(5);
            quicksorter.Sort();
            Assert.AreEqual(1, quicksorter.Comparisons);
        }
    }
}
