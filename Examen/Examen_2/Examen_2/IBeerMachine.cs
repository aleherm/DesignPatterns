using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2
{
    interface IBeerMachine
    {
        bool GetBeer(int years);
        int ScanID(DateTime birthDate);
        int GetRaport();
    }
}
