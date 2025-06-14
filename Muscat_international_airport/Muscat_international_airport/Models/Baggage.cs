using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muscat_international_airport.Models
{
    public class Baggage
    {
        public int BaggageID { get; set; } //PK
        public int PassengerID { get; set; } //FK
        public double Weight { get; set; }
        public string TrackingNumber { get; set; }

        //public Passenger Passenger { get; set; }

    }
}
