using System.Collections.Generic;
using System.Numerics;
using SuperCalculator.Model;

namespace SuperCalculator.Service
{
    public class CalculatorService
    {
        List<BigInteger> numbers = new List<BigInteger>();

        private Stack<Operation> executedOperations = new Stack<Operation>(); // выполненные операции
        private Stack<Operation> expectedOperations = new Stack<Operation>(); // невыполненные операции

        public void SetData(List<BigInteger> bigIntegers)
        {
            numbers = bigIntegers;
        }

        public List<BigInteger> Execute(Operation operation)
        {
            executedOperations.Push(operation); // ложим операцию в выполненные
            return operation.execute(numbers); // выполняем операцию
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
            return operation.undo(numbers);
        }

        public List<BigInteger> Redo()
        {
            Operation operation = expectedOperations.Pop();
            executedOperations.Push(operation);
            return operation.execute(numbers);
        }
    }
}