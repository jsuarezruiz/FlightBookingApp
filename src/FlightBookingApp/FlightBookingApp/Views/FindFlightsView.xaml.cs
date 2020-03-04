using FlightBookingApp.ViewModels;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FlightBookingApp.Views
{
    public partial class FindFlightsView : ContentPage
    {
        public FindFlightsView()
        {
            InitializeComponent();
            BindingContext = new FindFlightsViewModel();
        }

        private async void OnSwipeEnded(object sender, SwipeEndedEventArgs e)
        {
            await Task.Delay(1000); // Simulate loading time
            var vm = (FindFlightsViewModel)BindingContext;
            vm.RefreshCommand.Execute(null);
        }
    }
}