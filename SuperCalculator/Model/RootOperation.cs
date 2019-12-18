﻿using System;
using System.Collections.Generic;
using System.Numerics;

namespace SuperCalculator.Model
{
    public class RootOperation : Operation
    {
        public RootOperation(BigInteger number) : base(number)
        {
        }

        public override List<BigInteger> execute(ref List<BigInteger> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = (BigInteger) Math.Pow((double) numbers[i], -(double) number);
            }

            return numbers;
        }

        public override List<BigInteger> undo(ref List<BigInteger> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = (BigInteger) Math.Pow((double) numbers[i], (double) number);
            }

            return numbers;
        }
    }
}