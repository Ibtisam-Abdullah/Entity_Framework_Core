using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muscat_international_airport.Models
{
    internal class Terminal
    {
        public int TerminalID { get; set; } //PK
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Location { get; set; }

        //public ICollection<Gate> Gates { get; set; }
        //public ICollection<Checkpoint> Checkpoints { get; set; }
    }
}
