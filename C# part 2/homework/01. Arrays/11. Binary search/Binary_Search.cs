using System;

class Binary_Search
{
    static void Main()
    {
        int lenght = int.Parse(Console.ReadLine());
        int[] arr = new int[lenght];
        int searchedNum;
        int Left = 0;
        int Right = lenght - 1;
        int midle = (Left + Right) / 2;
        int counter = 0;
        int result = -1;
        for (int i = 0; i < lenght; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        searchedNum = int.Parse(Console.ReadLine());
        Array.Sort(arr);

        while (counter <= lenght / 2)
        {
            if (arr[midle] == searchedNum)
            {
                result = midle;
                break;
            }
            else if (arr[midle] < searchedNum)
            {
                Left = midle + 1;
                midle = (Left + Right) / 2;
                counter++;
            }
            else
            {
                Right = midle - 1;
                midle = (Left + Right) / 2;
                counter++;
            }
        }
        Console.WriteLine(result);
    }
}
