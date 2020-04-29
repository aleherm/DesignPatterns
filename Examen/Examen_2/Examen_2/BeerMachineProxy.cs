using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2
{
    class BeerMachineProxy : IBeerMachine
    {
        private LegalBeerMachine realSubject;

        public BeerMachineProxy()
        {
            realSubject = new LegalBeerMachine();
        }

        public bool GetBeer(int years)
        {
            if (years < 18)
            {
                Console.WriteLine("Too young!!");
                realSubject.AddUnderager();
                return false;
            }
            return realSubject.GetBeer(years);
        }

        public int GetRaport()
        {
            return realSubject.GetRaport();
        }

        public int ScanID(DateTime birthDate)
        {
            return realSubject.ScanID(birthDate);
        }
    }
}
