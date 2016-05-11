using System;

class Index_of_letters
{
    static void Main()
    {
        char[] alphabet = new char[26];
        string word = Console.ReadLine().ToUpper();
        char[] wordToChar = word.ToCharArray();
        int index = 0;
        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)(i + 65);
        }
        for (int i = 0; i < wordToChar.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (wordToChar[i] == alphabet[j])
                {
                    index = j;
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}