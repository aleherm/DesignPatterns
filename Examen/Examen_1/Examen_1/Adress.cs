using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    class Adress
    {
        public string City { get; set; }
        public string Town { get; set; }
        public string PostalCode { get; set; }

        public Adress(string city, string town, string postalCode)
        {
            City = city;
            Town = town;
            PostalCode = postalCode;
        }

        public override string ToString()
        {
            return City + Town + PostalCode;
        }
    }
}
