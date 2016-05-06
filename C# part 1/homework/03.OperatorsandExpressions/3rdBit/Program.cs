using System;



class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int test = 3;
        int mask = 1 << test;
        int nAndMask = num & mask;  // 00000000 00100000
        int bit = nAndMask >> test;  // 00000000 00000001
        Console.WriteLine(bit);
    }
}
