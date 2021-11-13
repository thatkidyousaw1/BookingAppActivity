using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Model
{
    public class Passenger
    {
        public string passengerName { get; }
        public int passengerAge { get; }
        public DateTime dateOfTravel { get; }
        public string destination {  get; }

        public Passenger(string passengerName, int passengerAge, DateTime dateOfTravel, string destination)
        {
            this.passengerName = passengerName;
            this.passengerAge = passengerAge;
            this.dateOfTravel = dateOfTravel;
            this.destination = destination;
        }
    }
}
