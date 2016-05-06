using System;

class Rectangles
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double p = 2 * a + 2 * b;
        double s = a * b;
        Console.WriteLine("{0:0.00} {1:0.00}", s,p);
    }
    
}
