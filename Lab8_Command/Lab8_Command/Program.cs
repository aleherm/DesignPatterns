using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorInvoker invoker = new CalculatorInvoker(new CalculatorCommand());
            invoker.Compute('+', 13);
            invoker.Compute('-', 1);
            invoker.Compute('/', 2);
            invoker.Compute('%', 0);
            invoker.Compute('$', 7);
        }
    }
}
