using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double sqrtpart = b * b - 4 * a * c;

            if ((b * b) < (4 * a * c))
            {
                Console.WriteLine("no real roots");
            }
            else
            {
                double answer1 = (-b + Math.Sqrt(sqrtpart)) / (2 * a);
                double answer2 = (-b - Math.Sqrt(sqrtpart)) / (2 * a);
                if (answer1 < answer2)
                {
                    Console.WriteLine("{0:F2}", answer1);
                    Console.WriteLine("{0:F2}", answer2);
                }
                else if (answer1 == answer2)
                {
                    Console.WriteLine("{0:F2}", answer1);
                }
                else
                {
                    Console.WriteLine("{0:F2}", answer2);
                    Console.WriteLine("{0:F2}", answer1);
                }
            }
        }
    }
}