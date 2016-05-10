using System;

class Maximal_sequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int number = 0;
        int curentSequence = 0;
        int maxSequence = 0;
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        number = array[0];
        for (int i = 0; i < n; i++)
        {
            if (number == array[i])
            {
                curentSequence++;

                if (curentSequence > maxSequence)
                {
                    maxSequence = curentSequence;
                }
            }
            else
            {
                number = array[i];

                if (curentSequence > maxSequence)
                {
                    maxSequence = curentSequence;
  
                }
                curentSequence = 1;
            }
        }
        Console.WriteLine(maxSequence);
    }
}

/*                 Console.WriteLine("cs++ = {1} cycle{0}",i,curentSequence);
                   Console.WriteLine("reset number = {0} cycle: {1}  max={2}",number,i,maxSequence);
                   Console.WriteLine("maxs = {0}; cycle {1}",maxSequence,i); */

