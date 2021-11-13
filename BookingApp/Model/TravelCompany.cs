using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Model
{
    public class TravelCompany
    {
        private readonly BookingList _bookingList;

        public string Name { get; }

        public TravelCompany(string name)
        {
            Name = name;
            _bookingList = new BookingList();
        }

        public IEnumerable<Booking> GetBookings()
        {
            return _bookingList.GetBookings();
        }

        public void AddBooking(Booking booking)
        {
            _bookingList.AddBooking(booking);
        }
    }
}
