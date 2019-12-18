using System;
using System.Collections.Generic;
using System.Numerics;

namespace SuperCalculator.Model
{
    public class LogOperation : Operation
    {
        public LogOperation(BigInteger number) : base(number)
        {
        }

        public override List<BigInteger> execute(ref List<BigInteger> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = (BigInteger) Math.Log((double) numbers[i], (double) number);
            }

            return numbers;
        }

        public override List<BigInteger> undo(ref List<BigInteger> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = (BigInteger) Math.Pow((double) number, (double) numbers[i]);
            }

            return numbers;
        }
    }
}