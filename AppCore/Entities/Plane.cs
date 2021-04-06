using System;
using System.Collections.Generic;

namespace OurAirlines.AppCore.Entities
{
    public class Plane : BaseEntity<int>
    {
        public string Name { get; private set; }
        public string Model { get; private set; }
        public int TotalSeats { get; private set; }
        
        private readonly List<TravelClass> _travelClasses;
        public IEnumerable<TravelClass> TravelClasses => _travelClasses.AsReadOnly();

        public Plane(string name, string model, int totalSeats)
        {
            #if DEBUG
                Console.WriteLine($"'{GetType().Name}' class initializer ctor called");
            #endif
            
            _travelClasses = new List<TravelClass>();
            Name = name;
            Model = model;
            TotalSeats = totalSeats;
        }

        public static Plane operator ++(Plane plane)
        {
            plane.TotalSeats += 1;
            return plane;
        }
        
        public void AddTravelClass(TravelClass travelClass)
        {
            _travelClasses.Add(travelClass);
        }
    }
}