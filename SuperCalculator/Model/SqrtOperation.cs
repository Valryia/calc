using System;
using System.Collections.Generic;
using System.Numerics;

namespace SuperCalculator.Model
{
    public class SqrtOperation : Operation
    {
        public SqrtOperation(BigInteger number) : base(number)
        {
        }
     
        public override List<BigInteger> execute(ref List<BigInteger> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = (BigInteger) Math.Sqrt((double) numbers[i]);
            }
     
            return numbers;
        }
     
        public override List<BigInteger> undo(ref List<BigInteger> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = (BigInteger) Math.Pow((double) numbers[i], 2);
            }
     
            return numbers;
        }
    }
}