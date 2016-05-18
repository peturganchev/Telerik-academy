using System;
using System.Linq;

class GetLargestNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] array = input
            .Split(' ')
            .Select(z => int.Parse(z))
            .ToArray();
        int larger = GetLarger(array[0], array[1]);
        larger = GetLarger(larger, array[2]);
        Console.WriteLine(larger);
    }
    static int GetLarger(int firstnumber, int secondnumber)
    {
        int larger = Math.Max(firstnumber, secondnumber);
        return larger;
    }
}
