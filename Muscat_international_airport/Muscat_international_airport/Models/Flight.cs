using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Muscat_international_airport.Models
{
    internal class Flight
    {
        public int FlightID { get; set; } //PK
        public int AirlineID { get; set; } //FK
        public int GateID { get; set; } //FK

        public string DepartureCity { get; set; }
        public string DestinationCity { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string Status { get; set; }

        //public Airline Airline { get; set; }
        //public ICollection<Gate> Gates { get; set; }
    }
}
