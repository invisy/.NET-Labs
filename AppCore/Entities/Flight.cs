using System;
using System.Collections.Generic;

namespace OurAirlines.AppCore.Entities
{
    public class Flight : BaseEntity<int>
    {
        public City departureCity { get; private set; }
        public City incomingCity { get; private set; }
        public DateTime departureDate { get; private set; }
        public DateTime incomingDate { get; private set; }
        public float flightPrice { get; private set; }
        public Plane plane { get; private set; }
        
        private readonly List<PlaneSeat> _seats;
        public IEnumerable<PlaneSeat> Seats => _seats.AsReadOnly();

        public Flight(City departureCity, City incomingCity, DateTime departureDate, DateTime incomingDate, float flightPrice, Plane plane)
        {
            this.departureCity = departureCity;
            this.incomingCity = incomingCity;
            this.departureDate = departureDate;
            this.incomingDate = incomingDate;
            this.flightPrice = flightPrice;
            this.plane = plane;
            _seats = new List<PlaneSeat>();
        }

        public void AddSeat(PlaneSeat seat)
        {
            _seats.Add(seat);
        }
    }
}