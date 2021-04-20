namespace Lab5.BaseAndDerivedClasses
{
    public class Student : Person
    {
        public string Faculty { get; set; }
        public Student(string name, string faculty) : base(name)
        {
            Faculty = faculty;
        }
    }
}