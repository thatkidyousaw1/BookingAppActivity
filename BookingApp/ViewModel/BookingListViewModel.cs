using BookingApp.Command;
using BookingApp.Model;
using BookingApp.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BookingApp.ViewModel
{
    public class BookingListViewModel : ViewModelBase
    {
        private readonly TravelCompany _travelcompany;
        private readonly ObservableCollection<BookingViewModel> _booking;

        public IEnumerable<BookingViewModel> Bookings => _booking;
        public ICommand MakeBookingCommand { get; }

        public BookingListViewModel(TravelCompany travelcompany, NavigationService navigationService)
        {
            _travelcompany = travelcompany;

            _booking = new ObservableCollection<BookingViewModel>();

            MakeBookingCommand = new NavigationCommand(navigationService);

            UpdateBooking();
        }

        private void UpdateBooking()
        {
            _booking.Clear();

            foreach(Booking booking in _travelcompany.GetBookings())
            {
                BookingViewModel bookingViewModel = new BookingViewModel(booking);
                _booking.Add(bookingViewModel);
            }
        }
    }
}
