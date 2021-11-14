using BookingApp.Model;
using BookingApp.Stores;
using BookingApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BookingApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly TravelCompany _travelCompany;
        private readonly NavigationStore _navigationStore;
        public App ()
        {
            _travelCompany = new TravelCompany("Dino Da King!");
            _navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = CreateBookingViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }

        private MakeBookingViewModel CreateMakeBookingViewModel()
        {
            return new MakeBookingViewModel(_travelCompany, new Stores.NavigationService(_navigationStore, CreateBookingViewModel));
        }

        private BookingListViewModel CreateBookingViewModel()
        {
            return new BookingListViewModel(_travelCompany, new Stores.NavigationService(_navigationStore,CreateMakeBookingViewModel));
        }
    }
}
