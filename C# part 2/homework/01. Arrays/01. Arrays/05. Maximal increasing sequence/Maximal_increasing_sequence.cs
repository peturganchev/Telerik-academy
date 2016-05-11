using System;

class Maximal_increasing_sequence
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int number = 0;
        int curentSequence = 0;
        int maxSequence = 0;
        bool firstNumber = true;
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            if (firstNumber)
            {
                curentSequence = 1;
                maxSequence = 1;
                firstNumber = false;
                number = array[i];
            }
            else
            {
                if (number < array[i])
                {
                    ++curentSequence;
                    maxSequence = (curentSequence > maxSequence) ? curentSequence : maxSequence;
                }
                else
                {
                    maxSequence = (curentSequence > maxSequence) ? curentSequence : maxSequence;
                    curentSequence = 1;
                }
                number = array[i];
            }
        }
        Console.WriteLine(maxSequence);
    }
}