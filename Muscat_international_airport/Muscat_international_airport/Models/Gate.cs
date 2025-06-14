using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muscat_international_airport.Models
{
    public class Gate
    {
        public int GateID { get; set; } //PK
        public int TerminalID { get; set; } //FK
        public int AirlineID { get; set; } //FK

        public string GateNumber { get; set; }
        public string AvailabilityStatus { get; set; }

        //public Terminal Terminal { get; set; }
        //public Airline Airline { get; set; }
       

    }
}
