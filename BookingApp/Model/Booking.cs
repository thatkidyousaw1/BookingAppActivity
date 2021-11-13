using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Model
{
    public class Booking
    {

        public Passenger passenger { get; }
        public int totalFare { get; }
        public string durationOfTravel { get; }

        public Booking(Passenger passenger, int totalFare, string durationOfTravel)
        {
            this.passenger = passenger;
            this.totalFare = totalFare;
            this.durationOfTravel = durationOfTravel;
        }

    }
}
