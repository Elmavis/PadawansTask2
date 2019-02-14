using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            if (count <= 0)
                throw new ArgumentException();
            long sum = number;
            for (long i = 1; i < count; i++)
            {
                long newElem = (long)number + i * (long)add;
                sum += newElem;
            }
            if (sum > Int32.MaxValue || sum < Int32.MinValue)
                throw new OverflowException();

            return (int)sum;
        }
    }
}
