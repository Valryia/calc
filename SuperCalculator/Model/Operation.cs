using System.Collections.Generic;
using System.Numerics;

namespace SuperCalculator.Model
{
    public abstract class Operation
    {
        public BigInteger number;

        protected Operation(BigInteger number)
        {
            this.number = number;
        }

        public abstract List<BigInteger> execute(List<BigInteger> numbers);
        public abstract List<BigInteger> undo(List<BigInteger> numbers);
    }
}