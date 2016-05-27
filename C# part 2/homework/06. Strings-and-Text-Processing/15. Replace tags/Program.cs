using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class P15
{
    static List<int> searchForTags(string text, string openHref, string aftherURL, string closeTag)
    {
        List<int> indexes = new List<int>();
        int openHrefLength = openHref.Length;
        int aftherURLLength = aftherURL.Length;
        int closeTagLength = closeTag.Length;
        int nextOpenHref = text.IndexOf(openHref);
        int nextaftherURL = 0;
        int nextcloseTag = 0;
        while (nextOpenHref != -1 && nextcloseTag != -1)
        {
            indexes.Add(nextOpenHref + openHrefLength);
            nextaftherURL = text.IndexOf(aftherURL, nextOpenHref + openHrefLength - 1);
            indexes.Add(nextaftherURL + aftherURLLength);
            nextcloseTag = text.IndexOf(closeTag, nextaftherURL + openHrefLength - 1);
            indexes.Add(nextcloseTag + closeTagLength);
            if (nextcloseTag + closeTagLength < text.Length)
            {
                nextOpenHref = text.IndexOf(openHref, nextcloseTag + closeTagLength - 1);
            }
            else
            {
                break;
            }
        }
        return indexes;
    }
    static string ParsedHTML(string text, List<int> indexes, string openHref, string aftherURL, string closeTag)
    {
        StringBuilder parsedText = new StringBuilder();
        int openHrefIndex = 0;
        int afterURLIndex = 0;
        int closeTagIndex = 0;
        if (indexes.Count > 0)
        {
            for (int i = 0; i < indexes.Count; i += 3)
            {
                openHrefIndex = indexes[i];
                parsedText.Append(text.Substring(closeTagIndex, openHrefIndex - openHref.Length - closeTagIndex));
                afterURLIndex = indexes[i + 1];
                closeTagIndex = indexes[i + 2];
                int parsetextLength = closeTagIndex - afterURLIndex - closeTag.Length;
                parsedText.Append("[" + text.Substring(afterURLIndex, parsetextLength) + "]");
                parsetextLength = afterURLIndex - openHrefIndex - aftherURL.Length;
                parsedText.Append("(" + text.Substring(openHrefIndex, parsetextLength) + ")");
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
        string openHref = "<a href=\"";
        string aftherURL = "\">";
        string closeTag = "</a>";
        List<int> indexes = searchForTags(text, openHref, aftherURL, closeTag);
        string textAfterParse = ParsedHTML(text, indexes, openHref, aftherURL, closeTag);
        Console.WriteLine(textAfterParse);
    }
}