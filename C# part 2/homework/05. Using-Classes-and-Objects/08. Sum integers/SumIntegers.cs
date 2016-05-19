using System;
using System.Linq;

class SumIntegers
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int sum = sumOfNumbers(array);
        Console.WriteLine(sum);
    }
    static int sumOfNumbers(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
}