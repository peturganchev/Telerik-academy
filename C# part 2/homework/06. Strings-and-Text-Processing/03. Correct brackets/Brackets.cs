using System;

class Brackets
{
    static string searchForBrackets(string text)
    {
        int openBracket = 0;
        int closeBracket = 0;
        for (int i = 0; i < text.Length; i++)
        {

            char ch = text[i];
            if (ch == '(')          // count how manny ( brackets there are
            {
                openBracket++;
            }
            else if (ch == ')')    // count how manny ) brackets there are
            {
                closeBracket++;
            }
        }
        if (openBracket != closeBracket)
        {
            text = "Incorrect";
        }
        else
        {
            text = "Correct";
        }
        return text;
    }
    static void Main()
    {
        string text = Console.ReadLine();
        string result = searchForBrackets(text);
        Console.WriteLine(result);
    }
}
