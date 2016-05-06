using System;


class fourdigits
{
    static void main()
    {
        int number = int.Parse(Console.ReadLine());
        int a, b, c, d;
        a = (number / 1000) % 10;
        b = (number / 100) % 10;
        c = (number / 10) % 10;
        d = number % 10;
        Console.WriteLine(a + b + c + d);
        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
    }
}

