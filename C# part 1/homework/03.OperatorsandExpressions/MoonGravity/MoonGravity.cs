using System;

class MoonGravity
{
    static void Main()
    {
        float W = float.Parse(Console.ReadLine());
        float weight = W * 0.17f;
        Console.WriteLine("{0:0.000}", weight);
    }
}
