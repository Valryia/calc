using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace SuperCalculator.Model
{
    public class MedianOperation : Operation
    {
        public override List<BigInteger> execute(ref List<BigInteger> numbers)
        {
            return Median(numbers);
        }

        public override List<BigInteger> undo(ref List<BigInteger> numbers)
        {
            return numbers;
        }

        private List<BigInteger> Median(List<BigInteger> numbers)
        {
            int numberCount = numbers.Count();
            int halfIndex = numbers.Count() / 2;
            var sortedNumbers = numbers.OrderBy(n => n);
            BigInteger median;
            if ((numberCount % 2) == 0)
            {
                median = ((sortedNumbers.ElementAt(halfIndex) +
                           sortedNumbers.ElementAt((halfIndex - 1))) / 2);
            }
            else
            {
                median = sortedNumbers.ElementAt(halfIndex);
            }

            var bigIntegers = new List<BigInteger>();
            bigIntegers.Add(median);
            return bigIntegers;
        }
    }
}