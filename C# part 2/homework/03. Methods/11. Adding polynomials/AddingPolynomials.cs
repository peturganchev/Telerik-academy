using System;
using System.Collections.Generic;
using System.Linq;

class AddingPolynomials
{
    public static int[] Addition(int[] longerPoly, int[] shorterPoly)
    {
        if (longerPoly.Length < shorterPoly.Length)
        {
            return Addition(shorterPoly, longerPoly);
        }

        int[] sumOfPoly = new int[longerPoly.Length];

        for (int i = 0; i < shorterPoly.Length; i++)
        {
            sumOfPoly[i] = longerPoly[i] + shorterPoly[i];
        }

        for (int i = shorterPoly.Length; i < longerPoly.Length; i++)
        {
            sumOfPoly[i] = longerPoly[i];
        }

        return sumOfPoly;
    }

    static void Main()
    {
        Console.ReadLine();
        int[] firstCoef = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondCoef = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] sum = Addition(firstCoef, secondCoef);
        var list = new List<int>();
        for (int i = 0; i < sum.Length; i++)
        {
            list.Add(sum[i]);
        }
        Console.WriteLine(string.Join(" ", list));
    }
}