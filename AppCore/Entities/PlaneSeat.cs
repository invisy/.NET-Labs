using System;

namespace OurAirlines.AppCore.Entities
{
    public class PlaneSeat : BaseEntity<int>
    {
        private static int _counter = 0;
        public string Number { get; private set; }
        public TravelClass TravelClass { get; private set; }
        public int? TicketId { get; set; }
        public PlaneSeat(string number, TravelClass travelClass)
        {
            #if DEBUG
                Console.WriteLine($"'{GetType().Name}' class initializer ctor called");
             #endif
            Id = _counter;
            _counter++;
            Number = number;
            TravelClass = travelClass;
        }
        
        public static bool operator &(PlaneSeat seat1, PlaneSeat seat2)
        {
            return seat1.TicketId.HasValue == false && seat2.TicketId.HasValue == false;
        }
    }
}