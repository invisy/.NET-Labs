using System;

namespace OurAirlines.AppCore.Entities
{
    public class Passenger : BaseEntity<int>
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Patronymic { get; private set; }
        public string UniquePassportId { get; private set; }
        public int Age { get; private set; }

        public Passenger(string name, string surname, string patronymic, string uniquePassportId, int age)
        {
            #if DEBUG
                Console.WriteLine($"'{GetType().Name}' class initializer ctor called");
            #endif

            if (uniquePassportId.Length != 9)
            {
                throw new ArgumentException("Passport id should contain 9 symbols", nameof(uniquePassportId));
            }

            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            UniquePassportId = uniquePassportId;
            Age = age;
        }
    }
}