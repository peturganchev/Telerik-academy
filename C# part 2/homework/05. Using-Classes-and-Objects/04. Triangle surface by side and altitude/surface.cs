using System;

class surface
{
    static void Main()
    {
        double sideLength = double.Parse(Console.ReadLine());
        double altitudeLegth = double.Parse(Console.ReadLine());
        double surface = (sideLength * altitudeLegth) / 2;
        Console.WriteLine("{0:F2}", surface);
    }
}