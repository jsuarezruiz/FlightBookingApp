using FlightBookingApp.Views;
using Xamarin.Forms;

namespace FlightBookingApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FindFlightsView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
