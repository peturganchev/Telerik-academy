using System;

class Fill_the_matrix
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        char typeOfMatrix = char.Parse(Console.ReadLine());
        int[,] matrix = new int[length, length];
        int count = 1;
        int col = 0;
        int row = 0;
        int switcher = length - 1;
        switch (typeOfMatrix)
        {
            case 'a':
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        matrix[j, i] = count;
                        count++;
                    }
                }
                break;
            case 'b':

                for (int i = 0; i < length; i++)
                {
                    if (i % 2 == 0)
                    {
                        for (int j = 0; j < length; j++)
                        {
                            matrix[j, i] = count;
                            count++;
                        }
                    }
                    else
                    {
                        for (int j = length - 1; j >= 0; j--)
                        {
                            matrix[j, i] = count;
                            count++;
                        }
                    }
                }
                break;
            case 'c':
                row = length - 1;
                col = 0;
                for (int i = 0; i < length * length; i++)
                {
                    if (row == length && col < length)
                    {
                        count++;
                        row = length - count;
                        col = 0;
                    }
                    else if (col == length && col <= length)
                    {
                        count--;
                        col = length - count;
                        row = 0;
                    }
                    matrix[row, col] = i + 1;
                    row++;
                    col++;
                }
                break;
            case 'd':
                while (switcher > 0)
                {
                    // Going down
                    for (int down = row; down < switcher+row; down++)
                    {
                        matrix[down, row] = count;
                        count++;
                    }
                    //Going right
                    for (int right = row; right < switcher+col; right++)
                    {
                        matrix[col+switcher, right] = count;
                        count++;
                    }
                    //Going up
                    for (int up = length-1-col; up > row; up--)
                    {
                        matrix[up,switcher+row] = count;
                        count++;
                    }
                    //Goin left
                    for (int left = switcher+col ; left > col; left--)
                    {
                        matrix[row,left] = count;
                        count++;
                    }
                    row += 1;
                    col += 1;
                    switcher -= 2;
                }
                break;
            default:
                break;
        }
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                if (j == 0)
                {
                    Console.Write(matrix[i, j]);
                }
                else
                {
                    Console.Write(" " + matrix[i, j]);
                }
            }
            Console.WriteLine();
        }
    }
}