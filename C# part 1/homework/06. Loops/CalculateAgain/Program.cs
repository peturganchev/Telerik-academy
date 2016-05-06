using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        BigInteger fN = 1;
        BigInteger fK = 1;
        BigInteger result;
        for (uint i = 1; i <= N; i++)
        {
            fN *= i;
            if (K >= i)
            {
                fK *= i;
            }
        }
        result = fN / fK;
        Console.WriteLine(result);
    }
}
