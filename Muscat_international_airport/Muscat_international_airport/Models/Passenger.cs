using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muscat_international_airport.Models
{
    internal class Passenger
    {
        public int PassengerID { get; set; } //PK
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string PassportNumber { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }

        //public ICollection<Baggage> BaggageItems { get; set; }
        //public ICollection<PassengerFlight> PassengerFlights { get; set; }
    }
}
