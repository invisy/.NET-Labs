namespace OurAirlines.AppCore.Entities
{
    public class Passenger : BaseEntity<int>
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Patronymic { get; private set; }
        public string UniquePassportId { get; private set; }
        public int Age { get; private set; }

        public Passenger(string name, string surname, string uniquePassportId, string patronymic, int age)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            UniquePassportId = uniquePassportId;
            Age = age;
        }
    }
}