using System;

class HexToBin
{
    static void Main()
    {
        string number = Console.ReadLine();
        string result = HexToBi(number);
        Console.WriteLine(result);
    }
    static string HexToBi(string number)
    {
        int fromBase = 16;
        int toBase = 2;
        String result = Convert.ToString(Convert.ToInt64(number, fromBase), toBase).ToUpper();
        return result;
    }
}
