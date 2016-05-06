using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        int nk = N - K;
        BigInteger fN = 1;
        BigInteger fK = 1;
        BigInteger fNK = 1;
        BigInteger result;
        for (uint i = 1; i <= N; i++)
        {
            fN *= i;
            if (K >= i)
            {
                fK *= i;
            }
            if (nk>=i)
            {
                fNK *= i;
            }

        }
        result = fN/(fK*fNK);
        Console.WriteLine(result);
    }
}
