using System;

class Compare_Char_Arrays
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        char[] firstArray = first.ToCharArray();
        char[] secondArray = second.ToCharArray();
        string result = "";
        bool areEqual = true;
        int smaller = Math.Min(firstArray.Length, secondArray.Length);
        if (firstArray.Length != secondArray.Length)
        {
            for (int i = 0; i < smaller; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    result = (firstArray[i] < secondArray[i]) ? "<" : ">";
                    areEqual = false;
                    break;
                }
                else
                {
                    result = (firstArray.Length < secondArray.Length) ? "<" : ">";
                    areEqual = false;
                }
            }
        }
        else
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    result = (firstArray[i] < secondArray[i]) ? "<" : ">";
                    areEqual = false;
                    break;
                }
            }
        }
        Console.WriteLine(areEqual ? "=" : result);
    }
}