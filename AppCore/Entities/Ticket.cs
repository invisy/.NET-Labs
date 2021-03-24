using System;

namespace OurAirlines.AppCore.Entities
{
    public class Ticket : BaseEntity<int>
    {
        public Passenger Passenger { get; private set; }
        public int SeatNumber { get; private set; }
        public float TotalPrice { get; private set; }

        
        public Ticket(Passenger passenger, int seatNumber)
        {
            #if DEBUG
                Console.WriteLine($"'{GetType().Name}' class initializer ctor called");
            #endif
            
            Passenger = passenger;
            SeatNumber = seatNumber;
            TotalPrice = CalculateTotalPrice();
        }
        public Ticket(Passenger passenger, int seatNumber, float totalPrice)
        {
            #if DEBUG
                Console.WriteLine($"'{GetType().Name}' class initializer ctor called");
            #endif
            
            Passenger = passenger;
            SeatNumber = seatNumber;
            TotalPrice = totalPrice;
        }
        
        private float CalculateTotalPrice()
        {
            throw new System.NotImplementedException();
        }
    }
}