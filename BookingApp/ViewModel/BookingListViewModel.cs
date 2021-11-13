using BookingApp.Model;
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
        private readonly ObservableCollection<BookingViewModel> _booking;

        public IEnumerable<BookingViewModel> Bookings => _booking;
        public ICommand MakeBookingCommand { get; }

        public BookingListViewModel()
        {
            _booking = new ObservableCollection<BookingViewModel>();

            _booking.Add(new BookingViewModel(new Booking(new Passenger("Dino", 10, DateTime.Now, "Siquijor"))));
        }
    }
}
