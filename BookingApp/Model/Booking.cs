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

        public Booking(Passenger passenger)
        {
            this.passenger = passenger;
        }

        public double CalculateFare()
        {
            double fare = 0;

            if(passenger.destination == "Cebu")
            {
                fare = 150 + (150 * .17);
            } else if (passenger.destination == "Siquijor")
            {
                fare = 250 + (250 * .17);
            }
            return fare;
        }

        public string DurationOfTravel()
        {
            string duration = "";

            if(passenger.destination == "Cebu")
            {
                duration = "120 minutes";
            } else if (passenger.destination == "Siquijor")
            {
                duration = "5 hours";
            }

            return duration;
        }
    }
}
