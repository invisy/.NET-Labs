using System;
using System.Collections.Generic;
using AppCore.Exceptions;
using OurAirlines.AppCore.Entities;

namespace AppCore.Services
{
    public class BookingService
    {
        private List<Plane> _planes;
        private List<City> _cities;
        private List<Flight> _flights;
        private List<Ticket> _tickets;
        private List<TravelClass> _travelClasses;

        public BookingService()
        {
            #if DEBUG
                Console.WriteLine($"'{GetType().Name}' class default ctor called");
            #endif
            
            _planes = new List<Plane>();
            _cities = new List<City>();
            _flights = new List<Flight>();
            _tickets = new List<Ticket>();
            _travelClasses = new List<TravelClass>();

            TravelClass travelClass1 = new TravelClass("First", 50);
            TravelClass travelClass2 = new TravelClass("Eco", 5);
            
            _travelClasses.Add(travelClass1);
            _travelClasses.Add(travelClass2);
            
            Plane plane1 = new Plane("Plane1", "Model1", 5);
            Plane plane2 = new Plane("Plane2", "Model2", 10);
            _planes.Add(plane1);
            _planes.Add(plane2);
            
            City city1 = new City("City1");
            City city2 = new City();
            city2.Name = "City2";
            _cities.Add(city1);
            _cities.Add(city2);
            
            Flight flight1 = new Flight(city1, city2, DateTime.Now, DateTime.Now.AddHours(1), 100, plane1);
            Flight flight2 = new Flight(flight1);
            _flights.Add(flight1);
            _flights.Add(flight2);

            PlaneSeat seat1 = new PlaneSeat("1A", 1);
            flight1.AddSeat(seat1);

            Passenger passenger = new Passenger("Pass1", "Surn1", "Patr1", "000303050", 22);
            
            Ticket ticket = new Ticket(passenger, 3, 550);
            
            _tickets.Add(ticket);
        }

        public void BuyTicket(Flight flight, Passenger passenger, int seatId)
        {
            float ticketPrice = flight.FlightPrice;
            string passengerFullName = passenger.Surname + " " + passenger.Name;

            if (seatId < 1 || seatId > flight.Plane.TotalSeats)
            {
                throw new PlaneSeatIdOutOfRangeException("Plane seat id was out of range");
            }

            Ticket ticketToAdd = new Ticket(passenger, seatId, ticketPrice);
            _tickets.Add(ticketToAdd);

            Console.WriteLine("Ticket for passenger " + passengerFullName + " was bought.");
        }

        public Flight GetFlightById(int flightId)
        {
            if (flightId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(flightId), "flight id can't be negative number");
            }

            var flight = _flights.Find(x => x.Id == flightId);
            return flight;
        }

        public void SearchFlights()
        {
            throw new System.NotImplementedException();
        }
    }
}