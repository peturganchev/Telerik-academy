using System;

class Program
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        long A = 0;
        long B = 1;
        if (n >= 1)
        {
            if (n <= 50)
            {
                Console.Write(A);
                for (int i = 1; i < n; i++)
                {
                    long temp = A;
                    A = B;
                    B = temp + B;
                    Console.Write(", " + A);
                }
            }

        }
    }
}
