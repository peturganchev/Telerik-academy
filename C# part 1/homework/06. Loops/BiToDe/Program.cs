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
            int theNumber;
            theNumber = Convert.ToInt32(number, 2);
            Console.WriteLine(theNumber);
        }
    }
}
