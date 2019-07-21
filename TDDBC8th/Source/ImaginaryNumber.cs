using System;
namespace TDDBC8th
{
    public class ImaginaryNumber
    {
        public readonly int RealPart;
        public int ImaginaryPart { get { return pin.ImaginaryNumber; }}

        private PurelyImaginaryNumber pin;

        public ImaginaryNumber(int realPart, int imaginaryPart)
        {
            if (realPart == 0)
            {
                throw new ArgumentException("実部が0の虚数は生成できません");
            }
            this.RealPart = realPart;
            this.pin = new PurelyImaginaryNumber(imaginaryPart);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}",
                                 RealPart,
                                 ImaginaryPart > 0 ? '+' : '-',
                                 pin.Abs().ToString());
        }
    }
}