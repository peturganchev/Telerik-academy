using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = a * b * c;
        if (d > 0)
        {
            Console.WriteLine("+");
        }
        else if (d == 0)
        {
            Console.WriteLine(d);
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}
