using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDBC8th.Test
{
    [TestClass]
    public class 虚数Test
    {
        [TestClass]
        public class 虚数の生成
        {
            [DataTestMethod]
            [DataRow(1, -1)]
            [DataRow(-1, 1)]
            public void 虚数が生成できること(int realPart, int imaginaryPart)
            {
                var @in = new ImaginaryNumber(realPart, imaginaryPart);
                Assert.AreEqual(realPart, @in.RealPart);
                Assert.AreEqual(imaginaryPart, @in.ImaginaryPart);
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

        [TestClass]
        public class 文字列表記の取得
        {
            [DataTestMethod]
            [DataRow(1, 2, "1 + 2i")]
            [DataRow(1, -2, "1 - 2i")]
            [DataRow(-1, 1, "-1 + i")]
            [DataRow(-1, -1, "-1 - i")]
            public void 虚数の文字列表記が取得できること(int rp, int ip, string expedted)
            {
                var @in = new ImaginaryNumber(rp, ip);
                Assert.AreEqual(expedted, @in.ToString());
            }

        }
    }
}
