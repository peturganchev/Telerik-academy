using System;

class Selection_Sort
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        foreach (int num in array)
        {
            Console.WriteLine(num);
        }
    }
}