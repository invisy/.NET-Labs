using System;
using System.Linq;

namespace OurAirlines.AppCore.Entities
{
    public class Ticket : BaseEntity<int>
    {
        private Flight _flight;
        public Passenger Passenger { get; private set; }
        public int SeatNumber { get; private set; }
        public float TotalPrice { get; private set; }
        
        public Ticket(Passenger passenger, int seatNumber, Flight flight)
        {
            #if DEBUG
                Console.WriteLine($"'{GetType().Name}' class initializer ctor called");
            #endif
            
            Passenger = passenger;
            SeatNumber = seatNumber;
            _flight = flight;
            TotalPrice = CalculateTotalPrice();
        }
        public Ticket(Passenger passenger, int seatNumber, float totalPrice, Flight flight)
        {
            #if DEBUG
                Console.WriteLine($"'{GetType().Name}' class initializer ctor called");
            #endif
            
            Passenger = passenger;
            SeatNumber = seatNumber;
            TotalPrice = totalPrice;
            _flight = flight;
        }

        private float CalculateTotalPrice()
        {
            float? seatPrice = _flight.Seats.FirstOrDefault(s => s.Id == SeatNumber)?.TravelClass.ClassPrice;
            if (seatPrice == null)
            {
                throw new InvalidOperationException("Seat assigned to this ticket doesn't exist");
            }

            TotalPrice = _flight.FlightPrice + seatPrice.Value;
            return TotalPrice;
        }
        
        public static bool operator >(Ticket ticket1, Ticket ticket2)
        {
            return ticket1.TotalPrice > ticket2.TotalPrice;
        }
        
        public static bool operator <(Ticket ticket1, Ticket ticket2)
        {
            return ticket1.TotalPrice < ticket2.TotalPrice;
        }
        
        public static bool operator >=(Ticket ticket1, Ticket ticket2)
        {
            return ticket1.TotalPrice >= ticket2.TotalPrice;
        }
        
        public static bool operator <=(Ticket ticket1, Ticket ticket2)
        {
            return ticket1.TotalPrice <= ticket2.TotalPrice;
        }
    }
}