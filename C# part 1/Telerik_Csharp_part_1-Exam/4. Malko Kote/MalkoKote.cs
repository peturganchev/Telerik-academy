using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Malko_Kote
{
    class MalkoKote
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            string nul = " ";
            string sign;
            //ears 
            nul = new String(' ', ((size - 10) / 4) + 1);
            Console.WriteLine(" "+ch + nul + ch);
            //head
            sign = new String(ch, ((size - 10) / 4) + 3);
            for (int i = 0; i < ((size - 10) / 4) + 1; i++)
            {
                Console.WriteLine(" " + sign);
            }
            //neck
            sign = new String(ch, ((size - 10) / 4) + 1);
            for (int i = 0; i < ((size - 10) / 4) + 1; i++)
            {
                Console.WriteLine("  " + sign);
            }
            // shoulders+tail
            sign = new String(ch, ((size - 10) / 4) + 3);
            string tail = new String(ch, ((size - 10) / 4) + 2);
            for (int i = 0; i < ((size - 10) / 4) + 2; i++)
            {
                if (i == ((size - 10) / 4)+1)
                {
                    Console.WriteLine(" " + sign + "   " + tail);
                }
                else
                {
                    Console.WriteLine(" " + sign);
                }
            }
            // body+tail
            sign = new String(ch, ((size - 10) / 4) + 5);
            tail = new String(ch, 1);
            for (int i = 0; i < ((size - 10) / 4) + 4; i++)
            {
                if (i == ((size - 10) / 4)+3)
                {
                    Console.WriteLine(sign + " " + tail+tail);
                }
                else
                {
                    Console.WriteLine(sign+"  "+tail);
                }
            }
            //feet
            sign = new String(ch, ((size - 10) / 4) + 6);
                Console.WriteLine(" "+sign);
            Console.ReadLine();
        }
    }
}
