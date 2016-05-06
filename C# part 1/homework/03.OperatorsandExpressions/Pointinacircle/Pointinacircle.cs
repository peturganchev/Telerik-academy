using System;

class Pointinacircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double a = Math.Sqrt(x * x + y * y);
        if (a <= 2)
        {

            Console.WriteLine("yes {0:0.00}", a);

        }
        else
        {
            Console.WriteLine("no {0:0.00}", a);
        }
    }
}
