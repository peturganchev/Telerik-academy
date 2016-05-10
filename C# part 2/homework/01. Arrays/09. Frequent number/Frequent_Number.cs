using System;

namespace _09.Frequent_number
{
    class Frequent_Number
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int currentNum = 0;
            int mNum = 0;
            int currentrepeat = 0;
            int mostrepeat = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            currentNum = array[0];
            for (int i = 0; i < n; i++)
            {
                currentrepeat = 0;
                for (int j = 0; j < n; j++)
                {
                    if (currentNum == array[j])
                    {
                        currentrepeat++;
                    }
                }
                if (currentrepeat > mostrepeat)
                {
                    mNum = currentNum;
                    mostrepeat = currentrepeat;
                }
                currentNum = array[i];
            }
            Console.WriteLine("{0} ({1} times)", mNum, mostrepeat);
        }
    }
}
