using System;

class LeapYear
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        string result = null;
        result = IsYearLeap(year);
        Console.WriteLine(result);
    }
    static string IsYearLeap(int year)
    {
        string result = null;

        if (year % 100 == 0 && year % 400 == 0)
        {
            result = "Leap";
        }
        else if (year % 4 == 0 && year % 100 != 0)
        {
            result = "Leap";
        }
        else
        {
            result = "Common";
        }
        return result;
    }
}

