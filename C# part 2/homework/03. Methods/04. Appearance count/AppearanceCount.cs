using System;
using System.Linq;

namespace _04.Appearance_count
{
    class AppearanceCount
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(z => int.Parse(z))
                .ToArray();
            int X = int.Parse(Console.ReadLine());
            int result = AppearanceSearcher(array, X, length);
            Console.WriteLine(result);
        }
        static int AppearanceSearcher(int[] array, int X, int length)
        {
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (array[i] == X)
                {
                    count++;
                }
            }
            return count;
        }
    }
}