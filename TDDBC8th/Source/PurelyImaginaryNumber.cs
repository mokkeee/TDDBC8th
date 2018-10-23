using System;
namespace TDDBC8th
{
    public class PurelyImaginaryNumber
    {
        public readonly int ImaginaryNumber;

        public PurelyImaginaryNumber(int imaginaryNumber)
        {
            if( imaginaryNumber == 0 )
            {
                throw new ArgumentException("虚数0の純虚数は生成できません");
            }
            // 共役が取得できないので虚数int.MinValueはサポートしないß
            if( imaginaryNumber == int.MinValue)
            {
                throw new NotSupportedException("虚数" + int.MinValue + "の純虚数はサポートしていません");
            }
            this.ImaginaryNumber = imaginaryNumber;
        }

        public override string ToString()
        {
            switch(ImaginaryNumber)
            {
                case 1:
                    return "i";
                case -1:
                    return "-i";
                default:
                    return String.Format("{0}i", ImaginaryNumber);
            }
        }

        public override bool Equals(object obj)
        {
            return (obj is PurelyImaginaryNumber other) && this.ImaginaryNumber == other.ImaginaryNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ImaginaryNumber);
        }

        public PurelyImaginaryNumber GetConjugate()
        {
            return new PurelyImaginaryNumber(-ImaginaryNumber);
        }
    }
}
