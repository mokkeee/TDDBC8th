using System;
namespace TDDBC8th
{
    public class ImaginaryNumber
    {
        public readonly int RealPart;
        public readonly int ImaginaryPart;

        public ImaginaryNumber(int realPart, int imaginaryPart)
        {
            if (realPart == 0)
            {
                throw new ArgumentException("実部が0の虚数は生成できません");
            }
            if (imaginaryPart == 0)
            {
                throw new ArgumentException("虚部が０の虚数は生成できません");
            }
            this.RealPart = realPart;
            this.ImaginaryPart = imaginaryPart;
        }
    }
}