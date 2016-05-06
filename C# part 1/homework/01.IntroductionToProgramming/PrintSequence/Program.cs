using System;

namespace Problem9_PrintASequence
{
    class PrintASequence
    {
        static void Main()
        {
            for (int i = 2; i < 12; i++)
            {
                Console.WriteLine(i * Math.Pow(-1, i)); //Използваме формулата i*(-1)^i. Така когато i е положително и числото е положително и обратното.
            }

        }
    }
}
