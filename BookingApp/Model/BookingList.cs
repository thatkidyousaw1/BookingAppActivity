using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Model
{
    public class BookingList
    {
        private readonly List<Booking> _bookings = new List<Booking>();
        
        public BookingList()
        {
            _bookings = new List<Booking>(); 
        }

        public IEnumerable<Booking> GetBookings ()
        {
            return _bookings;
        }

        public void AddBooking(Booking booking)
        {
            _bookings.Add(booking);
        }
    }
}
