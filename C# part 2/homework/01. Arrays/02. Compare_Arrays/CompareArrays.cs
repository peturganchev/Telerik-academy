﻿using System;

class CompareArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n];
        int[] secondArray = new int[n];
        bool Equal = true;
        for (int i = 0; i < n; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                Equal = true;
            }
            else
            {
                Equal = false;
                break;
            }
        }
        if (Equal)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}
