using System;

class EnglishDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int lastDigit = number % 10;
        Console.WriteLine(DigitToWord(lastDigit));
    }
    static string DigitToWord(int lastDigit)
    {
        string[] digitsInWords =
        {
            "zero","one","two","three","four","five","six","seven","eight","nine"
        };
        return digitsInWords[lastDigit];
    }
}
