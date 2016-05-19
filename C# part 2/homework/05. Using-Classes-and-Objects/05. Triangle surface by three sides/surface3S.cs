using System;

class Program
{
    static void Main(string[] args)
    {
        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        double side3 = double.Parse(Console.ReadLine());
        double area = AreaOfTriangle(side1, side2, side3);
        Console.WriteLine("{0:F2}", area);
    }
    static double AreaOfTriangle(double side1, double side2, double side3)
    {
        double result = 0;
        double SemiPerimeter = (side1 + side2 + side3) / 2;
        result = Math.Sqrt(SemiPerimeter * (SemiPerimeter - side1) * (SemiPerimeter - side2) * (SemiPerimeter - side3));
        return result;
    }
}