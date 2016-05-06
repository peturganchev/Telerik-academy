using System;

class Program
{
    static void Main()
    {
        string read = Console.ReadLine();
        switch (read)
        {
            case "integer":
                {
                    int numberInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(numberInt + 1);
                }
                break;
            case "real":
                {
                    double numberDouble = double.Parse(Console.ReadLine());
                    numberDouble = numberDouble + 1;
                    Console.WriteLine("{0:F2}", numberDouble);
                }
                break;
            case "text":
                {
                    string text = Console.ReadLine();
                    Console.WriteLine("{0}*",text);
                }
                break;
        }
    }
}

