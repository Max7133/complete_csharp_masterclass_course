using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_inheritance_and_oop
{
    /////////////////////////////////////////////////////////////////////// INTERFACES ///////////////////////////////////////////////////////////////////////////////////
    // IEquatable
    class Ticket : IEquatable<Ticket>  // comparing of Object type Ticket
    {
        // property to store the duration of the ticket in hours
        public int DurationInHours { get; set; }
        // simple constructor
        public Ticket(int durationInHours)
        {
            DurationInHours = durationInHours;
        }

        // Returns a Boolean that will check if whatever Ticket I'm passing, which will be the other ticket, is going to be the same as the Ticket, that is the one that calls this Method.
        public bool Equals(Ticket other)
        { 
        return this.DurationInHours == other.DurationInHours;
        }
    }
}
