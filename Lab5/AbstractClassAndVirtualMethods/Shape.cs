namespace Lab5.AbstractClassAndVirtualMethods
{
    public abstract class Shape
    {
        public virtual double Area => double.NaN;

        public virtual double Perimeter => double.NaN;
        
        public override string ToString() => GetType().Name;
        
        public static double GetArea(Shape shape) => shape.Area;

        public static double GetPerimeter(Shape shape) => shape.Perimeter;
    }
}