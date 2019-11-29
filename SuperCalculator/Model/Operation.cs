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

        protected Operation()
        {
        }

        public abstract List<BigInteger> execute(ref List<BigInteger> numbers);
        public abstract List<BigInteger> undo(ref List<BigInteger> numbers);
    }
}