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
            for (int i = 1; i < count; i++)
            {
                int newElem = number + i * add;
                sum += newElem;
            }
            if (sum > Int32.MaxValue)
                throw new OverflowException();

            return sum;
        }
    }
}
