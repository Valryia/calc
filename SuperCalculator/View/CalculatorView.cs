using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperCalculator.Model;

namespace SuperCalculator
{
    public partial class CalculatorView : Form
    {
        public CalculatorView()
        {
            InitializeComponent();
        }

        public delegate void SetNumbers(List<BigInteger> numbers);

        public event SetNumbers SetData;

        public delegate void OperationExecuteDelegate(Operation operation);

        public event OperationExecuteDelegate OperationExecuteEvent;

        public delegate void OperationUndoDelegate();

        public event OperationUndoDelegate OperationUndoEvent;

        public delegate void OperationRedoDelegate();

        public event OperationRedoDelegate OperationRedoEvent;

        public delegate void AggregateOperationExecuteDelegate(Operation aggregateOperation);

        public event AggregateOperationExecuteDelegate AggregateOperationExecuteEvent;

        private void enterButton_Click(object sender, EventArgs e)
        {
            string[] strings = dataTextBox.Text.Split(' ');
            List<BigInteger> bigIntegers = strings.Select(numberString => BigInteger.Parse(numberString)).ToList();
            SetData?.Invoke(bigIntegers);
        }

        public void UpdateNumbers(List<BigInteger> numbers)
        {
            data.Text = string.Join(" ", numbers);
        }

        public void UpdateTemporaryOutput(List<BigInteger> numbers)
        {
            data.Text = string.Join(" ", numbers);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            OperationExecuteEvent?.Invoke(new SumOperation(BigInteger.Parse(input.Text)));
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            OperationUndoEvent?.Invoke();
        }

        private void redo_Click(object sender, EventArgs e)
        {
            OperationRedoEvent?.Invoke();
        }

        public void updateAllOperations(BigInteger number)
        {
            allTextBox.Text = number.ToString();
        }

        public void updateCurrentOperation(BigInteger number)
        {
            currentTextBox.Text = number.ToString();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            OperationExecuteEvent?.Invoke(new MinusOperation(BigInteger.Parse(input.Text)));
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void medianButton_Click(object sender, EventArgs e)
        {
            AggregateOperationExecuteEvent?.Invoke(new MedianOperation());
        }

        private void deviationButton_Click(object sender, EventArgs e)
        {
            AggregateOperationExecuteEvent?.Invoke(new StandardDeviationOperation());
        }
    }
}