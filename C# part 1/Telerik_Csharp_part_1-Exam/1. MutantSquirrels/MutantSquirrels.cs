using System;

    class MutantSquirrels
    {
        static void Main(string[] args)
        {
            double T = int.Parse(Console.ReadLine());
            double B = int.Parse(Console.ReadLine());
            double S = int.Parse(Console.ReadLine());
            double N = int.Parse(Console.ReadLine());
            double sumtails = T * S * B * N;
            if (sumtails % 2 == 0)
            {
                sumtails = sumtails * 376439;
            }
            else if (sumtails%2>0)
            {
                sumtails = sumtails / 7;
            }
        else
        {
            sumtails = 0;
        }
            Console.WriteLine("{0:F3}",sumtails);
        }
    }
