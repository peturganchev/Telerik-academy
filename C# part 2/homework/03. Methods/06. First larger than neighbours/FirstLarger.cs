using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.First_larger_than_neighbours
{
    class FirstLarger
    {
        static void Main(string[] args)
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
            int result = -1;
            for (int i = 1; i < length - 1; i++)
            {
                if (array[i] > array[i + 1] && array[i] > array[i - 1])
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
    }
}
