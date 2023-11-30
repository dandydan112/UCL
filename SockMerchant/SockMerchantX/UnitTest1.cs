using Microsoft.VisualStudio.TestPlatform.TestHost;
using Program = SockMerchant.Program;

namespace SockMerchantX
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SockMerchantTest1()
        {
            int[] arr = { 10, 10, 20, 20, 30, 30, 40, 40, 50 };
            Assert.AreEqual(4, Program.SockMerchant(arr));
        }

        [TestMethod]
        public void SockMerchantTest2()
        {
            int[] arr = { 40, 20, 10, 20, 30, 40, 40, 30, 40 };
            Assert.AreEqual(4, Program.SockMerchant(arr));
        }

        [TestMethod]
        public void SockMerchantTest3()
        {
            int[] arr = { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3, 1, 3, 4, 5, 4, 3, 7, 5, 4, 9, 1, 2 };
            Assert.AreEqual(9, Program.SockMerchant(arr));
        }

        [TestMethod]
        public void CandleBlower1()
        {
            int[] arr = { 1, 1, 2, 2, 3, 4, 4 };
            Assert.AreEqual(2, Program.CandleBlower(arr));
        }

        [TestMethod]
        public void CandleBlower2()
        {
            int[] arr = { 5, 2, 1, 5, 3, 4, 3 };
            Assert.AreEqual(2, Program.CandleBlower(arr));
        }

        [TestMethod]
        public void CandleBlower3()
        {
            int[] arr = { 2, 6, 5, 2, 8, 3, 4, 7, 9, 2, 5, 6, 8, 9, 1, 4, 5, 6, 9, 2, 4, 8, 7 };
            Assert.AreEqual(3, Program.CandleBlower(arr));
        }

    }
}