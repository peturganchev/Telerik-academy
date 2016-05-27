using System;
using System.Collections.Generic;
using System.Text;

class ParseTags
{
    static List<int> searchForTags(string text, string openTag, string closeTag)
    {
        List<int> indexes = new List<int>();
        int i = 0;
        int openTagLength = openTag.Length;
        int closeTagLength = closeTag.Length;
        int nextOpenTagIndex = text.IndexOf(openTag);
        int nextCloseTagIndex = 0;
        while (nextOpenTagIndex != -1 && nextCloseTagIndex != -1)
        {
            indexes.Add(nextOpenTagIndex + openTagLength);
            nextCloseTagIndex = text.IndexOf(closeTag, nextOpenTagIndex + openTagLength - 1);
            indexes.Add(nextCloseTagIndex + closeTagLength);

            if (nextCloseTagIndex + closeTagLength < text.Length)
            {
                nextOpenTagIndex = text.IndexOf(openTag, nextCloseTagIndex + closeTagLength - 1);
            }
            else
            {
                break;
            }
            
        }

        return indexes;
    }

    static string ParseText(string text, List<int> indexes, string openTag, string closeTag)
    {
        StringBuilder parsedText = new StringBuilder();
        int openTagIndex = 0;
        int closeTagIndex = 0;
        if (indexes.Count > 0)
        {
            for (int i = 0; i < indexes.Count; i += 2)
            {
                openTagIndex = indexes[i];
                parsedText.Append(text.Substring(closeTagIndex, openTagIndex - openTag.Length - closeTagIndex));
                closeTagIndex = indexes[i + 1];
                int parsetextLength = closeTagIndex - openTagIndex - closeTag.Length;
                parsedText.Append(text.Substring(openTagIndex, parsetextLength).ToUpper());
            }
            parsedText.Append(text.Substring(indexes[indexes.Count - 1]));
        }
        else
        {
            parsedText.Append(text);
        }
        return parsedText.ToString();
    }
    static void Main()
    {
        string text = Console.ReadLine();
        string parsedHTML = Regex.Replace(text, "(<a href=\")(.*?)(\">)(.*?)(</a>)", "[$4]($2)");
        Console.WriteLine(parsedHTML);
    }
}