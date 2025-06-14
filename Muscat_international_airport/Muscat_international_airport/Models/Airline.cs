using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muscat_international_airport.Models
{
    public class Airline
    {

        public int AirlineID { get; set; } //PK
        public string Name { get; set; }   
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public string RepresentativeName { get; set; }

        //public ICollection<Flight> Flights { get; set; }


    }
}
