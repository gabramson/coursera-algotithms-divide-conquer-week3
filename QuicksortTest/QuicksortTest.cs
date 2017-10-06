using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuicksorterLib;

namespace QuicksortTest
{
    [TestClass]
    public class QuicksortTest
    {
        [TestMethod]
        public void TestLeftQuicksort()
        {
            var quicksorter = new LeftQuicksorter<int>();
            PopulateAndSort(quicksorter);
            Assert.AreEqual(13, quicksorter.Comparisons);
            Assert.AreEqual(9, quicksorter.SortedCopy[6]);
        }

        [TestMethod]
        public void TestRightQuicksort()
        {
            var quicksorter = new RightQuicksorter<int>();
            PopulateAndSort(quicksorter);
            Assert.AreEqual(17, quicksorter.Comparisons);
            Assert.AreEqual(9, quicksorter.SortedCopy[6]);
        }

        [TestMethod]
        public void TestMidQuicksort()
        {
            var quicksorter = new MidQuicksorter<int>();
            PopulateAndSort(quicksorter);
            Assert.AreEqual(10, quicksorter.Comparisons);
            Assert.AreEqual(9, quicksorter.SortedCopy[6]);
        }

        private void PopulateAndSort(Quicksorter<int> quicksorter)
        {
            quicksorter.Add(4);
            quicksorter.Add(5);
            quicksorter.Add(8);
            quicksorter.Add(6);
            quicksorter.Add(3);
            quicksorter.Add(7);
            quicksorter.Add(9);
            quicksorter.Sort();
        }
    }
}
