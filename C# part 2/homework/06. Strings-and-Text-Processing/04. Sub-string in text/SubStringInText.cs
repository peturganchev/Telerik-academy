using System;

class SubStringInText
{
    static int countSubString(string text, string searchedString)
    {
        int counter = 0;
        int index = text.IndexOf(searchedString); // set index to be the first index that the keyword is located. If its not in the string then index = -1
        while (index != -1)
        {
            counter++;
            index = text.IndexOf(searchedString, index + searchedString.Length); // search for the next occurrence of the keyword
        }
        return counter;
    }
    static void Main()
    {
        string searchedString = Console.ReadLine().ToLower();
        string text = Console.ReadLine().ToLower();
        int result = countSubString(text, searchedString);
        Console.WriteLine(result);
    }
}