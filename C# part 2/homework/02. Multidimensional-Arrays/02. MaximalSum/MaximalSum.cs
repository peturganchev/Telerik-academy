using System;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        string text = Console.ReadLine();
        int[] n_m = text
            .Split(' ')
            .Select(z => int.Parse(z))
            .ToArray();
        int row = n_m[0];
        int col = n_m[1];
        int[,] matrix = new int[row,col];
        int BestSum = int.MinValue;
        // input for the matrix
        for (int i = 0; i < row; i++)
        {
            int[] numbers = Console
        .ReadLine()
        .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(item => int.Parse(item))
        .ToArray();
            for (int j = 0; j < col; j++)
            {
                matrix[i,j] = numbers[j];
            }
        }
        //finding the best sum
        for (int i = 0; i < row-2; i++)
        {
            for (int j = 0; j < col-2; j++)
            {
                int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                if (sum>BestSum)
                {
                    BestSum = sum;
                }
            }
        }
        Console.WriteLine(BestSum);
    }
}