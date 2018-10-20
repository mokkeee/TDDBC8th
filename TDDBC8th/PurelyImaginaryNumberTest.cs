using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
                Assert.AreEqual(1, pin.imaginaryNumber);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void 虚部0の純虚数が生成できないこと()
            {
                new PurelyImaginaryNumber(0);
            }
        }
    } 
}
