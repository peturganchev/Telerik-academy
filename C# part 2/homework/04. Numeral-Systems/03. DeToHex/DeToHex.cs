using System;

class DeToHex
{
    static void Main()
    {
        string number = Console.ReadLine();
        string result = DecToHex(number);
        Console.WriteLine(result);
    }
    static string DecToHex(string number)
    {
        int fromBase = 10;
        int toBase = 16;
        String result = Convert.ToString(Convert.ToInt64(number, fromBase), toBase).ToUpper();
        return result;
    }
}