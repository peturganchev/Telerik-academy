using System;

class Maximal_Sum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int max_current;
        int max_global;
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        max_current = max_global = array[0];
        for (int i = 1; i < n; i++)
        {
            max_current = Math.Max(array[i], (max_current + array[i]));
            if (max_current > max_global)
            {
                max_global = max_current;
            }
        }
        Console.WriteLine(max_global);
    }
}
