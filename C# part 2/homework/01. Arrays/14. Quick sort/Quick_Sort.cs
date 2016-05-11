﻿using System;

class Quick_Sort
{
    public static void Quicksort(int[] elements, int left, int right)
    {
        int i = left, j = right;
        int pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                // Swap
                int tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;

                i++;
                j--;
            }
        }

        // Recursive calls
        if (left < j)
        {
            Quicksort(elements, left, j);
        }

        if (i < right)
        {
            Quicksort(elements, i, right);
        }
    }



    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Quicksort(arr, 0, arr.Length - 1);
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}

