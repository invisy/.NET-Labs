using System;

namespace Lab5.BaseAndDerivedClasses
{
    public class Person
    {
        public string Name { get;  set; }
     
        public Person(string name)
        {
            Name = name;
        }
     
        public void Display()
        {
            Console.WriteLine(Name);
        }
    }
}