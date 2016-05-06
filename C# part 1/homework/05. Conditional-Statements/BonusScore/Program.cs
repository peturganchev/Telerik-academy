using System;

namespace BonusScore
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            if (a < 1 | a > 9)
            {
                Console.WriteLine("invalid score");
            }
            else if (a >= 1 & a <= 3)
            {
                Console.WriteLine(a * 10);
            }
            else if (a >= 4 & a <= 6)
            {
                Console.WriteLine(a * 100);
            }
            else if (a >= 7 & a <= 9)
            {
                Console.WriteLine(a * 1000);
            }
        }
    }
}
