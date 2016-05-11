using System;

class Prime_Numbers
{
    static void Main()
    {

        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length + 1];
        int result = 0;
        for (int i = 2; i <= length; i++)
        {
            if (arr[i] == 0)
            {
                result = i;

                for (int j = i * i; j <= length; j += i)
                {
                    arr[j] = 1;
                }
            }
        }

        Console.WriteLine(result);
    }
}
