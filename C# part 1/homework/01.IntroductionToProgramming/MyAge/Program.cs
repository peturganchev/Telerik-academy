using System;

namespace MyAge
{
    class MyAge
    {
        static void Main()
        {
            DateTime myDate = DateTime.Parse(Console.ReadLine());
            int myAgeNow = (int)((DateTime.Now - myDate).TotalDays / 365.242199);
            Console.WriteLine(myAgeNow);
            int myAgeAfter = myAgeNow + 10;
            Console.WriteLine(myAgeAfter);
        }
    }
}
