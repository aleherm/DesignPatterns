using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Command
{
    interface ICommand
    {
        char ArithmOperator { get; set; }
        double Operand { get; set; }

        void Execute();
    }
}
