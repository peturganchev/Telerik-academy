using System;

class Patterns
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        for (int i = 0; i < size; i++) // fill the matrix with numbers
        {
            string[] line = Console.ReadLine().Split(' '); // split the numbers on a the line
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = int.Parse(line[j]); // input the numbers from the line to the matrix
            }
        }
        long maxsum = long.MinValue;
        long sum = 0;
        bool found = false; 
        for (int i = 0; i < size - 2; i++) // search for pattern
        {
            for (int j = 0; j < size - 4; j++)
            {
                if ((matrix[i, j] + 1 == matrix[i, j + 1]) // if patern found
                   && (matrix[i, j] + 2 == matrix[i, j + 2])
                   && (matrix[i, j] + 3 == matrix[i + 1, j + 2])
                   && (matrix[i, j] + 4 == matrix[i + 2, j + 2])
                   && (matrix[i, j] + 5 == matrix[i + 2, j + 3])
                   && (matrix[i, j] + 6 == matrix[i + 2, j + 4]))
                {
                    found = true; // if found then set found true
                    sum = (long)7 * matrix[i, j] + 21; // sum of the patern
                }
                if (maxsum < sum) 
                {
                    maxsum = sum;
                }
            }
        }

        if (!found) // if there is no pattern then calculate the diagonal
        {
            long diag = 0;
            for (int i = 0; i < size; i++)
            {
                diag += matrix[i, i];
            }
            Console.WriteLine("NO {0}", diag);
        }
        else
        {
            Console.WriteLine("YES {0}", maxsum);
        }
    }
}