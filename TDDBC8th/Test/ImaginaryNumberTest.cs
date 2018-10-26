using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDBC8th.Test
{
    [TestClass]
    public class 虚数Test
    {
        [TestClass]
        public class 虚数の生成と文字列表記の取得
        {
            [DataTestMethod]
            [DataRow(1, -1)]
            [DataRow(-1, 1)]
            public void 虚数が生成できること(int realPart, int imaginaryPart)
            {
                var im = new ImaginaryNumber(realPart, imaginaryPart);
                Assert.AreEqual(realPart, im.RealPart);
                Assert.AreEqual(imaginaryPart, im.ImaginaryPart);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void 実部0の虚数を生成できないこと()
            {
                new ImaginaryNumber(0, 1);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void 虚部0の虚数を生成できないこと()
            {
                new ImaginaryNumber(1, 0);
            }
        }
    }
}
