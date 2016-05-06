using System;


class Program
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double a = Math.Sqrt((x-1) * (x-1) + (y-1) * (y-1));
        string circle = "";
        string rectangle = "";
        if (a <= 1.5)
        {
            circle = "inside circle";

        }
        else
        {
            circle = "outside circle";
        }
        if (x >= -1 & x <= 5 & y >= -1 & y <= 1)
        {
            rectangle = "inside rectangle";
        }
        else
        {
            rectangle = "outside rectangle";
        }
        Console.WriteLine("{0} {1}", circle, rectangle);
    }
}

