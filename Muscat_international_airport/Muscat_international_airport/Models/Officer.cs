using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muscat_international_airport.Models
{
    internal class Officer
    {
        public int OfficerID { get; set; } //PK
        public int CheckpointID { get; set; } //FK

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }


        //public Checkpoint Checkpoint { get; set; }
    }
}
