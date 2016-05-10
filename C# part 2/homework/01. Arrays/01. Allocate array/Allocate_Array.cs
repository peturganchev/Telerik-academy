using System;

class Allocate_Array
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] array = new int[number];
        for (int i = 0; i < number; i++)
        {
            array[i] = i * 5;
            Console.WriteLine(array[i]);
        }
    }
}
