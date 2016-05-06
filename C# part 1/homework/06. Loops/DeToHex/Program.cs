using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiToDe
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            int fromBase = 10;
            int toBase = 16;
            String result = Convert.ToString(Convert.ToInt64(number, fromBase), toBase).ToUpper();
            Console.WriteLine(result);

        }
    }
}