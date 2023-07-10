using System;

public class Area
{
    public double Area(double x)
    {
        return x * x;
    }

    public double Area(double l, double b)
    {
        return l * b;
    }
}

public class Program
{
    public static void Main()
    {
        Area area = new Area();
        Console.WriteLine(area.Area(10));
        Console.WriteLine(area.Area(3, 4));
    }
}

