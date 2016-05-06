using System;

namespace HelloWorld
{
    class PrintASequence
    {
        static void Main()
        {
            DateTime myDate = DateTime.Parse(Console.ReadLine());
            int myAge = (int)((DateTime.Now - myDate ).TotalDays/ 365.242199);
            Console.WriteLine(myAge);
        }
    }
}