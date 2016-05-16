using System;

class ModifyBit
{
    static void Main()
    {
        ulong p = ulong.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        byte i = byte.Parse(Console.ReadLine());
        ulong mask = 1;
        ulong result;
        if (i == 0)
        {
            result = ~(mask << n) & p;
        }
        else
        {
            result = (mask << n) | p;
        }
        Console.WriteLine(result);
    }
}
