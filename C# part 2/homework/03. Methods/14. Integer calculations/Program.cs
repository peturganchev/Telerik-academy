using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_calculations
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int minimum = minimumOfNumbers(array);
            int maximum = maximumOFnumbers(array);
            double average = averageOfNumbers(array);
            int sum = sumOfNumbers(array);
            long product = productOfNumbers(array);
            Console.WriteLine(minimum);
            Console.WriteLine(maximum);
            Console.WriteLine("{0:F2}", average);
            Console.WriteLine(sum);
            Console.WriteLine(product);
        }
        static int minimumOfNumbers(int[] array)
        {
            int minimum = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (minimum > array[i])
                {
                    minimum = array[i];
                }
            }
            return minimum;
        }
        static int maximumOFnumbers(int[] array)
        {
            int maximum = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (maximum < array[i])
                {
                    maximum = array[i];
                }
            }
            return maximum;
        }
        static double averageOfNumbers(int[] array)
        {
            double sum = sumOfNumbers(array);
            double avarage = sum / array.Length;
            return avarage;
        }
        static int sumOfNumbers(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static long productOfNumbers(int[] array)
        {
            long product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }
    }
}
