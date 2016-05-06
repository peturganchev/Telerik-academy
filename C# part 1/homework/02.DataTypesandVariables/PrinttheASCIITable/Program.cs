using System;

class Program
{
    static void Main(string[] args)
    {
        string result = "";
        for (int i = 33; i < 127; i++)
        {
            char character = (char)i;
            //result = result + character;
            Console.Write((char)i);
        }
        //Console.WriteLine(result);
    }
}

