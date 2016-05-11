using System;
using System.Linq;
using System.Collections.Generic;
class Remove_elements_from_array
    {
        static void Main()
        {
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        int[] LIS = new int[length];
        int result;
        for (int i = 0; i < length; i++)
        {
            array[i]= int.Parse(Console.ReadLine());
            LIS[i] = 1;
        }
        for (int i = 1; i < array.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[i] >= array[j] & LIS[i]<LIS[j]+1)
                {
                    LIS[i] = LIS[j] + 1;
                }
            }
        }
        
        result = length - LIS.Max();
       Console.WriteLine(result);
        }
    }
