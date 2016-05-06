using System;
using System.Numerics;
namespace zerosInN_
{
    class Program
    {

        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            long F = 1;
            int count = 0;
            for (uint i = 1; i <= N; i++)
            {
                F *= i;
            }
            while (F % 10 == 0)
            {
                count++;
                F = F / 10;
            }
            Console.WriteLine(count);
        }

    }
}
