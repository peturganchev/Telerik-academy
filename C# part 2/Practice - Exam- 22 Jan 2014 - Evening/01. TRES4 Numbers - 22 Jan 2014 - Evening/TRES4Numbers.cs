using System;


class TRES4Numbers
{
    static void Main()
    {
        string[] alienNumbers = { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" }; // daclare the alien numbers
        ulong input = ulong.Parse(Console.ReadLine()); // get the numbers in dec numerical system
        int[] numberInNin = new int[32]; // here we store the numbers in 9 num system
        int count = 0;
        do
        {
            numberInNin[count] = (int)(input % 9); // 154%9 = 1 ... etc.
            Console.WriteLine(numberInNin[count]);
            input /= 9; // 153/9 = 17 ... etc.
            Console.WriteLine(input);
            count++;
        } while (input > 0);
        for (int i = count - 1; i >= 0; i--)
        {
            Console.Write(alienNumbers[numberInNin[i]]); // write message in alien language
        }
        Console.WriteLine();
    }
}

