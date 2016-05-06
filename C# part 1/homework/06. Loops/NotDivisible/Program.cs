using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDivisible
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 1; i <= n; i++)
            {
                if (i % 7 > 0)
                {
                    if (i % 3 > 0)
                    {
                        result = result + i + " ";
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
