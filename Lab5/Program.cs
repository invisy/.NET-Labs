using System;
using Lab5.AbstractClassAndVirtualMethods;
using Lab5.BaseAndDerivedClasses;
using Lab5.Interfaces;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---1---Base and derived classes");

            Person p = new Person("Roman");
            p.Display();

            Student emp = new Student("Ruslan", "FICT");
            emp.Display();

            Console.WriteLine("\n---2---Abstract class and virtual methods");
            Shape[] shapes = {new Rectangle(10, 12), new Square(5)};

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape}: Area: {Shape.GetArea(shape)}; " +
                                  $"Perimeter: {Shape.GetPerimeter(shape)}");

            }

            Console.WriteLine("\n---3---Upcast and downcast");
            Console.WriteLine("---downcast---");
            foreach (Shape shape in shapes)
            {
                if (shape is Rectangle rect) // downcast
                {
                    Console.WriteLine($"Is Square: {rect.IsSquare()}, Diagonal: {rect.Diagonal}");
                    continue;
                }

                if (shape is Square square)
                {
                    Console.WriteLine($"Diagonal: {square.Diagonal}");
                }
            }
            
            Console.WriteLine("---upcast---");
            Student newStudent = new Student("Ivan", "FICT");
            
            Person person = newStudent;
            Console.WriteLine("person.Faculty will not compile");
            Console.WriteLine($"Name: {person.Name}");
            
            Console.WriteLine("\n---4---Interfaces");
            IDrawable drawableShape;  
            drawableShape = new Rectangle(7, 5);
            drawableShape.Draw();  
            drawableShape = new Square(10);  
            drawableShape.Draw(); 
            
        }
    }
}