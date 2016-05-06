using System;

class ComparingFloats
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double exp = 0.000001;
        if (Math.Abs(a - b) > exp)
        {
            Console.WriteLine((false).ToString().ToLower());
        }
        else
        {
            Console.WriteLine((true).ToString().ToLower());
        }
    }
}
