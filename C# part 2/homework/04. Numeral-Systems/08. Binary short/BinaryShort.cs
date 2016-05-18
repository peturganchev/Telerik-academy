using System;

class BinaryShort
{
    static void Main()
    {
        short number = short.Parse(Console.ReadLine());
        Console.WriteLine(ShortBinary(number));
    }
    static string ShortBinary(short number)
    {
        char[] result = new char[16];
        for (int i = 0, pos = 15; i < 16; i++, pos--)
        {
            if ((number & (1 << i)) != 0)
            {
                result[pos] = '1';
            }
            else
            {
                result[pos] = '0';
            }
        }
        return new string(result);
    }
}
