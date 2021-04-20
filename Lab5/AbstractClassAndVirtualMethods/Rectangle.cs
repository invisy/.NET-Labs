﻿using System;
using Lab5.Interfaces;

namespace Lab5.AbstractClassAndVirtualMethods
{
    public class Rectangle : Shape, IDrawable
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Length { get; }

        public double Width { get; }

        public override double Area => Length * Width;

        public override double Perimeter => 2 * Length + 2 * Width;

        public bool IsSquare() => Length == Width;

        public double Diagonal => Math.Round(Math.Sqrt(Math.Pow(Length, 2) + Math.Pow(Width, 2)), 2);
        
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle...");  
        }
    }
}