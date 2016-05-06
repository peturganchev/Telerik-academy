using System;

class SumOfEvenDivisors
{
    static void Main(string[] args)
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
       int sum = 0;
        for (int i = A; i <= B; i++)
        {
            int number = i;
            for (int j = 2; j <= number; j++)
            {

                if (number % j == 0 & j % 2 == 0)
                {
                    sum += j;
                }
            }
        }
        Console.WriteLine(sum);
    }
}
