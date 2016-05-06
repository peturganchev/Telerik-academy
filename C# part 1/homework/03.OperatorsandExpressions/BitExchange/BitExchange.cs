using System;

class BitExchange
{
    public const int FirstStartPosition = 3;
    public const int SecondStartPosition = 24;
    public const int length = 3;
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        uint firstBit = 0;
        uint secondBit = 0;
        uint newNumber = 0;
        newNumber = number;
        for (int i = 0; i < length; i++)
        {
            firstBit = ReadBit(number, FirstStartPosition + i);
            secondBit = ReadBit(number, SecondStartPosition + i);
            newNumber = WriteBit(newNumber, FirstStartPosition + i, secondBit);
            newNumber = WriteBit(newNumber, SecondStartPosition + i, firstBit);
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

