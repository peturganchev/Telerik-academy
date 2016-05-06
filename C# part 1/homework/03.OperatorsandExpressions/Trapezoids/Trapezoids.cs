using System;


class Trapezoids
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double s = ((a + b) / 2) * h;
        Console.WriteLine("{0:0.0000000}", s);
    }
}

