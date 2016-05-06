using System;
using System.Numerics;
class Catalan
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int n2 = 2*N;
        int n1 = N + 1;
        BigInteger fN = 1;
        BigInteger fN1 = 1;
        BigInteger fN2 = 1;
        BigInteger result;
        for (uint i = 1; i <= n2; i++)
        {
            fN2 *= i;
            if (n1 >= i)
            {
                fN1 *= i;
            }
            if (N >= i)
            {
                fN *= i;
            }

        }
        result = fN2 / (fN1 * fN);
        Console.WriteLine(result);
    }
}
