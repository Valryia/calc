using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace SuperCalculator.Model
{
    public class StandardDeviationOperation: Operation
    {
        public override List<BigInteger> execute(ref List<BigInteger> numbers)
        {
            return StandardDeviation(numbers);
        }

        public override List<BigInteger> undo(ref List<BigInteger> numbers)
        {
            return numbers;
        }
        
        public List<BigInteger> StandardDeviation(List<BigInteger> numbers)
        {
            List<Double> values = numbers.Select(integer => (Double) integer).ToList();
            Double ret = 0;
            int count = values.Count();
            if (count  > 1)
            {
                Double avg = values.Average();
                Double sum = values.Sum(d => (d - avg) * (d - avg));
                ret = Math.Sqrt(sum / count);
            }
            var bigIntegers = new List<BigInteger>();
            bigIntegers.Add(new BigInteger(ret));
            return bigIntegers;
        }
    }
}