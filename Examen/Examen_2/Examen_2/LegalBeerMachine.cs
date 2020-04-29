using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2
{
    class LegalBeerMachine : IBeerMachine
    {
        public int Underagers { get; set; }

        public LegalBeerMachine()
        {
            Underagers = 0;
        }

        public bool GetBeer(int years)
        {
            Console.WriteLine("Here's your beer!");
            return true;
        }

        public int GetRaport()
        {
            return Underagers;
        }

        public int ScanID(DateTime birthDate)
        {
            Console.WriteLine("ID scanned");
            int days = (DateTime.Now - birthDate).Days;
            int years = days / 365;
            return years;
        }

        public void AddUnderager()
        {
            Underagers++;
        }
    }
}
