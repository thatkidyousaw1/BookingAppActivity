using BookingApp.Model;
using BookingApp.Stores;
using BookingApp.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookingApp.Command
{
    public class MakeBookingCommand : CommandBase
    {
        private readonly MakeBookingViewModel _makeBookingViewModel;
        private readonly TravelCompany _travelCompany;
        private readonly NavigationService navigationService;

        public MakeBookingCommand(MakeBookingViewModel makeBookingViewModel, TravelCompany travelCompany, NavigationService navigationService)
        {
            _makeBookingViewModel = makeBookingViewModel;
            _travelCompany = travelCompany;
            this.navigationService = navigationService;
            _makeBookingViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_makeBookingViewModel.PassengerName) && !string.IsNullOrEmpty(_makeBookingViewModel.Destination) && _makeBookingViewModel.Age > 0
                && base.CanExecute(parameter);
        }
        public override void Execute(object? parameter)
        {
            Booking booking = new Booking(
                new Passenger(_makeBookingViewModel.PassengerName, _makeBookingViewModel.Age, _makeBookingViewModel.DateOfTravel, _makeBookingViewModel.Destination));

            _travelCompany.AddBooking(booking);
            MessageBox.Show("Successfully added booking!", "Success",
                MessageBoxButton.OK, MessageBoxImage.Information);

            navigationService.Navigate();
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(MakeBookingViewModel.PassengerName) || e.PropertyName == nameof(MakeBookingViewModel.Age)
                || e.PropertyName == nameof(MakeBookingViewModel.Destination))
            {
                OnExecutedChanged();
            }
        }
    }
}
