using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Interpreter
{
    class Context
    {
        // Constructor
        public Context(string input)
        {
            Input = input;
        }

        // Gets or sets input
        public string Input { get; set; }

        // Gets or sets output
        public int Output { get; set; }
    }
}
