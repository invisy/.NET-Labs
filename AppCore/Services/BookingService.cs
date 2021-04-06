using System;
using System.Collections.Generic;
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
            plane1++; // Add new seat to the plane
            
            Plane plane2 = new Plane("Plane2", "Model2", 10);
            _planes.Add(plane1);
            _planes.Add(plane2);
            
            City city1 = new City("City1");
            City city2 = new City();
            city2.Name = "City2";
            _cities.Add(city1);
            _cities.Add(city2);
            
            Flight flight1 = new Flight(city1, city2, DateTime.Now, DateTime.Now.AddHours(1), 100, plane1);
            _flights.Add(flight1);

            PlaneSeat seat1 = new PlaneSeat("1A", travelClass1);
            PlaneSeat seat2 = new PlaneSeat("2A", travelClass2);

            flight1.AddSeat(seat1);
            flight1 += seat2; // Add new seat to the flight
            
            Flight flight2 = new Flight(flight1);
            _flights.Add(flight2);
            
            bool arePlacesFree = seat1 & seat2; // Check if two seats are free or not | should be true
            seat1.TicketId = 1;
            arePlacesFree = seat1 & seat2; // Check if two seats are free or not | should be false because seat1 has owner

            Passenger passenger = new Passenger("Pass1", "Surn1", "Patr1", "556465454", 22);
            
            Ticket ticket1 = new Ticket(passenger, 0, flight1);
            Ticket ticket2 = new Ticket(passenger, 1, flight1);
            Ticket ticket3 = new Ticket(passenger, 0, flight1);

            _tickets.Add(ticket1);
            _tickets.Add(ticket2);
            _tickets.Add(ticket3);
            
            bool priceComparison1 = ticket1 > ticket2; // Compare ticket prices
            bool priceComparison2 = ticket1 < ticket3; // Compare ticket prices
            bool priceComparison3 = ticket1 <= ticket3; // Compare ticket prices
        }

        public void BuyTicket(Flight flight, Passenger passenger, int seatId)
        {
            throw new System.NotImplementedException();
        }
        
        public void SearchFlights()
        {
            throw new System.NotImplementedException();
        }
    }
}