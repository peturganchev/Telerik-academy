using System;

namespace MMSA
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double[] masiv= new double[n];
            double min;
            double max;
            double sum=0;
            double average = 0;
            for (int i = 0; i < n; i++)
            {
                masiv[i] = double.Parse(Console.ReadLine());
            }
            min = masiv[0];
            max = masiv[0];
            foreach (var c in masiv)
            {
                if (min > c)
                {
                    min = c;
                }
                sum += c;
                if (max<c)
                {
                    max = c;
                }
            }
            average = sum / n;
            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}",max);
            Console.WriteLine("sum={0:F2}",sum);
            Console.WriteLine("avg={0:F2}", average);
        }


    }
}
