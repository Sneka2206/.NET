using System;

public abstract class Shape
{
    public abstract double CalculateArea();

    public void Display()
    {
        Console.WriteLine("This is a shape.");
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }
    public override double CalculateArea()
    {
        return Length * Width;
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle { Radius = 5 };
        Rectangle rectangle = new Rectangle { Length = 4, Width = 6 };
        Console.WriteLine("Circle Area: " + circle.CalculateArea());
        circle.Display();

        Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
        rectangle.Display();
    }
}
