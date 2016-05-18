using System;

class Program
{
    static void Main()
    {
        string numberString = Console.ReadLine();
        numberString = Reverse(numberString);
        Console.WriteLine(numberString);
    }
    static string Reverse(string numberString)
    {
        char[] charArray = numberString.ToCharArray();
        numberString = null;
        for (int i = charArray.Length - 1; i >= 0; i--)
        {
            numberString += charArray[i];
        }
        return numberString;
    }
}
