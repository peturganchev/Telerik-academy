using System;
using System.Linq;


class LargerThanNeighbours
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int[] array = Console.ReadLine()
            .Split(' ')
            .Select(z => int.Parse(z))
            .ToArray();
        int result = CheckNeighbours(array, length);
        Console.WriteLine(result);
    }
    static int CheckNeighbours(int[] array, int length)
    {
        int result = 0;
        for (int i = 1; i < length - 1; i++)
        {
            if (array[i] > array[i + 1] && array[i] > array[i - 1])
            {
                result++;
            }
        }
        return result;
    }
}