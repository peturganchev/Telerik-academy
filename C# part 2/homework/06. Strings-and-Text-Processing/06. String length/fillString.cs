using System;

class fillString
{
    static string fillSmallerString(string text, int maxLength)
    {
        text = text.Replace(@"\", string.Empty);
        int sizeOfText = text.Length;
        if (sizeOfText < maxLength)
        {

            for (int i = sizeOfText + 1; i < maxLength; i++)
            {
                text += '*';
            }
        }
        return text;
    }
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        int maxLength = 21;
        text = fillSmallerString(text, maxLength);
        Console.WriteLine(text);
    }
}