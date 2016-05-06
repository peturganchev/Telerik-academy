using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            int firstNum = Math.Abs(int.Parse(input[0]));
            int secondNum = Math.Abs(int.Parse(input[1])); ;

            while (firstNum != 0 && secondNum != 0)
            {
                if (firstNum > secondNum)
                    firstNum %= secondNum;
                else
                    secondNum %= firstNum;
            }

            if (firstNum == 0)
                Console.WriteLine(secondNum);
            else
                Console.WriteLine(firstNum);
        }
    }
}