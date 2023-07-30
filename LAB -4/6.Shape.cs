using System;

public interface Shape
{
     double Circle(double radius);
     double Triangle(double h, double b);
     double Square(double l);
}

public class ImplementDemo : Shape
{
    public double Circle(double radius)
    {
        return 3.14 * radius * radius;
    }
    public double Triangle(double h, double b)
    {
        return 0.5 * h * b;
    }
    public double Square(double l)
    {
        return l * l;
    }
}

public class InterfaceDemo
{
    public static void Main(String[] args)
    {
        ImplementDemo obj = new ImplementDemo();
        Console.WriteLine("Area of circle = " + obj.Circle(10));
        Console.WriteLine("Area of triangle = " + obj.Triangle(15, 10));
        Console.WriteLine("Area of Square = " + obj.Square(20));

        Console.ReadLine();
    }
}
