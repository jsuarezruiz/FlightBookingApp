using FlightBookingApp.Models;
using FlightBookingApp.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace FlightBookingApp.ViewModels
{
    public class FindFlightsViewModel : BindableObject
    {
        ObservableCollection<FlightBooking> _booking;

        public FindFlightsViewModel()
        {
            FindFlightBooking();
        }

        public ObservableCollection<FlightBooking> Booking
        {
            get { return _booking; }
            set
            {
                _booking = value;
                OnPropertyChanged();
            }
        }

        public ICommand RefreshCommand => new Command(OnRefresh);

        void FindFlightBooking()
        {
            var booking = FlightsService.Instance.FindFlightBooking();
            Booking = new ObservableCollection<FlightBooking>(booking);
        }

        void OnRefresh()
        {
            FindFlightBooking();
        }
    }
}
