using System;

class OneToAll
{
    static void Main()
    {
        long fromBase = long.Parse(Console.ReadLine());
        string number = Console.ReadLine();
        long toBase = long.Parse(Console.ReadLine());
        Console.WriteLine(fromDeToBaseOne(fromBaseOneToDe(number, fromBase), toBase));
    }
    static long Pow(long number, long power)
    {
        long result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= number;
        }

        return result;
    }
    static long fromBaseOneToDe(string number, long baseSystem)
    {
        long deNumber = 0;
        for (int i = 0; i < number.Length; i++)
        {
            long digit = 0;
            if (number[i] >= '0' && number[i] <= '9')
            {
                digit = number[i] - '0';
            }
            else
            {
                digit = number[i] - 'A' + 10;
            }

            deNumber += digit * Pow(baseSystem, number.Length - i - 1);
        }
        return deNumber;
    }
    static string fromDeToBaseOne(long decimalNumber, long baseSystem)
    {
        string result = string.Empty;
        while (decimalNumber > 0)
        {
            long digit = decimalNumber % baseSystem;
            if (digit >= 0 && digit <= 9)
            {
                result = (char)(digit + '0') + result;
            }
            else
            {
                result = (char)(digit - 10 + 'A') + result;
            }
            decimalNumber /= baseSystem;
        }
        return result;
    }
}
