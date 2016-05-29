using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class extract
{
    static string ExtractSentenceFromText(string text, string keyword)
    {
        StringBuilder extractedSentences = new StringBuilder();
        string[] sentenceArray = text.Split(new[] { '.' },
            StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .ToArray();
        for (int i = 0; i < sentenceArray.Length; i++)
        {
            if (wordIsFound(sentenceArray[i], keyword))
            {
                extractedSentences.Append(sentenceArray[i] + ". ");
            }
        }
        return extractedSentences.ToString().Trim();
    }
    static bool wordIsFound(string sentance, string keyword)
    {
        bool found = false;
        int nextIndexOfWord = sentance.IndexOf(keyword);
        int lastIndex = sentance.Length - keyword.Length;
        while (nextIndexOfWord > -1)
        {
            if (nextIndexOfWord != 0 &&
              ((char.IsLetter(sentance[nextIndexOfWord - 1])) ||
               (sentance[nextIndexOfWord - 1] == '-')))
            {
                nextIndexOfWord = sentance.IndexOf(keyword, nextIndexOfWord + 1);
            }
            else if (nextIndexOfWord < lastIndex &&
                ((char.IsLetter(sentance[nextIndexOfWord + keyword.Length]) ||
                (sentance[nextIndexOfWord + keyword.Length] == '-'))))
            {
                nextIndexOfWord = sentance.IndexOf(keyword, nextIndexOfWord + 1);
            }
            else
            {
                found = true;
                break;
            }
        }
        return found;
    }
    static void Main()
    {
        string keyword = Console.ReadLine();
        string text = Console.ReadLine();
        text = text.Replace(@"\", string.Empty);
        text = ExtractSentenceFromText(text, keyword);
        Console.WriteLine(text);
    }
}