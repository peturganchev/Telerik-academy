using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From1ToN
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 1; i <= n; i++)
            {
                result = result + i + " ";
            }
            Console.WriteLine(result);
        }
    }
}
