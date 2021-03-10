﻿namespace OurAirlines.AppCore.Entities
{
    public class City : BaseEntity<int>
    {
        public string Name { get; set; }

        public City()
        {
            
        }

        public City(string name)
        {
            Name = name;
        }
    }
}