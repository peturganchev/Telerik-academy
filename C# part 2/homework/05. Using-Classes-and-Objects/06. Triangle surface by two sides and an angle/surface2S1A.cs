using System;

class surface2S1A
{
    static void Main()
    {
        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());
        double area = AreaOfTriangle(side1, side2, angle);
        Console.WriteLine("{0:F2}", area);
    }
    static double AreaOfTriangle(double side1, double side2, double angle)
    {
        double result = 0;
        double rads = (angle * Math.PI) / 180;
        result = (side1 * side2 * Math.Sin(rads)) / 2;
        return result;
    }
}