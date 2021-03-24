using System;

namespace OurAirlines.AppCore.Entities
{
    public class City : BaseEntity<int>
    {
        public string Name { get; set; }

        public City()
        {
            #if DEBUG
                Console.WriteLine($"'{GetType().Name}' class default ctor called");
            #endif
        }

        public City(string name)
        {
            #if DEBUG
                Console.WriteLine($"'{GetType().Name}' class initializer ctor called");
            #endif
            Name = name;
        }
    }
}