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
            object _in;
            switch(imaginaryNumber)
            {
                case 1:
                    _in = string.Empty;
                    break;
                case -1:
                    _in = "-";
                    break;
                default:
                    _in = imaginaryNumber;
                    break;
            }

            return String.Format("{0}i", _in);
        }
    }
}
