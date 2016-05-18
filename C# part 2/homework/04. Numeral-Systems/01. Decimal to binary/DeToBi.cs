using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        Console.WriteLine(DeToBi(number));
    }
    static string DeToBi(long number)
    {
        long remainder = 0;
        string Binary = null;
        while (number > 0)
        {
            remainder = number % 2;
            number /= 2;
            Binary = remainder + Binary;
        }
        return Binary;
    }
}

