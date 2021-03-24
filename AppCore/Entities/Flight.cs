using System;
using System.Collections.Generic;

namespace OurAirlines.AppCore.Entities
{
    public class Flight : BaseEntity<int>
    {
        public City DepartureCity { get; private set; }
        public City IncomingCity { get; private set; }
        public DateTime DepartureDate { get; private set; }
        public DateTime IncomingDate { get; private set; }
        public float FlightPrice { get; private set; }
        public Plane Plane { get; private set; }
        
        private readonly List<PlaneSeat> _seats;
        public IEnumerable<PlaneSeat> Seats => _seats.AsReadOnly();

        public Flight(City departureCity, City incomingCity, DateTime departureDate, DateTime incomingDate, float flightPrice, Plane plane)
        {
            #if DEBUG
                Console.WriteLine($"'{GetType().Name}' class initializer ctor called");
            #endif
            
            this.DepartureCity = departureCity;
            this.IncomingCity = incomingCity;
            this.DepartureDate = departureDate;
            this.IncomingDate = incomingDate;
            this.FlightPrice = flightPrice;
            this.Plane = plane;
            _seats = new List<PlaneSeat>();
        }
        
        public Flight(Flight flight)
        {
            #if DEBUG
                Console.WriteLine($"'{GetType().Name}' class copy ctor called");
            #endif
            
            this.DepartureCity = flight.DepartureCity;
            this.IncomingCity = flight.IncomingCity;
            this.DepartureDate = flight.DepartureDate;
            this.IncomingDate = flight.IncomingDate;
            this.FlightPrice = flight.FlightPrice;
            this.Plane = flight.Plane;
            _seats = new List<PlaneSeat>(flight._seats);
        }

        public void AddSeat(PlaneSeat seat)
        {
            _seats.Add(seat);
        }
    }
}