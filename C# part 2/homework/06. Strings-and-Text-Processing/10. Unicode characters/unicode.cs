using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static string stringToUnicode(string text)
    {
        StringBuilder unicodeText = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            unicodeText.Append(GetEscapeSequence(text[i]));
        }
        return unicodeText.ToString();
    }
    static string GetEscapeSequence(char c)
    {
        return "\\u" + ((int)c).ToString("X4");
    }
    static void Main()
    {
        string text = Console.ReadLine();
        text = stringToUnicode(text);
        Console.WriteLine(text);
    }
}