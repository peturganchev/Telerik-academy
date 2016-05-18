using System;

class HexToDec
{
    static void Main()
    {
        string number = Console.ReadLine();
        string result = HexToDe(number);
        Console.WriteLine(result);
    }
    static string HexToDe(string number)
    {
        int fromBase = 16;
        int toBase = 10;
        String result = Convert.ToString(Convert.ToInt64(number, fromBase), toBase).ToUpper();
        return result;
    }
}