using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muscat_international_airport.Models
{
    internal class Checkpoint
    {
        public int CheckpointID { get; set; } //PK
        public int TerminalID { get; set; } //FK

        public string Name { get; set; }
        public int PassengerCapacity { get; set; }
        public string Location { get; set; }

        //public Terminal Terminal { get; set; }
        //public ICollection<Officer> Officers { get; set; }
    }
}
