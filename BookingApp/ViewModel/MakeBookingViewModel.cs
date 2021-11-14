using BookingApp.Command;
using BookingApp.Model;
using BookingApp.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BookingApp.ViewModel
{
    public class MakeBookingViewModel : ViewModelBase
    {
        private string _passengerName;
        public string PassengerName
        {
            get
            {
                return _passengerName;
            }
            set
            {
                _passengerName = value;
                OnPropertyChanged(nameof(PassengerName));
            }
        }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        private DateTime _dateOfTravel = new DateTime(2021, 11, 20);
        public DateTime DateOfTravel
        {
            get
            {
                return _dateOfTravel;
            }
            set
            {
                _dateOfTravel = value;
                OnPropertyChanged(nameof(DateOfTravel));
            }
        }

        private string _destination;
        public string Destination
        {
            get
            {
                return _destination;
            }
            set
            {
                _destination = value;
                OnPropertyChanged(nameof(Destination));
            }
        }

        public ICommand AddBooking { get; }
        public ICommand CancelBooking { get; }
        public MakeBookingViewModel(TravelCompany travelCompany, NavigationService navigationService)
        {
            AddBooking = new MakeBookingCommand(this, travelCompany, navigationService);
            CancelBooking = new NavigationCommand(navigationService);
        }
    }
}
