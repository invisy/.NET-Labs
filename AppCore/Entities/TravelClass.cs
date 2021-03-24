using System;

namespace OurAirlines.AppCore.Entities
{
    public class TravelClass : BaseEntity<int>
    {
        public string Name { get; private set; }
        public float ClassPrice { get; private set; }

        public TravelClass(string name, float classPrice)
        {
            #if DEBUG
                Console.WriteLine($"'{GetType().Name}' class initializer ctor called");
            #endif
            
            Name = name;
            ClassPrice = classPrice;
        }
    }
}