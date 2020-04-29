using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Command
{
    class Calculator
    {
        private double currentValue;

        public Calculator()
        {
            currentValue = 0;
        }

        public void DoOperation(char operation, double operand)
        {
            double firstOperand = currentValue;
            switch(operation)
            {
                case '+':
                    currentValue = currentValue + operand;
                    break;
                case '-':
                    currentValue = currentValue - operand;
                    break;
                case '/':
                    if (operand == 0)
                    {
                        Console.WriteLine("Cannot divide by 0!");
                        return;
                    }
                    else
                        currentValue = currentValue / operand;
                    break;
                case '%':
                    if (operand == 0)
                    {
                        Console.WriteLine("Cannot divide by 0!");
                        return;
                    }
                    else
                        currentValue = currentValue % operand;
                    break;
                default:
                    Console.WriteLine(operation + " is not a known operation!");
                    return;
            }

            Console.WriteLine(firstOperand.ToString() + operation + operand.ToString() + " = " + currentValue);
        }
    }
}
