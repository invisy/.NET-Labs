using System;
using Lab5.Interfaces;

namespace Lab5.AbstractClassAndVirtualMethods
{
    public class Square : Shape, IDrawable
    {
        public Square(double length)
        {
            Side = length;
        }

        public double Side { get; }

        public override double Area => Math.Pow(Side, 2);

        public override double Perimeter => Side * 4;

        public double Diagonal => Math.Round(Math.Sqrt(2) * Side, 2);
        
        public void Draw()
        {
            Console.WriteLine("Drawing Square...");  
        }
    }
}