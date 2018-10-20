using System;
namespace TDDBC8th
{
    public class PurelyImaginaryNumber
    {
        public readonly int imaginaryNumber;

        public PurelyImaginaryNumber(int imaginaryNumber)
        {
            if( imaginaryNumber == 0 )
            {
                throw new ArgumentException("虚数0の純虚数は生成できません");
            }
            this.imaginaryNumber = imaginaryNumber;
        }

        public override string ToString()
        {
            if (imaginaryNumber == 1)
            {
                return "i";
            }
            if (imaginaryNumber == -1)
            {
                return "-i";
            }

            return imaginaryNumber.ToString() + "i";
        }
    }
}
