using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace SuperCalculator.Model
{
    public class SumOperation : Operation
    {
        public SumOperation(BigInteger number) : base(number)
        {
        }

        public override List<BigInteger> execute(List<BigInteger> numbers)
        {
            return numbers.Select(number => number + this.number).ToList();
        }

        public override List<BigInteger> undo(List<BigInteger> numbers)
        {
            return numbers.Select(number => number - this.number).ToList();
        }
    }
}