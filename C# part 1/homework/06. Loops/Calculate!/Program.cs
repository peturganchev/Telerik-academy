using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double result = 0;
            long f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
                result = result + f / Math.Pow(x, i);
            }
            result = result + 1;
            Console.WriteLine("{0:F5}", result);
        }
    }
}