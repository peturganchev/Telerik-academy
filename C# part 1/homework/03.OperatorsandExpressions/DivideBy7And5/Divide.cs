using System;

class Divide
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        if (num%7 == 0)
        {
            if (num%5 == 0)
            {
                Console.WriteLine("true {0}",num);
            }
            else
            {
                Console.WriteLine("false {0}",num);
            }
        }
        else
        {
            Console.WriteLine("false {0}", num);
        }
    }
}
