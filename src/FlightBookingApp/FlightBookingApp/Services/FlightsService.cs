using FlightBookingApp.Models;
using System;
using System.Collections.Generic;

namespace FlightBookingApp.Services
{
    public class FlightsService
    {
        static FlightsService _instance;

        public static FlightsService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FlightsService();
                return _instance;
            }
        }

        public List<FlightBooking> FindFlightBooking()
        {
            var flights = new List<FlightBooking>
            {
                new FlightBooking { AirlineIcon = "jetairways.png", AirlineName = "Jet Airways", Price = "$1250", Flights = new List<Flight>
                {
                    new Flight { Departure = "SFO", DepartureTime = "04:55", Duration = "4h 25m", Arrive = "JFK", ArriveTime ="9:10" },
                    new Flight { Departure = "JFK", DepartureTime = "21:45", Duration = "5h 25 min", Arrive = "SFO", ArriveTime ="2:30" }
                } },
                new FlightBooking { AirlineIcon = "flyemirates.png", AirlineName = "Emirates", Price = "$1100", Flights = new List<Flight>
                {
                    new Flight { Departure = "SFO", DepartureTime = "04:55", Duration = "4h 25m", Arrive = "JFK", ArriveTime ="9:10" },
                    new Flight { Departure = "JFK", DepartureTime = "10:45", Duration = "5h 25 min", Arrive = "SFO", ArriveTime ="16:30" }
                } },         
                new FlightBooking { AirlineIcon = "flyemirates.png", AirlineName = "Emirates", Price = "$1200", Flights = new List<Flight>
                {
                    new Flight { Departure = "SFO", DepartureTime = "03:55", Duration = "4h 25m", Arrive = "JFK", ArriveTime ="8:10" },
                    new Flight { Departure = "JFK", DepartureTime = "10:45", Duration = "5h 25 min", Arrive = "SFO", ArriveTime ="16:30" }
                } },
                new FlightBooking { AirlineIcon = "singapore.png", AirlineName = "Singapore Air", Price = "$1050", Flights = new List<Flight>
                {
                    new Flight { Departure = "SFO", DepartureTime = "04:55", Duration = "4h 25m", Arrive = "JFK", ArriveTime ="9:10" },
                    new Flight { Departure = "JFK", DepartureTime = "21:15", Duration = "5h 25 min", Arrive = "SFO", ArriveTime ="2:00" }
                } }
            };

            var rand = new Random();
            int first = rand.Next(flights.Count);
            int second;
            do
            {
               second = rand.Next(flights.Count);
            } while (second == first);
           
            return new List<FlightBooking>
            {
                flights[first],
                flights[second]
            };
        }
    }
}