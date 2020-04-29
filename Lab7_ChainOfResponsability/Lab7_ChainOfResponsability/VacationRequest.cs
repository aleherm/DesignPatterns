using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_ChainOfResponsability
{
    class VacationRequest
    {
        private static int iLastRequestNumber = 0;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RequestNumber { get; set; }

        public VacationRequest(DateTime startDate, DateTime endDate)
        {
            RequestNumber = ++iLastRequestNumber;
            StartDate = startDate;
            EndDate = endDate;
        }

        public int GetNumberOfDaysOff()
        {
            return (EndDate - StartDate).Days;
        }
    }
}
