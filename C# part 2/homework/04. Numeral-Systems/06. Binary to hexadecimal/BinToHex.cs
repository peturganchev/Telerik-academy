using System;

class BinToHex
{
    static void Main()
    {
        string number = Console.ReadLine();
        string result = BiToHex(number);
        Console.WriteLine(result);
    }
    static string BiToHex(string number)
    {
        int fromBase = 2;
        int toBase = 16;
        String result = Convert.ToString(Convert.ToInt64(number, fromBase), toBase).ToUpper();
        return result;
    }
}