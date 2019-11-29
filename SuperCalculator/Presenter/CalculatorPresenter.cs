using System.Collections.Generic;
using System.Numerics;
using SuperCalculator.Model;
using SuperCalculator.Service;

namespace SuperCalculator.Presenter
{
    public class CalculatorPresenter
    {
        private readonly CalculatorView calculatorView;
        private readonly CalculatorService calculatorService;

        public CalculatorPresenter(CalculatorView calculatorView, CalculatorService calculatorService)
        {
            this.calculatorView = calculatorView;
            this.calculatorService = calculatorService;

            calculatorView.SetData += SetNumbers;
            calculatorView.OperationExecuteEvent += ExecuteOperationExecute;
            calculatorView.OperationRedoEvent += Redo;
            calculatorView.OperationUndoEvent += Undo;
            calculatorView.AggregateOperationExecuteEvent += ExecuteAggregateOperationExecute;
        }
        
        private void ExecuteAggregateOperationExecute(Operation operation)
        {
            List<BigInteger> numbers = calculatorService.Execute(operation);
            calculatorView.UpdateTemporaryOutput(numbers);
            calculatorView.updateAllOperations(calculatorService.GetAllOperationsCount());
            calculatorView.updateCurrentOperation(calculatorService.GetCurrentOperation());
        }

        private void Undo()
        {
            List<BigInteger> numbers = calculatorService.Undo();
            calculatorView.UpdateNumbers(numbers);
            calculatorView.updateAllOperations(calculatorService.GetAllOperationsCount());
            calculatorView.updateCurrentOperation(calculatorService.GetCurrentOperation());
        }
        
        private void Redo()
        {
            List<BigInteger> numbers = calculatorService.Redo();
            calculatorView.UpdateNumbers(numbers);
            calculatorView.updateAllOperations(calculatorService.GetAllOperationsCount());
            calculatorView.updateCurrentOperation(calculatorService.GetCurrentOperation());
        }

        private void SetNumbers(List<BigInteger> numbers)
        {
            calculatorService.SetData(numbers);
            calculatorView.UpdateNumbers(numbers);
        }

        private void ExecuteOperationExecute(Operation operation)
        {
            List<BigInteger> numbers = calculatorService.Execute(operation);
            calculatorView.UpdateNumbers(numbers);
            calculatorView.updateAllOperations(calculatorService.GetAllOperationsCount());
            calculatorView.updateCurrentOperation(calculatorService.GetCurrentOperation());
        }
    }
}