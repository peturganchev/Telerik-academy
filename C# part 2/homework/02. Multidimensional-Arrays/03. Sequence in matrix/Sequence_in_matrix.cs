using System;
using System.Linq;

public class SequenceInMatrix
{

    public static int FindRow(string[,] matrix)
    {
        var bestSubsequence = 0;
        var currentSubsequence = 1;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                var a = matrix[row, col];
                var b = matrix[row, col + 1];

                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currentSubsequence++;
                }
                else
                {
                    bestSubsequence = Math.Max(bestSubsequence, currentSubsequence);
                    currentSubsequence = 1;
                }
            }
        }

        //// in case best subsiquence include last column
        bestSubsequence = Math.Max(bestSubsequence, currentSubsequence);

        return bestSubsequence;
    }

    public static int FindCol(string[,] matrix)
    {
        var bestSubsequence = 0;
        var currentSubsequence = 1;

        for (int col = 0; col < matrix.GetLength(1); col++)

        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentSubsequence++;
                }
                else
                {
                    bestSubsequence = Math.Max(bestSubsequence, currentSubsequence);
                    currentSubsequence = 1;
                }
            }
        }

        //// in case best subsiquence include last row
        bestSubsequence = Math.Max(bestSubsequence, currentSubsequence);

        return bestSubsequence;
    }

    public static int FindRDiag(string[,] matrix)
    {
        int bestSubsequence = 0;
        int currentSubsequence = 1;
        int maxDiagonalLength = Math.Min(matrix.GetLength(0), matrix.GetLength(1));

        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] == matrix[i + 1, j + 1])
                {
                    currentSubsequence++;
                    int row = i + 1;
                    int col = j + 1;

                    while (row < maxDiagonalLength - 1 && col < matrix.GetLength(1) - 1)
                    {
                        if (matrix[row, col] == matrix[row + 1, col + 1])
                        {
                            currentSubsequence++;
                            row++;
                            col++;
                        }
                        else
                        {
                            bestSubsequence = Math.Max(bestSubsequence, currentSubsequence);
                            currentSubsequence = 1;
                            break;
                        }
                    }

                    bestSubsequence = Math.Max(bestSubsequence, currentSubsequence);
                    currentSubsequence = 1;
                }
            }
        }

        return bestSubsequence;
    }

    public static int FindLdiag(string[,] matrix)
    {
        int bestSubsequence = 0;
        int currentSubsequence = 1;
        int maxDiagonalLength = Math.Min(matrix.GetLength(0), matrix.GetLength(1));

        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == matrix[i + 1, j - 1])
                {
                    currentSubsequence++;
                    int row = i + 1;
                    int col = j - 1;
                    while (row < maxDiagonalLength - 1 && col > 0)
                    {
                        if (matrix[row, col] == matrix[row + 1, col - 1])
                        {
                            currentSubsequence++;
                            row++;
                            col--;
                        }
                        else
                        {
                            bestSubsequence = Math.Max(bestSubsequence, currentSubsequence);
                            currentSubsequence = 1;
                            break;
                        }
                    }

                    bestSubsequence = Math.Max(bestSubsequence, currentSubsequence);
                    currentSubsequence = 1;
                }
            }
        }

        return bestSubsequence;
    }

    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        int[] n_m = text
            .Split(' ')
            .Select(z => int.Parse(z))
            .ToArray();
        int row = n_m[0];
        int col = n_m[1];
        string[,] matrix = new string[row, col];
        // input for the matrix
        for (int i = 0; i < row; i++)
        {

            string[] line = Console.ReadLine()
            .Split(' ')
            .Select(z => z)
            .ToArray();
            for (int j = 0; j < col; j++)
            {
                matrix[i, j] = line[j];
            }
        }
        // checking the sequences in the matrix
        int horizontalSubsequence = FindRow(matrix);
        int vertivalSubsequence = FindCol(matrix);
        int rigthDiagonl = FindRDiag(matrix);
        int leftDiagonal = FindLdiag(matrix);
        int bestSubsequence = Math.Max(Math.Max(horizontalSubsequence, vertivalSubsequence), Math.Max(leftDiagonal, rigthDiagonl));
        Console.WriteLine(bestSubsequence);
    }
}