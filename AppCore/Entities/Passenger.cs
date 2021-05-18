using System;
using OurAirlines.AppCore.Entities;

namespace AppCore.Entities
{
    public class Passenger : BaseEntity<int>
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Patronymic { get; private set; }
        public string UniquePassportId { get; private set; }
        public int Age { get; set; }
        public int Rating { get; set; }
        public Passenger() 
        {
        }


        public Passenger(string name, string surname, string patronymic, string uniquePassportId, int age)
        {
            #if DEBUG
                Console.WriteLine($"'{GetType().Name}' class initializer ctor called");
            #endif
            
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            UniquePassportId = uniquePassportId;
            Age = age;
        }
    }
}