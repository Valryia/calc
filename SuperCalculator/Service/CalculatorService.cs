using System.Collections.Generic;
using System.Numerics;
using SuperCalculator.Model;

namespace SuperCalculator.Service
{
    public class CalculatorService
    {
        List<BigInteger> numbers = new List<BigInteger>();

        private Stack<Operation> executedOperations = new Stack<Operation>();
        private Stack<Operation> expectedOperations = new Stack<Operation>();

        public void SetData(List<BigInteger> bigIntegers)
        {
            numbers = new List<BigInteger>(bigIntegers);
            executedOperations.Clear();
            expectedOperations.Clear();
        }

        public List<BigInteger> Execute(Operation operation)
        {
            executedOperations.Push(operation);
            return operation.execute(ref numbers);
        }

        public BigInteger GetAllOperationsCount()
        {
            return executedOperations.Count + expectedOperations.Count;
        }

        public BigInteger GetCurrentOperation()
        {
            return executedOperations.Count;
        }

        public List<BigInteger> Undo()
        {
            Operation operation = executedOperations.Pop();
            expectedOperations.Push(operation);
            return operation.undo(ref numbers);
        }

        public List<BigInteger> Redo()
        {
            Operation operation = expectedOperations.Pop();
            executedOperations.Push(operation);
            return operation.execute(ref numbers);
        }
    }
}