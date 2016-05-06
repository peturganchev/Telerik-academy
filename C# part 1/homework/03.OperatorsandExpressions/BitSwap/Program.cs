using System;

class BitExchange
{

    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        uint firstBit = 0;
        uint secondBit = 0;
        uint newNumber = 0;
        newNumber = n;
        for (int i = 0; i < k; i++)
        {
            firstBit = ReadBit(n, p + i);
            secondBit = ReadBit(n, q + i);
            newNumber = WriteBit(newNumber, p + i, secondBit);
            newNumber = WriteBit(newNumber, q + i, firstBit);
        }
        Console.WriteLine(newNumber);
    }
    public static uint ReadBit(uint number, int position)
    {
        uint mask = 1;
        uint numberAndMask = mask << position & number;
        uint bit = numberAndMask >> position;
        return bit;
    }

    public static uint WriteBit(uint number, int position, uint bit)
    {
        uint mask = 1;
        uint newNumber;

        if (bit == 0)
        {
            mask = 1;
            newNumber = number & ~(mask << position);
        }
        else
        {
            mask = 1;
            newNumber = number | mask << position;
        }

        return newNumber;
    }
}

