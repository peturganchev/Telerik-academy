﻿using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int divisible = 0;
        for (int i = n + 1; i < m; i++)
        {
            if (i % 5 == 0)
            {
                divisible = divisible + 1;
            }
        }
        Console.WriteLine(divisible);
    }
}

