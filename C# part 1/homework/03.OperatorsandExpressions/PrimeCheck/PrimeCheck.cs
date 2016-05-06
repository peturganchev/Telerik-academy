using System;

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int testMe = 0;
            if (number <= 1)
            {
                Console.WriteLine("false");
            }
            if (number > 1)
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        testMe = testMe + 1;
                    }
                }
                Console.WriteLine(testMe > 0 ? "false" : "true");
            }

        }
    }
}
