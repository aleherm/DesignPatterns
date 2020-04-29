using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Visitor
{
    /// <summary>
    /// The 'Element' abstract class
    /// </summary>

    abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
