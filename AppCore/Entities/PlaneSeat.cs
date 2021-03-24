using System;

namespace OurAirlines.AppCore.Entities
{
    public class PlaneSeat : BaseEntity<int>
    {
        public string Number { get; private set; }
        public int TravelClassId { get; private set; }
        public int TicketId { get; set; }

        public PlaneSeat(string number, int travelClassId)
        {
            #if DEBUG
                Console.WriteLine($"'{GetType().Name}' class initializer ctor called");
             #endif
            
            Number = number;
            TravelClassId = travelClassId;
        }
    }
}