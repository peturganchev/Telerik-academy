using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Bunny
{
    static void Main()
    {
        string currentCage = Console.ReadLine();
        List<int> cages = new List<int>();
        while (currentCage != "END") // put bunnies in cages until we get END
        {
            cages.Add(int.Parse(currentCage)); //add another cage
            currentCage = Console.ReadLine();  // add bunnys to the cage
        }
        for (int i = 1; i < cages.Count; i++) //
        {
            int s = 0;

            for (int j = 0; j < i; j++)
            {
                s += cages[j]; // for the first i cages sum the bunnies and write it in "s"
            }
            if (cages.Count - i < s) // if s is bigger than the number of remaining cages then stop
            {
                break;
            }

            int sum = 0;
            BigInteger product = 1;

            for (int j = i; j < i + s; j++) // get the sum and product for the rest cages
            {
                sum += cages[j];
                product *= cages[j];
            }

            string next = sum.ToString() + product.ToString(); //concatenates sum and product in a string
            for (int j = i + s; j < cages.Count; j++)
            {
                next += cages[j].ToString(); //concatenates bunnies from the rest cages to the same string
            }
            next = next.Replace("0", "").Replace("1", ""); //kill lonely bunnies and remove empty cages
            cages = next.Select(x => x - '0').ToList(); // place remaining bunnies in new cages
        }
        Console.WriteLine(string.Join(" ", cages)); // prints the surviving bunnies
    }
}