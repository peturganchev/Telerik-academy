using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenProduct
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int number;
            long odd = 1;
            long even = 1;
            string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(numbers[i]);
                if (i % 2 == 0)
                {
                    even *= number;
                }
                else if (i%2 != 0)
                {
                    odd *= number;
                }
            }
            if (even == odd)
            {
                Console.WriteLine("yes {0}", even);
            }
            else
            {
                Console.WriteLine("no {0} {1}",even, odd);
            }
        }
    }
}
