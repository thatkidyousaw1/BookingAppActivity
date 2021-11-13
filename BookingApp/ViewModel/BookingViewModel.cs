using BookingApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.ViewModel
{
    public class BookingViewModel : ViewModelBase
    {
        public readonly Booking _booking;
        public string PassengerName => _booking.passenger.passengerName;
        public int Age => _booking.passenger.passengerAge;
        public string DateOfTravel => _booking.passenger.dateOfTravel.ToString("d");
        public string Destination => _booking.passenger.destination;
        public double TotalFare => _booking.CalculateFare();
        public string DurationOfTravel => _booking.DurationOfTravel();

        public BookingViewModel(Booking booking)
        {
            _booking = booking;
        }
    }
}
