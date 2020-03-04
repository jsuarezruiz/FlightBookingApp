using System.Collections.Generic;

namespace FlightBookingApp.Models
{
    public class FlightBooking
    {
        public string AirlineIcon { get; set; }
        public string AirlineName { get; set; }
        public string Price { get; set; }
        public List<Flight> Flights { get; set; }
    }
}
