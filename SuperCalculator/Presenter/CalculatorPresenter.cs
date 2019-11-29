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
            calculatorView.OperationExecuteEvent += ExecuteOperationExecute; // подписываем функцию ExecuteOperationExecute на событие выполнения операции
            calculatorView.OperationRedoEvent += Redo;
            calculatorView.OperationUndoEvent += Undo;
        }

        private void Undo()
        {
            List<BigInteger> numbers = calculatorService.Undo();
            calculatorService.SetData(numbers);
            calculatorView.UpdateNumbers(numbers);
            calculatorView.updateAllOperations(calculatorService.GetAllOperationsCount());
            calculatorView.updateCurrentOperation(calculatorService.GetCurrentOperation());
        }
        
        private void Redo()
        {
            List<BigInteger> numbers = calculatorService.Redo();
            calculatorService.SetData(numbers);
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
            List<BigInteger> numbers = calculatorService.Execute(operation); // вызов функции выполнить операцию в сервисе
            calculatorService.SetData(numbers);
            calculatorView.UpdateNumbers(numbers); // обновление данных
            calculatorView.updateAllOperations(calculatorService.GetAllOperationsCount());// обновление кол-ва операций
            calculatorView.updateCurrentOperation(calculatorService.GetCurrentOperation());// обновление кол-ва операций
        }
    }
}