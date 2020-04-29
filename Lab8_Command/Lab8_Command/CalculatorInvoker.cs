using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Command
{
    class CalculatorInvoker
    {
        public ICommand Command { get; set; }

        public CalculatorInvoker(ICommand command)
        {
            Command = command;
        }

        public void Compute(char operation, double operand)
        {
            Command.ArithmOperator = operation;
            Command.Operand = operand;
            Command.Execute();
        }
    }
}
