using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Command
{
    class CalculatorCommand : ICommand
    {
        private Calculator calculator;

        public char ArithmOperator { get; set; }
        public double Operand { get; set; }

        public CalculatorCommand()
        {
            calculator = new Calculator();
        }

        public void Execute()
        {
            calculator.DoOperation(ArithmOperator, Operand);
        }
    }
}
