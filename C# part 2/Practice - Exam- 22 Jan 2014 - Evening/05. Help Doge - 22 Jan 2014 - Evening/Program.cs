using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string[] nm = Console.ReadLine().Split(' '); // Size of matrix (we ignore that because Doge is a smart Doge).
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[0]);
        nm = Console.ReadLine().Split(' '); // (x,y) of food (Doge must get there!!!!).
        int Fx = int.Parse(nm[0]);
        int Fy = int.Parse(nm[1]);
        bool[,] boolMatrix = new bool[Fx + 1, Fy + 1]; // Our reference to where are the enemies. The matrix is not bigger than food(x,y) (no point for Doge to go there).
        int K = int.Parse(Console.ReadLine()); // How much reverse Doge's there are (They are scary and want to beat Doge).
        int Kx;
        int Ky;
        for (int i = 0; i < K; i++)
        {
            nm = Console.ReadLine().Split(' '); // (x,y) of a reverse Doge (It bites Doge if Doge go there).
            Kx = int.Parse(nm[0]);
            Ky = int.Parse(nm[1]);
            if (Kx <= Fx && Ky <= Fy)
            {
                boolMatrix[Kx, Ky] = true; // If a reverse Doge is in the food region then mark the enemy location.
            }
        }
        BigInteger[,] pathMatrix = new BigInteger[Fx + 1, Fy + 1]; // Doge's safe path map.
        pathMatrix[0, 0] = 1;
        for (int i = 1; i < pathMatrix.GetLength(0); i++)
        {
            pathMatrix[i, 0] = boolMatrix[i, 0] ? 0 : pathMatrix[i - 1, 0]; // If there is a reverse Doge in the first col then mark it danger(0) or else mark it safe(1).
        }
        for (int j = 1; j < pathMatrix.GetLength(1); j++)
        {
            pathMatrix[0, j] = boolMatrix[0, j] ? 0 : pathMatrix[0, j - 1]; // If there is a reverse Doge in the first row then mark it danger(0) or else mark it safe(1).
        }
        for (int i = 1; i < pathMatrix.GetLength(0); i++)
        {
            for (int j = 1; j < pathMatrix.GetLength(1); j++)
            {
                pathMatrix[i, j] = boolMatrix[i, j] ? 0 : pathMatrix[i, j - 1] + pathMatrix[i - 1, j]; // If there is a reverse Doge mark it danger(0) or else mark it safe(sum of the left and top boxes)
            }
        }
        Console.WriteLine(pathMatrix[Fx, Fy]); // Print the sum in the food's box (number of safe paths to the food)
    }
}