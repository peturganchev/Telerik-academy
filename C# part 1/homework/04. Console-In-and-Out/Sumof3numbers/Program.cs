using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double a;
        double answer = 0;
        for (int i = 0; i < n; i++)
        {
            a = double.Parse(Console.ReadLine());
            answer = answer + a;
        }
        Console.WriteLine(answer);
    }
}

