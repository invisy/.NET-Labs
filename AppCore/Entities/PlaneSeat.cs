namespace OurAirlines.AppCore.Entities
{
    public class PlaneSeat : BaseEntity<int>
    {
        public string Number { get; private set; }
        public int TravelClassId { get; private set; }
        public int TicketId { get; set; }

        public PlaneSeat(string number, int travelClassId)
        {
            Number = number;
            TravelClassId = travelClassId;
        }
    }
}