using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http.Headers;

namespace TDDBC8th
{
    [TestClass]
    public class 純虚数Test
    {
        [TestClass]
        public class 純虚数の生成
        {
            [TestMethod]
            public void 虚部１の純虚数が生成できること()
            {
                var pin = new PurelyImaginaryNumber(1);
                Assert.AreEqual(1, pin.ImaginaryNumber);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void 虚部0の純虚数が生成できないこと()
            {
                new PurelyImaginaryNumber(0);
            }

            [TestMethod]
            [ExpectedException(typeof(NotSupportedException))]
            public void 虚部がIntMinの純虚数は生成できないこと()
            {
                new PurelyImaginaryNumber(int.MinValue);
            }
        }

        [TestClass]
        public class 生成した純虚数の文字列表記
        {
            [DataTestMethod]
            [DataRow(2, "2i")]
            [DataRow(-2, "-2i")]
            [DataRow(1, "i")]
            [DataRow(-1, "-i")]
            public void 純虚数の文字列表記が合っていること(int input, string expected)
            {
                var pin = new PurelyImaginaryNumber(input);
                Assert.AreEqual(expected, pin.ToString());
            }
        }

        [TestClass]
        public class 同一性の判定
        {
            [DataTestMethod]
            [DataRow(1, 1, true)]
            [DataRow(1, -1, false)]
            [DataRow(1, 2, false)]
            public void 虚部が同じ純虚数を同一と判定しそれ以外は異なると判定すること(int input1, int input2, bool expected)
            {
                var pin1 = new PurelyImaginaryNumber(input1);
                var pin2 = new PurelyImaginaryNumber(input2);

                Assert.AreEqual(expected, pin1.Equals(pin2));
            }

            [DataTestMethod]
            [DataRow(null)]
            [DataRow("1i")]
            [DataRow(1)]
            public void 純虚数と純虚数以外のオブジェクト比較がfalseとなること(object other)
            {
                var pin = new PurelyImaginaryNumber(1);
                Assert.IsFalse(pin.Equals(other));
            }

            [TestMethod]
            public void 虚部が同一の純虚数のハッシュコードが一致すること()
            {
                var pin = new PurelyImaginaryNumber(-1);
                var other = new PurelyImaginaryNumber(-1);
                Assert.AreEqual(pin.GetHashCode(), other.GetHashCode());
            }
        }

        [TestClass]
        public class 共役の取得
        {
            [DataTestMethod]
            [DataRow(1, -1)]
            [DataRow(-1, 1)]
            [DataRow(int.MaxValue, -int.MaxValue)]
            [DataRow(-int.MaxValue, int.MaxValue)]
            public void 共役が取得できること(int input, int expected)
            {
                var pin = new PurelyImaginaryNumber(input);
                var conjugate = new PurelyImaginaryNumber(expected);

                Assert.AreEqual(conjugate, pin.GetConjugate());
            }
        }
    } 
}
