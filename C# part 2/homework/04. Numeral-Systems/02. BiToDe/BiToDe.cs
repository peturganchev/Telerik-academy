using System;

class BiToDec
{
    static void Main()
    {
        string number = Console.ReadLine();
        Console.WriteLine(BiToDe(number));
    }
    static long BiToDe(string number)
    {
        long result = 0;
        int pow = number.Length - 1;
        for (int i = 0; i < number.Length; i++)
        {
            int temp = number[i] - 48;
            result += temp * (long)Math.Pow(2, pow);
            pow--;
        }
        return result;
    }
}
