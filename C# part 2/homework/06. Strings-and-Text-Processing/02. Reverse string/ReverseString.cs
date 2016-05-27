using System;
using System.Text;

class ReverseString
{
    static string stringReverser(string text)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = text.Length-1; i >= 0; i--)
        {
            sb.Append(text[i]);
        }
        return sb.ToString();
    }

    static void Main()
    {
        string text = Console.ReadLine();
        string reversedString = stringReverser(text);
        Console.WriteLine(reversedString);
    }
}